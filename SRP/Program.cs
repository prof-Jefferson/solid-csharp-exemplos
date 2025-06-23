using SRP.Depois;

class Program
{
    static void Main(string[] args)
    {
        var usuario = new Usuario("João", "joao@email.com");
        var cadastro = new CadastroDeUsuario();

        cadastro.Cadastrar(usuario);
    }
}
