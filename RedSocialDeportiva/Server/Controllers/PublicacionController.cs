﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedSocial.BD.Data;
using RedSocial.BD.Data.Entidades;

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
        /*[HttpGet]
        public async Task<ActionResult<List<Publicacion>>> Get()
        {
            return await context.Publicaciones.ToListAsync();
        }*/

        [HttpGet]
        public  IEnumerable<Publicacion> Get()
        {
            using (BDContext context = new BDContext())
            {

                return context.Publicaciones.ToList(); 
            }
        }
    }
}
