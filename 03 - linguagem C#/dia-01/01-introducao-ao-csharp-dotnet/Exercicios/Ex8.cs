using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex8
    {

        static void Rodar()
        {

            bool validaidade = false;
            bool validaaltura = false;
            bool validapeso = false;
            bool validanome = false;
            bool validaemail = false;

            int idade = 25;
            double altura = 1.75;
            double peso = 70.5;
            string nomeStr = " ";
            string emailStr = "joao@email";


            if(0<idade && idade < 150)
            {
                validaidade = true;
            }


            if (0.5 < altura && altura < 3)
            {
                validaaltura = true;
            }

            if (2 < peso && peso < 500)
            {
                validapeso = true;
            }

            if(emailStr != " " && emailStr.Contains("@") && emailStr.Contains("."))
            {
                validaemail = true;
            }

            if (nomeStr != " ")
            {
                validanome = true;
            }

            Console.WriteLine("Validação de dados");
            Console.WriteLine("═════════════════════════════════════════════");
            Console.WriteLine($"Idade {idade} - {validaidade}");
            Console.WriteLine($"Idade {altura} - {validaaltura}");
            Console.WriteLine($"Idade {peso} - {validapeso}");
            Console.WriteLine($"Idade {nomeStr} - {validanome}");
            Console.WriteLine($"Idade {emailStr} - {validaemail}");
            Console.WriteLine("═════════════════════════════════════════════");








        }
    }
}
