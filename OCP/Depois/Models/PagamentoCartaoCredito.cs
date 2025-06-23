using System;

namespace OCP.Depois
{
    public class PagamentoCartaoCredito : IPagamento
    {
        public void Processar(double valor)
        {
            Console.WriteLine("Pagamento com cartão de crédito: " + valor);
        }
    }
}
