using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class  Ex2Dia2
{
    static public void Resposta()
    {
         Console.WriteLine("```");
         Console.WriteLine("Digite um numero");
         string Numero1 = System.Console.ReadLine();
         Console.WriteLine("Digite outro numero");
         string Numero2 = System.Console.ReadLine();

         int Numero1inteiro = Convert.ToInt32(Numero1);
         int Numero2inteiro = Convert.ToInt32(Numero2);



        int soma = Numero1inteiro + Numero2inteiro;
        int subtracao = Numero1inteiro - Numero2inteiro;
        double mult = Numero1inteiro * Numero2inteiro;
        double divisao = Numero1inteiro / Numero2inteiro;
        double resto =  Numero1inteiro% Numero2inteiro;

        Console.Write(
            $"Soma:{soma} " +
            $"Subtração: {subtracao}" +
            $"Multiplicação: {mult}" +
            $"Divisão: {divisao}" +
            $"Resto: {resto}"
            );



        Console.WriteLine("```");



    }
}
