using FirstAPI.Data;
using FirstAPI.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ControlLibros : Controller
    {
        private readonly LibroDb _context;

        public ControlLibros(LibroDb context)
        {
            _context = context;
        }

        //GET: api/libros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibros()
        {
            return await _context.Libros.ToListAsync();
        }

        //GET: api/libros/2
        [HttpGet("{id")]
        public async Task<ActionResult<Libro>> GetLibro(int id)
        {

        }

        //POST: api/libros
        [HttpPost]
        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {


        }

        //PUT: api/libros/2
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibro(int id, Libro libro)
        {

        }

        //DELETE: api/libros/2
        [HttpDelete("{id}")]
        public async Task<ActionResult<Libro>> DeleteLibro(int id)
        {

        }

    }
}
