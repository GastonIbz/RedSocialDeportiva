using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSocialDeportiva.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticaAController : ControllerBase
    {
        private readonly BDContext context;

        public EstadisticaAController(BDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<EntidadEstadistica>>> Get()
        {
            var resp = await context.TablaEEntidad.ToListAsync();
            return resp;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EntidadEstadistica>> Get(int id)
        {
            var estadisticas = await context.TablaEEntidad
                                         .Where(e => e.id == id)
                                         //.Include(m => m.Matriculas)
                                         .FirstOrDefaultAsync();
            if (estadisticas == null)
            {
                return NotFound($"No existe el usuario de Id={id}");
            }
            return estadisticas;
        }

        [HttpPost]

        public async Task<ActionResult<int>> Post(EntidadEstadistica estadisticas)
        {
            try
            {
                context.TablaEEntidad.Add(estadisticas);
                await context.SaveChangesAsync();
                return estadisticas.id;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] EntidadEstadistica estadisticas)
        {
            if (id != estadisticas.id)
            {
                return BadRequest("Datos incorrectos");
            }

            var updateE = context.TablaEEntidad.Where(e => e.id == id).FirstOrDefault();

            if (updateE == null)
            {
                return NotFound("No existe el producto a modificar");
            }

            updateE.Username = estadisticas.Username;
            updateE.NombreEquipo = estadisticas.NombreEquipo;
            updateE.JuegoProfesional = estadisticas.JuegoProfesional;
            updateE.PosicionMundial = estadisticas.PosicionMundial;
            updateE.PosicionPaisNatal = estadisticas.PosicionPaisNatal;
            updateE.PartidasJugadas = estadisticas.PartidasJugadas;
            updateE.Ganadas = estadisticas.Ganadas;
            updateE.Perdidas = estadisticas.Perdidas;
            updateE.empatadas = estadisticas.empatadas;
            updateE.MVP = estadisticas.MVP;
            updateE.MayorLogro = estadisticas.MayorLogro;
            updateE.Horas = estadisticas.Horas;

            try
            {
                
                context.TablaEEntidad.Update(updateE);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var Borrar = context.TablaEEntidad.Where(x => x.id == id).FirstOrDefault();

            if (Borrar == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }

            try
            {
                context.TablaEEntidad.Remove(Borrar);
                context.SaveChanges();
                return Ok($"El registro de {Borrar.Username} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}
