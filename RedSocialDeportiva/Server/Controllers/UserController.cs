using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedSocial.BD.Data;
using RedSocial.BD.Data.Entidades;

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
        [HttpPost]
        public async Task<ActionResult<int>> Post(Usuario user)
        {
            try
            {
                context.Usuarios.Add(user);
                await context.SaveChangesAsync();
                return user.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuarios.ToListAsync();
        }
        /*
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var usuario = await context.Usuarios
                                         .Where(e => e.Id == id)
                                         .Include(m => m.Usuarios)
                                         .FirstOrDefaultAsync();
            if (usuario == null)
            {
                return NotFound($"No existe la especialidad de Id={id}");
            }
            return usuario;

        }
        */
        
    }
}
