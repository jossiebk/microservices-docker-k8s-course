namespace OCP.Solucion
{
    public class Rectangulo : IFigura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double calculadoraArea()
        {
            return Ancho * Alto;
        }
    }
}