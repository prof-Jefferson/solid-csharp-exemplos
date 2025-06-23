using System;

namespace SRP.Depois
{
    public class GravadorDeLog
    {
        public void Gravar(string mensagem)
        {
            Console.WriteLine($"LOG: {mensagem}");
        }
    }
}
