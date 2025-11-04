using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex2
    {

        static void Rodar()
        {
            double celsius = 25.0;
            double fahrenheit = (celsius * 9/5) +32;
            double kelvin = celsius + 273;

            Console.WriteLine($"Temperatura em Celsius: {celsius}°C");
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}°F");
            Console.WriteLine($"Temperatura em Kelvin: {kelvin}K");   

        }

    }
}
