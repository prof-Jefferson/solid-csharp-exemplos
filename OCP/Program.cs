using OCP.Depois;

class Program
{
    static void Main(string[] args)
    {
        var processador = new ProcessadorDePagamento();

        IPagamento pagamentoPix = new PagamentoPix();
        IPagamento pagamentoBoleto = new PagamentoBoleto();
        IPagamento pagamentoCartao = new PagamentoCartaoCredito();

        processador.Processar(pagamentoPix, 150.0);
        processador.Processar(pagamentoBoleto, 200.0);
        processador.Processar(pagamentoCartao, 300.0);
    }
}
