using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    continuar = false;
                    Console.WriteLine("Até breve!");
                    continue;
                }

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    continue;
                }

                double a = LerNumero("Primeiro número: ");
                double b = LerNumero("Segundo número: ");

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"\nResultado: {a} + {b} = {a + b}\n");
                        break;
                    case "2":
                        Console.WriteLine($"\nResultado: {a} - {b} = {a - b}\n");
                        break;
                    case "3":
                        Console.WriteLine($"\nResultado: {a} x {b} = {a * b}\n");
                        break;
                    case "4":
                        if (b == 0)
                            Console.WriteLine("\nErro: não é possível dividir por zero.\n");
                        else
                            Console.WriteLine($"\nResultado: {a} / {b} = {a / b}\n");
                        break;
                    case "5":
                        Console.WriteLine($"\nResultado: {a} ^ {b} = {Math.Pow(a, b)}\n");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
        }

        static double LerNumero(string mensagem)
        {
            double numero;
            Console.Write(mensagem);

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Valor inválido. Introduza um número: ");
            }

            return numero;
        }
    }
}