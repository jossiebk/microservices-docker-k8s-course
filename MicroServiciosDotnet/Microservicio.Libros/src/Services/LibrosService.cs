using Microservicio.Libros.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Microservicio.Libros.Services
{
    public class LibrosService
    {
        private readonly string _filePath;
        private readonly List<Libro> _libros;

        public LibrosService(IWebHostEnvironment env)
        {
            var contentRoot = env.ContentRootPath ?? AppContext.BaseDirectory;
            _filePath = Path.Combine(contentRoot, "src", "Data", "Libros.json");

            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                _libros = JsonSerializer.Deserialize<List<Libro>>(json, options) ?? new List<Libro>();
            }
            else
            {
                _libros = new List<Libro>();
            }
        }

        public IEnumerable<Libro> ObtenerTodos()
        {
            return _libros;
        }

        public Libro? ObtenerPorId(int id)
        {
            return _libros.FirstOrDefault(x => x.Id == id);
        }

        public Libro? Agregar(Libro nuevoLibro)
        {
            nuevoLibro.Id = _libros.Any() ? _libros.Max(l => l.Id) + 1 : 1;
            _libros.Add(nuevoLibro);
            return nuevoLibro;
        }
        
        public bool Eliminar(int id)
        {
            var libro = ObtenerPorId(id);
            if (libro != null)
            {
                _libros.Remove(libro);
                return true;
            }
            return false;
        }

    }
}