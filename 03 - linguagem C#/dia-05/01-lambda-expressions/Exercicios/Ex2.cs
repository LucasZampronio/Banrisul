using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Ex2
    {
        public static void Rodar()
        {

            List<int> lista = new List<int> { 30,14 ,1, 2, 3, 4,123, 5, 6, 7, 8, 9, 10 };


            var pares = lista.Where(x => x % 2==0).ToList();
            var ordenação = lista.OrderBy(x=> x).ToList();
            var somaNumeroPar = lista.Where(x=> x>10).ToList().Sum();
                
            Console.WriteLine(somaNumeroPar);
        }

    }
}
