using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex3
{
    public static void Rodar()
    {
        Console.WriteLine("Digite um número inteiro");
        int numero = Convert.ToInt32(Console.ReadLine());
        int milhao = numero / 1000000;
        int centenamilhar = numero % 1000000 / 100000;
        int dezenamilhar = numero % 100000 / 10000;
        int milhar = numero %  10000 / 1000;
        int centena = numero % 1000 / 100;
        int dezena = numero % 100 / 10;
        int unidade  = numero % 100 % 10;
        int soma = milhao + centenamilhar + dezenamilhar + milhar + centena + dezena + unidade;

        Console.WriteLine(soma);


    }
}