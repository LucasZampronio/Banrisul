using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex3Dia2
{
    public static void Resposta()
    {
        Console.WriteLine("Digite um numero inteiro de tres digitos:");
        string numero = Console.ReadLine();
        int numeroInt = Convert.ToInt32(numero);

        int unidade = numeroInt % 10;
        int dezena = numeroInt / 10 % 10;
        int centena = numeroInt / 100 % 10;

        Console.WriteLine($"Unidade:{unidade}");
        Console.WriteLine($"Dezena:{dezena}");
        Console.WriteLine($"Centena:{centena}");
        int soma = unidade + dezena + centena;

        Console.WriteLine($"Soma dos digitos: {soma}");




    }



};