using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex1
{
    public static void Rodar()
    {
        Console.WriteLine("Digite a quantidade minima do produto");
        int quantidademinima = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a quantidade maxima do produto");
        int quantidemaxima = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O estoque medio é {quantidademinima + quantidemaxima /2}");

    }
}
