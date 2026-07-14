using System.Globalization;

namespace Exercicios;
class Exercicio6
{
    public void Exec() {
        CultureInfo culturaLocal = CultureInfo.CurrentCulture;
        DateTime dataLocal = DateTime.Now;

        Console.WriteLine($"[Cultura Detectada: {culturaLocal.DisplayName} ({culturaLocal.Name})]");
        Console.WriteLine("=== MENU DE FORMATOS DE DATA/HORA LOCAL ===");
        Console.WriteLine("1 - Formato completo (Dia da semana, data e hora)");
        Console.WriteLine("2 - Apenas data curta padronizada da região");
        Console.WriteLine("3 - Apenas hora (formato local)");
        Console.WriteLine("4 - Data com mês por extenso");
        Console.WriteLine("===========================================");
        Console.Write("Escolha uma opção (1 a 4): ");

        string opcao = Console.ReadLine();
        Console.WriteLine();

        switch (opcao) {
            case "1":
                Console.WriteLine("Formato Completo Local:");
                Console.WriteLine(dataLocal.ToString("F", culturaLocal));
                break;
            case "2":
                Console.WriteLine("Apenas a Data Local:");
                Console.WriteLine(dataLocal.ToString("d", culturaLocal));
                break;
            case "3":
                Console.WriteLine("Apenas a Hora Local:");
                Console.WriteLine(dataLocal.ToString("T", culturaLocal));
                break;
            case "4":
                Console.WriteLine("Data com o Mês por Extenso Local:");
                Console.WriteLine(dataLocal.ToString("D", culturaLocal));
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida!");
                Console.ResetColor();
                break;
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}