using Microservicio.Prestamos.Models;
using Microservicio.Prestamos.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Microservicio.Prestamos.Controllers
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
    public class PrestamosController : ControllerBase
    {
        private readonly PrestamosService _service;

        public PrestamosController(PrestamosService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Prestamo>> Get()
        {
            var prestamos = _service.ObtenerTodos();
            return Ok(prestamos);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Prestamo> Get(int id)
        {
            var prestamo = _service.ObtenerPorId(id);
            if (prestamo == null) return NotFound(new { mensaje = "No se encontro el registro de prestamo que buscas." });
            return Ok(prestamo);
        }
    }
}