using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex10Dia2
{
    public static void Resposta()
    {
        Console.WriteLine("Digite um ano e verifique se ele é bissexto");
        string ano = Console.ReadLine();
        int anointeiro = Convert.ToInt32(ano);
        bool resposta = anointeiro % 400 == 0 ||(anointeiro % 4 == 0 && anointeiro % 100 !=0);
        Console.WriteLine(resposta);

    }
}

