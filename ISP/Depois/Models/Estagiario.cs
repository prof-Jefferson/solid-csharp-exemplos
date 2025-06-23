using System;

namespace ISP.Depois
{
    public class Estagiario : ITrabalhador
    {
        public void Trabalhar()
        {
            Console.WriteLine("Estagiário está trabalhando.");
        }
    }
}
