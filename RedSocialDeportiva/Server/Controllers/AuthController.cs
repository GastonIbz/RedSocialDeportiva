using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RedSocial.BD.Data;
using RedSocial.BD.Data.Entidades;
using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister;
using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using System.Security.Cryptography;
using RedSocialDeportiva.Shared.DTO_Back;
using Microsoft.EntityFrameworkCore;

namespace RedSocialDeportiva.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly BDContext context;
        private readonly IConfiguration _configuration;


        public static Usuario user = new Usuario();

        

        public AuthController(IConfiguration configuration, BDContext context)
        {
            this.context = context;
            this._configuration = configuration;
        }
        /*
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
         
            
                
                CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

                user.Username = request.Username;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Email = request.Email;

                
                return Ok(user);

           
            
        }
        */
        [HttpPost("login")]
        public async Task<ActionResult<ResponseDto<UserData>>> Login(DataLoginDTO DataLogin)
        {
            ResponseDto<UserData> ResponseDto = new ResponseDto<UserData>();

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


                
                if (UserBD !=null && !this.VerifyPasswordHash(DataLogin.Password, UserBD.PasswordHash ,UserBD.PasswordSalt))
                {
                    return BadRequest("Contraseña incorrecta");
                }
                string token = CreateToken(user); //Creamos un nuevo metodo y obtiene usuario
                
                return Ok(token);

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
