namespace SRP.AntesSRP;

public class GerenciadorDeUsuario
{
    public void CadastrarUsuario(string nome, string email)
    {
        // Cadastro
        Console.WriteLine("Usuário cadastrado com sucesso!");

        // Envio de email
        Console.WriteLine("Email de boas-vindas enviado para " + email);

        // Log
        Console.WriteLine("LOG: Usuário criado - " + nome);
    }
}