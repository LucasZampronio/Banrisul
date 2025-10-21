using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sorveteria
{
    // Preço de cada sabor de sorvete
    const double PRECO_CHOCOLATE = 5, PRECO_MORANGO = 6, PRECO_FLOCOS = 4;


    static double calcularTotalPedido(double qtdChocolate, double qtdMorango, double qtdFlocos)
    {
        double totalChocolate = qtdChocolate * PRECO_CHOCOLATE;
        double totalMorango = qtdMorango * PRECO_MORANGO;
        double totalFlocos = qtdFlocos * PRECO_FLOCOS;

        double valorTotalPedido = totalChocolate + totalMorango + totalFlocos;

        return valorTotalPedido;
    }

    static void CalculoDesconto(int quantidadeChocolate, int quantidadeMorango, int quantidadeFlocos)
    {
        int qtdTotal = quantidadeFlocos + quantidadeChocolate + quantidadeMorango;

        double valorTotal = calcularTotalPedido(quantidadeChocolate,quantidadeMorango,quantidadeFlocos);

        if (qtdTotal > 5) // Mais do que 5 sorvetes tem desconto de 10%
        {
            valorTotal -= valorTotal / 10;
        }

        if (valorTotal > 20) // Pedido acima de R$ 20,00 ganha cobertura gratuita
        {
            Console.WriteLine($"Total do pedido: R$ {valorTotal:0.00} e com cobertura gratuita!");
        }
        else
        {
            Console.WriteLine($"Total do pedido: R$ {valorTotal:0.00}.");
        }
    }

    public static void Rodar()
    {
        // Quantidade de sorvetes pedidos pelo cliente
        Console.Write("Quantos sorvetes de chocolate? ");
        int quantidadeChocolate = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de morango? ");
        int quantidadeMorango = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de flocos? ");
        int quantidadeFlocos = int.Parse(Console.ReadLine());

        // Cálculo do total do pedido

        calcularTotalPedido(quantidadeChocolate, quantidadeMorango, quantidadeFlocos);

        CalculoDesconto(quantidadeChocolate,quantidadeMorango,quantidadeFlocos);

    }
}
