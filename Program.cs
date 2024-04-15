using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            switch (nome)
            {
                case "João":
                    Console.WriteLine("Olá João!");
                    break;

                case "Marcio":
                    Console.WriteLine("Olá Marcio!");
                    break;

                case "Denis":
                    Console.WriteLine("Olá Denis!");
                    break;

                default:
                    Console.WriteLine($"Olá {nome}!");
                    break;

            }

        }
    }
}
