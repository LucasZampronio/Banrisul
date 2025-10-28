using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex5
{
    public static void Rodar()
    {
        Console.WriteLine("Digite um número inteiro");
        int numero = Convert.ToInt32(Console.ReadLine());
        List<int> divisores = new List<int>();
        for (int i = 0; i < numero; i++)
        {
            foreach(var divisor in divisores)
            {
                if(numero % divisor == 0)
                {
                    divisores.Add(divisor);
                }
            }
        }

        if (divisores.Count > 2)
        {
            Console.WriteLine($"Os números que dividem {numero} são: ");
            foreach(var divisor in divisores)
            {
                Console.WriteLine(divisor);
            }
        }
        else
        {
            Console.WriteLine($"{numero} é um número primo");
        }
    }
}