using System;

namespace ISP.Antes
{
    class Program
    {
        static void Main(string[] args)
        {
            IFuncionario gerente = new Gerente();
            IFuncionario estagiario = new Estagiario();

            gerente.Trabalhar();
            estagiario.Trabalhar();

            gerente.Gerenciar();
            estagiario.Gerenciar(); // Vai lançar exceção!
        }
    }
    /*
    Problema:
        A interface IFuncionario obriga todas as classes a implementarem métodos que
        não fazem sentido para todos os perfis. O Estagiario não deveria gerenciar
        nem repor estoque, mas é forçado a implementar esses métodos — o que quebra o
        ISP.
    */
}
