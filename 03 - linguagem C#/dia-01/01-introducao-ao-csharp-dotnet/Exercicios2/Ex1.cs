using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class Ex1
    {

        public static void Rodar()
        {
            int opcao;

            do
            { 
                Console.WriteLine("===== CALCULADORA =====");
                Console.WriteLine("1. Somar");
                Console.WriteLine("2. Subtrair");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtrair();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);




        }


        public static void Somar()
        {
            Console.WriteLine("Digite o primeiro número");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma dos números é : {numero1+numero2}");
        }



        public static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro número");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A subtração dos números é : {numero1 - numero2}");
        }


        public static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro número");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A multiplicação dos números é : {numero1 * numero2}");
        }

        public static void Dividir()
        {
            Console.WriteLine("Digite o primeiro número");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero2 == 0)
            {
                Console.WriteLine("Não é possivel dividir com zero");
                return;
            }

            if (numero1 == 0)
            {
                Console.WriteLine("Não é possivel dividir com zero");
                return;
            }



            Console.WriteLine($"A multiplicação dos números é : {numero1 / numero2}");
        }

    }
}
