using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista64ex
{
    class ex23
    {
        public static void Rodar()
        {
            while (true)
            {
                string opcao =  Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        adicao();
                        break;
                    case "2":
                        subtracao();
                        break;
                    case "3":
                        multiplicacao();
                        break;
                    case "4":
                        divisao();
                        break;
                    case "5":
                        sair();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida");
                }

            }
        }

        public static void Menu()
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("============");
        }

        public static void adicao()
        {
            Console.WriteLine("Digite o primeiro número da adição");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número da adição");
            double numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A soma dos dois números é {numero2+numero1}");
        }
    }
}
