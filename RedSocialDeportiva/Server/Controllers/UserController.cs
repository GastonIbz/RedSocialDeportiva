using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedSocial.BD.Data;
using RedSocial.BD.Data.Entidades;
using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSocialDeportiva.Server.Controllers
{
    //[Route("api/Usuarios")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        private readonly BDContext context;
        public UserController(BDContext context)
        {
            this.context = context;
            
        }

        //[HttpPost]
        //public async Task<ActionResult<LoginDataDTO>> Login(string email, string password)
        //{

        //    //    LoginDataDTO loginDataDTO = new LoginDataDTO
        //    //    {
        //    //        User = new User
        //    //        {
        //    //            UserName = "Nombre completo",
        //    //            Email = "asdasdasd@dadasd.com",
        //    //            Id = "e21e12",
        //    //            NameCompleted = "sacasc", 
        //    //            LastName = "ADS"
        //    //        },
        //    //        Token = "aaaaaaaaadqwdqwdo12kwqndkas",
        //    //        MessageError = ""
        //    //    };


        //    return Ok();
        //}

        // POST api/<UserController>
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Relacion>> Get(int id)
        //{
        //var usuario = await context.Relaciones
        //                             .Where(e => e.Id == id)
        //                             .Include(m => m.Usuarios)
        //                             .FirstOrDefaultAsync();
        //if (usuario == null)
        //{
        //    return NotFound($"No existe la especialidad de Id={id}");
        //}
        //return usuario;

        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(Usuario user)
        //public async Task<ActionResult<int>> Post(Relacion user)
        //{
        //try
        //{
        //    //context.Usuarios.Add(user);
        //    context.Relaciones.Add(user);
        //    await context.SaveChangesAsync();
        //    return user.Id;
        //}
        //catch (Exception e)
        //{
        //    return BadRequest(e.Message);
        //}
        //}

        [HttpPost("/register")]
        public async Task<ActionResult<string>> Register(RegisterDto form)
        {
            string MessageError;

            if (form == null)
            {
                MessageError = "Ha ocurrido un error";
                return NotFound(MessageError);
            }

            return Ok();

        }
    }
}
