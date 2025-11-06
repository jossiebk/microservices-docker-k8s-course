using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microservicio.Libros.Models;
using Microservicio.Libros.Services;

namespace Microservicio.Libros.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("OK");
    }
    
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private readonly LibrosService _service;

        public LibrosController(LibrosService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Libro>> Get()
        {
            var libros = _service.ObtenerTodos();
            if (libros == null) return NotFound(new { mensaje = "No hay libros en el sistema )" });
            return Ok(libros);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Libro> Get(int id)
        {
            var libro = _service.ObtenerPorId(id);
            if (libro == null) return NotFound(new { mensaje = "No se encontro el libro :( )" });
            return Ok(libro);
        }

        [HttpPost]
        public ActionResult<Libro> Post([FromBody] Libro nuevoLibro)
        {
            if (nuevoLibro == null || string.IsNullOrWhiteSpace(nuevoLibro.Titulo) || string.IsNullOrWhiteSpace(nuevoLibro.Autor))
            {
                return BadRequest(new { mensaje = "El libro debe tener un título y un autor válidos." });
            }

            var libroCreado = _service.Agregar(nuevoLibro);
            return CreatedAtAction(nameof(Get), new { id = libroCreado?.Id }, libroCreado);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var eliminado = _service.Eliminar(id);
            if (!eliminado) return NotFound(new { mensaje = $"No se encontró el libro con Id={id}" });
            return NoContent();
        }
    }
}