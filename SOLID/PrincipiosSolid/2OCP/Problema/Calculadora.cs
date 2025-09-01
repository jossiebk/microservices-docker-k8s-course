public class Calculdora
{
    public class Rectangulo
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }
    }
    public class Circulo
    {
        public double Radio { get; set; }
    }


    public class Calculadora
    {
        public double calculadoraArea(Object figura)
        {
            if (figura is Rectangulo rectangulo)
            {
                return rectangulo.Ancho * rectangulo.Alto;
            }
            else if (figura is Circulo circulo)
            {
                return Math.PI * Math.Pow(circulo.Radio, 2);
            }
            else
            throw new ArgumentException("Figura no existe");
        }
    }
}