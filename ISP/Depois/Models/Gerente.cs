using System;

namespace ISP.Depois
{
    public class Gerente : ITrabalhador, IGerente, IRepositor
    {
        public void Trabalhar()
        {
            Console.WriteLine("Gerente está trabalhando.");
        }

        public void Gerenciar()
        {
            Console.WriteLine("Gerente está gerenciando a equipe.");
        }

        public void ReporEstoque()
        {
            Console.WriteLine("Gerente está ajudando a repor o estoque.");
        }
    }
}
