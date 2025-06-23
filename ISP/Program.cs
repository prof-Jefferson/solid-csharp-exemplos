using System;
using System.Collections.Generic;

namespace ISP.Depois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrabalhador> trabalhadores = new List<ITrabalhador>
            {
                new Gerente(),
                new Estagiario()
            };

            foreach (var t in trabalhadores)
            {
                t.Trabalhar();
            }

            Console.WriteLine("\nGerente realizando ações específicas:");

            var gerente = new Gerente();
            gerente.Gerenciar();
            gerente.ReporEstoque();
        }
    }
}
