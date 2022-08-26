using Microsoft.AspNetCore.Mvc;
using RedSocial.BD.Data;

namespace RedSocialDeportiva.Server.Controllers
{
    [ApiController]
    [Route("api/Publicacion")]
    public class PublicacionController:ControllerBase
    {
        private readonly BDContext context;

        public PublicacionController(BDContext context)
        {
            this.context = context;
        }
    }
}
