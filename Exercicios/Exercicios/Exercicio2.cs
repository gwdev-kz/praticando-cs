namespace Exercicios
{
    class Exercicio2
    {
        public void Exec()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"{nome} {sobrenome}");
        }
    }
}
