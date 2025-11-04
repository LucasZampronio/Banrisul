using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class E2x
    {

        public static void Rodar()
        {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
