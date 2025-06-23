namespace OCP.Depois
{
    public class ProcessadorDePagamento
    {
        public void Processar(IPagamento pagamento, double valor)
        {
            pagamento.Processar(valor);
        }
    }
}
