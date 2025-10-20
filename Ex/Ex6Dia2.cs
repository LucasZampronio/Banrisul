using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex6Dia2
{
    public static void Resposta()
    {
        Console.WriteLine("Digite sua senha");
        string senha = Console.ReadLine();
        Console.WriteLine("Confirme sua senha");
        string senhaconfirma = Console.ReadLine();
        Console.WriteLine($"Senha valida?:");
        Console.WriteLine(senha == senhaconfirma);


    }


}
