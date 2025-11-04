using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp
{
    class Ex4
    {

        static void Rodar()
        {
            string nomeProduto1 = "Mouse Gamer";
            decimal precoProduto1 = 89.90m;
            int quantidadeProduto1 = 2;
            decimal sub1 = precoProduto1 * quantidadeProduto1;
            decimal des = 0m;

            string nomeProduto2 = "Teclado mecanico";
            decimal precoProduto2 = 5.3m;
            int quantidadeProduto2 = 34;
            decimal sub2 = precoProduto2 * quantidadeProduto2;

            string nomeProduto3 = "Mousepad";
            decimal precoProduto3 = 102.30m;
            int quantidadeProduto3 = 1;
            decimal sub3 = precoProduto3 * quantidadeProduto3;

            decimal sub = sub1 +sub2 +sub3;


            if (sub > 200)
            {
                 des = sub * 0.9m;
            }

            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("════════════════════RECIBO═════════════════════");
            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("Item               QTD     Preço       Subtotal");
            Console.WriteLine("───────────────────────────────────────────────");
            Console.WriteLine($"{nomeProduto1}    {quantidadeProduto1}  {precoProduto1} {sub1} ");
            Console.WriteLine($"{nomeProduto2}    {quantidadeProduto2}  {precoProduto2} {sub2} ");
            Console.WriteLine($"{nomeProduto3}    {quantidadeProduto3}  {precoProduto3} {sub3} ");
            Console.WriteLine("───────────────────────────────────────────────");
            Console.WriteLine($"                               Subtotal: {sub}");
            Console.WriteLine($"                               Desconto: {des}");
            Console.WriteLine("───────────────────────────────────────────────");
            Console.WriteLine($"                      Total a Pagar: {sub-des}");
            Console.WriteLine("═══════════════════════════════════════════════");







        }

    }
}
