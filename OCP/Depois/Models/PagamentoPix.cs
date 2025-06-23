using System;

namespace OCP.Depois
{
    public class PagamentoPix : IPagamento
    {
        public void Processar(double valor)
        {
            Console.WriteLine("Pagamento com Pix: " + valor);
        }
    }
}
