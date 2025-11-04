using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex6
    {

        static void Rodar()
        {
            byte numeroPequeno = 50;
            int numeroMedio =  Convert.ToInt32(numeroPequeno);
            long numeroGrande = Convert.ToInt64(numeroPequeno);
            double numeroDecimal = Convert.ToDouble(numeroMedio);

            double pi = 3.14159;
            int piInteiro =Convert.ToInt32(pi);
            int piArredondado = Convert.ToInt32(pi);

            string texto1 = "42";
            string texto2 = "abc";
            

            int numero1 = int.TryParse(texto1, out numero1);


            bool sucesso = bool.TryParse(texto2, out sucesso);


            int idade = 25;
            string idadeTexto = Convert.ToString(idade);
            string idadeFormatada = Convert.ToString(idade);

            Console.WriteLine(numeroPequeno);
            Console.WriteLine(numeroMedio);
            Console.WriteLine(numeroGrande);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(piInteiro);
            Console.WriteLine(piArredondado);
            Console.WriteLine(idadeTexto);


        }
    }
}
