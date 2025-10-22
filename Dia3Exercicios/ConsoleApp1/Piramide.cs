using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Piramide
{
    public static void Resposta()
    {
        Console.WriteLine("Digite a altura da pirâmide (1 a 8)");

        int altura = Convert.ToInt32(Console.ReadLine());
        int espaco = altura - 1;

        string vazio = " ";


        for (int i =0; i <= altura ; i++)
        {
         
            for (int j = 0; j <= i; j++)
            {
                if(j == 0)
                {
                    Console.Write(string.Concat((Enumerable.Repeat(vazio, espaco))));
                }
                Console.Write("#");
            }
            espaco--;
            Console.WriteLine();
        }
    }

}