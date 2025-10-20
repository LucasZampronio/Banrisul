using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex8Dia2
{
    public static void Resposta()
    {
        Console.WriteLine("Digite um número");
        string numero = Console.ReadLine();
        int numeroreal = Convert.ToInt16(numero);
        bool resposta = (numeroreal % 2 == 0) && numeroreal>0;
        Console.WriteLine(resposta);
    }
}
