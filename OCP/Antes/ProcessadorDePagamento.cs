using System;

namespace OCP.Antes;

public class ProcessadorDePagamento
{
    public void Processar(string metodo, double valor)
    {
        if (metodo == "CartaoCredito")
        {
            Console.WriteLine("Processando pagamento com cartão de crédito: " + valor);
        }
        else if (metodo == "Boleto")
        {
            Console.WriteLine("Processando pagamento com boleto: " + valor);
        }
        else if (metodo == "Pix")
        {
            Console.WriteLine("Processando pagamento com Pix: " + valor);
        }
        else
        {
            Console.WriteLine("Método de pagamento não suportado.");
        }
    }
}

