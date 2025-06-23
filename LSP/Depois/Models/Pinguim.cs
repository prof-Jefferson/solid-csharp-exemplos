using System;

namespace LSP.Depois
{
    public class Pinguim : IAve
    {
        public void Bicar()
        {
            Console.WriteLine("O pinguim está bicando.");
        }

        // Nenhum método Voar — ele **não precisa implementar**
    }
}
