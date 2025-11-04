using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex3
    {

        public static void Rodar()
        {
            string frase = "Aprendendo C# é Muito Legal!";
            Console.WriteLine(frase);
            Console.WriteLine($"Tamanho: {frase.Length} caracteres");

            Console.WriteLine($"Maiúsculas: '{frase.ToUpper()}'");
            Console.WriteLine($"Minúsculas: '{frase.ToLower()}'");
            Console.WriteLine($"Sem espaços extras: '{frase.ToUpper()}'");
            Console.WriteLine($"Substituída: '{frase.Replace("Legal","Divertido")}'");
            Console.WriteLine($"Contem 'C#' :{frase.Contains("C#")} ");
            Console.WriteLine($"Substring Extraida: {frase.Substring(0,12)}");

        }

    }
}
