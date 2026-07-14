namespace Exercicios;
class Exercicio1
{
    public void Exec()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite uma mensagem: ");
        string mensagem = Console.ReadLine();

        Console.WriteLine($"Olá {nome}! {mensagem}");
    }
}