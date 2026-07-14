namespace Exercicios;
using System;
using System.Globalization;


class Exercicio3
{
    public void Exec()
    {
        double numero1 = LerNumero("Digite o primeiro número: ");
        double numero2 = LerNumero("Digite o segundo número: ");

        double soma = numero1 + numero2;

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"A soma de {numero1} + {numero2} é: {soma}");
    }

    private double LerNumero(string mensagem)
    {
        double numeroValido;

        while (true)
        {
            Console.Write(mensagem);
            string input = Console.ReadLine();

            string inputTratado = input.Replace(",", ".");

            if (double.TryParse(inputTratado, NumberStyles.Any, CultureInfo.InvariantCulture, out numeroValido))
            {
                return numeroValido;
            }

            Console.WriteLine("⚠️ Entrada inválida! Por favor, digite apenas números.");
        }
    }
}

