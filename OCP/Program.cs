namespace OCP.Antes;

class Program
{
    static void Main(string[] args)
    {
            var processador = new ProcessadorDePagamento();
            processador.Processar("Pix", 150.0);
    }
}
