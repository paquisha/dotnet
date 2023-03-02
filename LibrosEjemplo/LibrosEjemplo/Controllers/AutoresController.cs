using LibrosEjemplo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrosEjemplo.Controllers
{
    [Route("api/autores")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        public readonly ApplicationDbContextcs context;

        public AutoresController(ApplicationDbContextcs contextcs)
        {
            this.context = contextcs;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get() 
        {
            return await context.Autores.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Autor autor) 
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
