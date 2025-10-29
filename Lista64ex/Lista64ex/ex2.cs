using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista64ex
{
    class ex2
    {
        public static void Rodar()
        {
            double dolar = 5.34;
            Console.WriteLine("Digite um valor em reais");
            double real = Convert.ToDouble(Console.ReadLine());
            double convertido = real/dolar;
            Console.WriteLine(convertido);
        }
    }
}
