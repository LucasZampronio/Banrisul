using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ex5Dia2 {
    
    public static void Resposta()
    {
        Console.WriteLine("Digite um número");
        string primeiroNumero = Console.ReadLine();
        int num1 = Convert.ToInt32(primeiroNumero);
        Console.WriteLine("Digite outro número");
        string segundoNumero = Console.ReadLine();
        int num2 = Convert.ToInt32(segundoNumero);

              Console.WriteLine(num1 > num2);
              Console.WriteLine(num1 < num2);
              Console.WriteLine(num1 == num2);
              Console.WriteLine(num1 != num2);
              Console.WriteLine(num1 >= num2);
              Console.WriteLine(num1 <= num2);

    }
    
    
    
    }

