using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class Ex8
    {
        public static void Rodar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);  // 1 a 100
            int tentativas = 0;
            int palpite;

            Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
            Console.WriteLine("Adivinhe o número entre 1 e 100");

            while (true)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if(numero == numeroSecreto)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas!");
                }
                Console.WriteLine("Tente novamente");
            }
        }

    }
}
