using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex9Dia2
{
    public static void Resposta()
    {
        Console.WriteLine("Digite a altura da criança");
        string altura = Console.ReadLine();
        double alturaconvertia = Convert.ToDouble(altura);
        bool acompanhante = false;
        bool liberado = alturaconvertia > 1.20 || acompanhante;
        Console.WriteLine(liberado);



    }
}