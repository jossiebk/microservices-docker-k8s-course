namespace LSP.Solucion
{
    public class Programador : ITrabajadorEnTurno, IComedor
    {
        public void Trabajar()
        {// desarrollar 
        }
        public void Comer() { }
    }

    public class Guardia : ITrabajadorEnTurno, IDescanso, IComedor
    {
        public void Trabajar()
        { // vigilar 
        }
        public void Dormir() { }
        public void Comer() { }
    }
}