using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
  class Ex1
  {
        public static void Rodar()
        {
                Console.WriteLine("═══════════════════════════════════════");
                Console.WriteLine("      EXPRESSÕES LAMBDA BÁSICAS        ");
                Console.WriteLine("═══════════════════════════════════════");


                Func<int, bool> ehPar = numero => numero % 2 == 0;
                Func<int, double> quadrado = numero => numero * numero;
                Func<string, string> converterString = texto => texto.ToUpper();
                int numeroTeste = 10;
                string original = "teste";
                Console.WriteLine(ehPar(numeroTeste));
                Console.WriteLine(quadrado(numeroTeste));
                Console.WriteLine(converterString(original));

        }

    }

}
