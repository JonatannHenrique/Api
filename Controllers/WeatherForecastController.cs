using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using primeiraApi.Models;


namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Usuarios Usuarios)
        {
            _context.Usuarios.Add(Usuarios);
            _context.SaveChanges();
            return Ok(Usuarios);
        }
    }
}
