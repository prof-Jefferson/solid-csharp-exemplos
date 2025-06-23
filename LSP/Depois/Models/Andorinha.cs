using System;

namespace LSP.Depois
{
    public class Andorinha : IAveVoadora
    {
        public void Bicar()
        {
            Console.WriteLine("A andorinha está bicando.");
        }

        public void Voar()
        {
            Console.WriteLine("A andorinha está voando rapidamente.");
        }
    }
}
