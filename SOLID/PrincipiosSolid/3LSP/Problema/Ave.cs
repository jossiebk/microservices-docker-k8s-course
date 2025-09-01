namespace LSP.Problema
{
    class Ave {
        public virtual void Volar() { }
    }

    class Pinguino : Ave {
        public override void Volar() {
            throw new NotImplementedException(); 
        }
    }
}