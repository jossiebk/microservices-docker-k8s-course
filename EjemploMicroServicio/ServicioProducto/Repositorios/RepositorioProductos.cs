using ProductService.Models;

namespace ProductService.Repositorios
{
    public class RepositorioProductos
    {
        private readonly List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200 },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 25 },
            new Producto { Id = 3, Nombre = "Bocina", Precio = 555 },
            new Producto { Id = 4, Nombre = "Monitor", Precio = 777 }
        };

        public IEnumerable<Producto> ObtenerTodos() => _productos;

        public Producto? ObtenerPorId(int id) =>
            _productos.FirstOrDefault(p => p.Id == id);

        public Producto Crear(Producto producto)
        {
            producto.Id = _productos.Max(p => p.Id) + 1;
            _productos.Add(producto);
            return producto;
        }

        public bool Actualizar(int id, Producto actualizado)
        {
            var producto = ObtenerPorId(id);
            if (producto == null) return false;

            producto.Nombre = actualizado.Nombre;
            producto.Precio = actualizado.Precio;
            return true;
        }
    }
}
