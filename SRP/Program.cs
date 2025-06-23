using System;

namespace SRP.AntesSRP;

class Program
{
    static void Main(string[] args)
    {
        var gerenciador = new GerenciadorDeUsuario();
        gerenciador.CadastrarUsuario("João", "joao@email.com");
    }
}

