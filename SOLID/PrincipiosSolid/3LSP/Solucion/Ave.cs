using System.Security.Cryptography.X509Certificates;

namespace LSP.Solucion
{
    abstract class Ave
    {
        //public abstract void Volar();
        public abstract void picotear();
    }

    class aveVoladora : Ave
    {
        public override void picotear()
        { // la logica del picoteo
        }
        public void volar()
        { // la logica del vuelo
        }
    }
    
    class Pinguino : Ave
    {
        public override void picotear()
        { // la logica del picoteo
        }
    }
}