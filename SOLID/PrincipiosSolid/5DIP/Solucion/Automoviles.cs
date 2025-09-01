namespace DIP.Solucion
{
    public interface IMotor
    {
        void Arrancar();
    }

    public class MotorGasolina : IMotor
    {
        public void Arrancar()
        {
            Console.WriteLine("Motor de gasolina arrancando...");
        }
    }

    public class MotorElectrico : IMotor
    {
        public void Arrancar()
        {
            Console.WriteLine("Motor eléctrico arrancando...");
        }
    }

    public class Carro
    {
        private IMotor _motor;
        
        public Carro(IMotor motor)
        {
            // Aquí la clase Carro recibe su dependencia a través del constructor.
            _motor = motor;
        }
    }
}