using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class Ex3
    {
        public static void Rodar()
        {
            Console.WriteLine("Digite uma idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if(0<idade && idade <= 12)
            {
                Console.WriteLine("Classificação Criança");
            }
            if (13 < idade && idade <= 17)
            {
                Console.WriteLine("Classificação Adolescente");
            }
            if (18 < idade && idade <= 59)
            {
                Console.WriteLine("Classificação Adulto");
            }
            if (idade>60)
            {
                Console.WriteLine("Classificação Idoso");
            }
        }
    }
}
