using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex5
    {

        static void Rodar()
        {
            int idade = 20;
            bool temCNH = true;
            bool temCarro = false;
            double saldo = 150.00;


            bool maior = false;
            bool dirigir = false;
            bool viajar = false;
            bool comprar = false;
            bool critica = false;

            if (idade >= 18)
            {
                maior = true;
            }

            if(idade>=18  && temCNH)
            {
                dirigir = true;
            }

            if(dirigir == true && temCarro)
            {
                viajar= true;
            }

            if (saldo > 100)
            {
                comprar = true; 
            }


            if(idade<18 && !temCNH)
            {
                critica =true;
            }
        }

    }
}
