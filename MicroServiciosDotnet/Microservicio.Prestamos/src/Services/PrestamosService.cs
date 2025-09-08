using Microservicio.Prestamos.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Microservicio.Prestamos.Services
{
    public class PrestamosService
    {
        private readonly string _filePath;
        private readonly List<Prestamo> _prestamos;

        public PrestamosService(IWebHostEnvironment env)
        {
            var contentRoot = env.ContentRootPath ?? AppContext.BaseDirectory;
            _filePath = Path.Combine(contentRoot, "src", "Data", "Prestamos.json");

            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                _prestamos = JsonSerializer.Deserialize<List<Prestamo>>(json, options) ?? new List<Prestamo>();
            }
            else
            {
                _prestamos = new List<Prestamo>();
            }
        }

        public IEnumerable<Prestamo> ObtenerTodos()
        {
            return _prestamos;
        }

        public Prestamo? ObtenerPorId(int id)
        {
            return _prestamos.FirstOrDefault(p => p.Id == id);
        }
    }
}