using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ex4
{
    public static void Rodar()
    {
        for(int i=1; i<10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                Console.WriteLine($"{i}*{j} = {i*j}");
            }
        }

    }


}