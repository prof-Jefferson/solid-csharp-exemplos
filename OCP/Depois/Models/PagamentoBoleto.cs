using System;

namespace OCP.Depois
{
    public class PagamentoBoleto : IPagamento
    {
        public void Processar(double valor)
        {
            Console.WriteLine("Pagamento com boleto: " + valor);
        }
    }
}
