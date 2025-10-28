using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex1
{
    public static void Rodar() {


        Console.WriteLine("Digite um número A");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro número B");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if(numero1> numero2)
        {
            double soma = 0;
            for(double i=numero2; i<numero1; i++)
            {
                if(i == numero2)
                {
                    continue;
                }
                  soma +=i;
            };
            Console.WriteLine($"A soma dos números entre A e B é {soma}");
        }

        if (numero2 > numero1)
        {
            double soma = 0;
            for (double i = numero1; i < numero2; i++)
            {
                if (i == numero1)
                {
                    continue;
                }
                soma += i;
            };
            Console.WriteLine($"A soma dos números entre A e B é {soma}");
  
        }
    }

}

