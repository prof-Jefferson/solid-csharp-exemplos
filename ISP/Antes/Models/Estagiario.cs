using System;

namespace ISP.Antes
{
    public class Estagiario : IFuncionario
    {
        public void Trabalhar()
        {
            Console.WriteLine("Estagiário está trabalhando.");
        }

        public void Gerenciar()
        {
            throw new NotImplementedException("Estagiário não gerencia.");
        }

        public void ReporEstoque()
        {
            throw new NotImplementedException("Estagiário não repõe estoque.");
        }
    }
}
