using FirstAPI.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ControlLibros
    {

        public ControlLibros()
        {

        }

        //GET: api/libros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibros()
        {

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
