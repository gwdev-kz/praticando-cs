namespace Exercicios;

class Exercicio4
{
    public void Exec() {
        Console.Write("Digite qualquer palavra: ");
        string palavra = Console.ReadLine();

        Console.WriteLine($"Quantidade de caracteres: {palavra.Length}");
    }
}