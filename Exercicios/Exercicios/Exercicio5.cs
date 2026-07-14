using System.Text.RegularExpressions;

namespace Exercicios;
class Exercicio5 {
    public void Exec() {
        Console.Write("Digite o número da placa do veículo: ");
        string placa = Console.ReadLine().Trim();
        bool placaValida = validarPlaca(placa);

        if (placaValida)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Placa válida!");
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Placa inválida! Certifique-se de usar 3 letras seguidas de 4 números.");
        }

        Console.ResetColor();
    }

    private bool validarPlaca(string placa) {
        string padrao = @"^[a-zA-Z]{3}[0-9]{4}";

        if (!string.IsNullOrEmpty(placa) && Regex.IsMatch(placa, padrao)) {
            return true;
        }

        return false;
    }
}

