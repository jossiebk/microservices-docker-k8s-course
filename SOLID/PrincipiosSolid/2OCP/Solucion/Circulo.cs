namespace OCP.Solucion
{
    public class Circulo : IFigura
    {
        public double Radio { get; set; }
        public double calculadoraArea() => Math.PI * Radio * Radio;
    }
}