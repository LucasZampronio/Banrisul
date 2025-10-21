using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex3Dia3 { 
    
    public static void Rodar()
    {
        int numero =  new Random().Next(1,11);
        Console.WriteLine("Digite um número entre 1 e 10");
        int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
        int tentativas = 0;

        bool flag = true;
        while (flag) {
            tentativas++;
            if (numero == numeroEscolhido)
            {
                Console.WriteLine($"Parabens! Você acertou o número em {tentativas}.");
                flag = false;

            } else if (numero < numeroEscolhido)
            {
                Console.WriteLine("Muito alto! tente um número menor.");
            }
            else
            {
                Console.WriteLine("Muito baixo! tente um número maior.");

            }
            numeroEscolhido = Convert.ToInt32(Console.ReadLine());

        }
    }
    
    }