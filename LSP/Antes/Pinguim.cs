namespace LSP.Antes
{
    public class Pinguim : Ave
    {
        public override void Voar()
        {
            throw new NotSupportedException("Pinguins não voam!");
        }
    }
}
