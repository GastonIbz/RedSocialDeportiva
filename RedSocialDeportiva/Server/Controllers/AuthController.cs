using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister;
using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using System.Security.Cryptography;
using RedSocialDeportiva.Shared.DTO_Back.Auth;



namespace RedSocialDeportiva.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly BDContext context;
        private readonly IConfiguration _configuration;


        public AuthController(IConfiguration configuration, BDContext context)
        {
            this.context = context;
            this._configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ResponseDto<string>>> Register(DataRegisterDTO DataRegister)
        {

            ResponseDto<string> ResponseDto = new ResponseDto<string>();

            try
            {
                if (DataRegister.Email == null || DataRegister.Email == string.Empty)
                {
                    throw new Exception("Email requerido");
                }

                if (DataRegister.UserName == null || DataRegister.UserName == string.Empty)
                {
                    throw new Exception("Nombre de usuario requerido");
                }

                if (DataRegister.Password == null || DataRegister.Password == string.Empty)
                {
                    throw new Exception("Contraseña requerida");
                }
                    
                Usuario UserBD = await this.context.TablaUsuario.FirstOrDefaultAsync(Usuario => Usuario.Email == DataRegister.Email);

                if (UserBD != null)
                {
                    throw new Exception("Ya existe un usuario con este email. Intentelo nuevamente.");
                }

                CreatePasswordHash(DataRegister.Password, out byte[] passwordHash, out byte[] passwordSalt);

                this.context.TablaUsuario.Add(new Usuario
                {
                    Email = DataRegister.Email,
                    Descripcion = "",
                    ImgPerfil = "",
                    ImgPortada = "",
                    Username = DataRegister.UserName,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt
                });

                await context.SaveChangesAsync();

                ResponseDto.Data = "!Se ha registrado correctamente!! Ahora inicie sesión!.";

                return Ok(ResponseDto);

            }
            catch (Exception ex)
            {
                ResponseDto.MessageError = ex.Message;
                return BadRequest(ResponseDto);
            }

        }

        [HttpPost("login")]
        public async Task<ActionResult<ResponseDto<AuthData>>> Login(DataLoginDTO DataLogin)
        {
            ResponseDto<AuthData> ResponseDto = new ResponseDto<AuthData>();

            try
            {
                if (DataLogin.Email == null || DataLogin.Email == string.Empty)
                {
                    throw new Exception("Email incorrecto");
                }

                if (DataLogin.Password == null || DataLogin.Password == string.Empty)
                {
                    throw new Exception("Contraseña incorrecta");
                }


                Usuario UserBD = await this.context.TablaUsuario.FirstOrDefaultAsync(Usuario => Usuario.Email == DataLogin.Email);

                if (UserBD == null)
                {
                    throw new Exception("Email ingresado es incorrecto");
                }

                
                if (!this.VerifyPasswordHash(DataLogin.Password, UserBD.PasswordHash ,UserBD.PasswordSalt))
                {
                    throw new Exception("Contraseña incorrecta");
                }

                ResponseDto.Data = new AuthData
                {
                    Token = CreateToken(UserBD), //Creamos un nuevo metodo y obtiene usuario
                    User = new User
                    {
                        Email = UserBD.Email,
                        Descripcion = UserBD.Descripcion,
                        Id = UserBD.Id,
                        ImgPerfil = UserBD.ImgPerfil,
                        ImgPortada = UserBD.ImgPortada,
                        Username = UserBD.Username
                    },
                };
              
                return Ok(ResponseDto);

            }
            catch (Exception ex)
            { 
                ResponseDto.MessageError = ex.Message; 
                return BadRequest(ResponseDto);
            }      
        }




        private string CreateToken(Usuario user)
        {
            List<Claim> claims = new List<Claim> //Permisos para describir
                                                 //la informacion del usuario
            {
               new Claim(ClaimTypes.Email, user.Email) //Permiso de seguridad
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                 _configuration.GetSection("AppSettings:Token").Value)); //Clave simetrica
                                   //Obtenemos el token de configuracion 
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);//Credenciales de firma 
            var token = new JwtSecurityToken(
               claims: claims,
               expires: DateTime.Now.AddHours(2),
               signingCredentials: creds); //Defino la carga del token 

            var jwt = new JwtSecurityTokenHandler().WriteToken(token); //Defino la cadena de token
                                                                       //que quiero que retorne 

            return jwt;
            
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512()) //Algoritmo de firma 
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }


    }
}
