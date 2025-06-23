using System;

namespace SRP.Depois
{
    public class CadastroDeUsuario
    {
        private readonly EnviadorDeEmail _enviador;
        private readonly GravadorDeLog _log;

        public CadastroDeUsuario()
        {
            _enviador = new EnviadorDeEmail();
            _log = new GravadorDeLog();
        }

        public void Cadastrar(Usuario usuario)
        {
            Console.WriteLine("Usuário cadastrado com sucesso!");

            _enviador.EnviarBoasVindas(usuario.Email);
            _log.Gravar($"Usuário criado: {usuario.Nome}");
        }
    }
}
