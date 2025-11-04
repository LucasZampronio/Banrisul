using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class Ex4
    {

        public static void Rodar()
        {

            Console.WriteLine("Digite um número (1-7)");
            int dia  = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine( "Segunda");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;


                case 3:
                    Console.WriteLine("Segunda");
                    break;

                case 4:
                    Console.WriteLine("Segunda");
                    break;

                case 5:
                    Console.WriteLine("Segunda");
                    break;

                case 6:
                    Console.WriteLine("Segunda");
                    break;

                case 7:
                    Console.WriteLine("Segunda");
                    break;

                default:
                    Console.WriteLine("IncLISO");
                    break;

            }
        }
    }
}
