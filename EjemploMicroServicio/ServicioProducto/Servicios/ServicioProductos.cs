using ProductService.Models;
using ProductService.Repositorios;

namespace ProductService.Servicios
{
    public class ServicioProductos
    {
        private readonly RepositorioProductos _repositorio;

        public ServicioProductos(RepositorioProductos repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Producto> ObtenerProductos() => _repositorio.ObtenerTodos();

        public Producto? ObtenerProducto(int id) => _repositorio.ObtenerPorId(id);

        public Producto CrearProducto(Producto producto) => _repositorio.Crear(producto);


    }
}
