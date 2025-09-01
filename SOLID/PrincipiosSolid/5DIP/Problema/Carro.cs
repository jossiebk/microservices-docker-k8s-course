using DIP.Problema;
namespace DIP.Problema
{
    public class Carro
    {
        private MotorGasolina _motor;

        public Carro()
        {
            // Aqui tenemos acoplamiento Fuerte: La clase Carro crea directamente su dependencia.
            _motor = new MotorGasolina();
        }

        public void Arrancar()
        {
            Console.WriteLine("Encendiendo el carro.");
            _motor.Arrancar(); // ¿Que sucede aqui?¿Que pasa si el motor fuera electrico o hibrido?
        }
    }
}