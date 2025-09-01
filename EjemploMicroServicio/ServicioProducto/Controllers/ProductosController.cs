using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Servicios;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ServicioProductos _servicio;

        public ProductosController(ServicioProductos servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> ObtenerTodos()
        {
            return Ok(_servicio.ObtenerProductos());
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> ObtenerPorId(int id)
        {
            var producto = _servicio.ObtenerProducto(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> Crear(Producto producto)
        {
            var nuevo = _servicio.CrearProducto(producto);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevo.Id }, nuevo);
        }

    }
}
