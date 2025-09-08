namespace Microservicio.Prestamos.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public bool Devuelto { get; set; }
    }
}