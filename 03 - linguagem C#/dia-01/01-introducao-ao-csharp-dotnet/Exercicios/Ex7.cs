using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex7
    {

        static void Rodar()
        {
            double extra = 0;
            double horasSegunda = 8.0;
            double horasTerca = 7.5;
            double horasQuarta = 8.0;
            double horasQuinta = 9.0;
            double horasSexta = 6.0;

            if((horasSexta + horasSegunda + horasTerca + horasQuinta + horasQuarta) > 40)
            {
               extra = horasSexta + horasSegunda + horasTerca + horasQuinta + horasQuarta - 40;
            }

            Console.WriteLine("═══════════════════════════════════");
            Console.WriteLine("════════RELATORIO SEMANAL══════════");
            Console.WriteLine("═══════════════════════════════════");
            Console.WriteLine($"Segunda-Feira:  {horasSegunda}horas");
            Console.WriteLine($"Terça-Feira:     {horasTerca} horas");
            Console.WriteLine($"Quarta-Feira:   {horasQuarta} horas");
            Console.WriteLine($"Quinta-Feira:  {horasQuinta}  horas");
            Console.WriteLine($"Sexta-Feira:    {horasSexta}  horas");
            Console.WriteLine("───────────────────────────────────");
            Console.WriteLine($"Total: {horasSexta+horasSegunda+horasTerca+horasQuinta+horasQuarta} Horas");
            Console.WriteLine($"Media  diaria: {(horasSexta + horasSegunda + horasTerca + horasQuinta + horasQuarta)/5} Horas");
            Console.WriteLine("───────────────────────────────────");
            Console.WriteLine($"Horas normais: {horasSexta + horasSegunda + horasTerca + horasQuinta + horasQuarta} @ R$ 50/h");
            Console.WriteLine($"Horas extras: {extra} @ R$ 75/h");
            Console.WriteLine("───────────────────────────────────");
            Console.WriteLine($"Total a Receber: {extra + horasSexta + horasSegunda + horasTerca + horasQuinta + horasQuarta }");
            Console.WriteLine("═══════════════════════════════════");











        }
    }
}
