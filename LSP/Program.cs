using System;

namespace LSP.Antes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave ave1 = new Andorinha();
            Ave ave2 = new Pinguim();

            ave1.Voar(); // OK
            ave2.Voar(); // Vai lançar exceção!
        }
    }
}
