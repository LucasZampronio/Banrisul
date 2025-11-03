using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    class App
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento foi passado.");
            }
            else
            {
                Console.WriteLine($"Você passou {args.Length} argumento(s):");
                int indice = 0;
                foreach (var arg in args)
                {
                    Console.WriteLine($"[{indice}] {arg}");
                    indice++;
                }
            }
        }
    }
}
