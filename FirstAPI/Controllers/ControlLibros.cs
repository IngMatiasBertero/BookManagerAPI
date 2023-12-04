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
        [HttpGet("{id}")]
        public async Task<ActionResult<Libro>> GetLibro(int id)
        {
            var libro = await _context.Libros.FindAsync(id);

            if (libro == null)
            {
                return NotFound();
            }

            return libro;
        }

        //POST: api/libros
        [HttpPost]
        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {
            _context.Libros.Add(libro);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = libro.Id }, libro);

        }

        //PUT: api/libros/2
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibro(int id, Libro libro)
        {

            if (id != libro.Id)
            {
                return BadRequest();

            }

            var libroInDb = await _context.Libros.FindAsync(id);

            if (libroInDb == null)
            {
                return NotFound();
            }

            libroInDb.Titulo = libro.Titulo;
            libroInDb.Autor = libro.Autor;
            libroInDb.Habilitado = libro.Habilitado;

            await _context.SaveChangesAsync();

            return NoContent();


        }   

        //DELETE: api/libros/2
        [HttpDelete("{id}")]
        public async Task<ActionResult<Libro>> DeleteLibro(int id)
        {

            var libro = await _context.Libros.FindAsync(id);

            if (libro == null)
            {
                return NotFound();
            }


            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();

            return libro;


        }

    }
}
