using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate
{
    using System;
    using System.Collections.Generic;

    // ----------------------------
    // Classe que representa um registro de extrato
    // ----------------------------
    public class Movimentacao
    {
        public string CpfPessoa;        // CPF da pessoa (para referência)
        public DateTime DataInclusao;   // Data da transação
        public double ValorTransacao;

        // Construtor
        public Movimentacao(string cpf, DateTime data, double valor)
        {
            CpfPessoa = cpf;
            DataInclusao = data;
            ValorTransacao = valor;
        }
    }

    // ----------------------------
    // Classe que representa o extrato
    // ----------------------------
    public class ExtratoBancario
    {
        public string CpfPessoa;       // CPF da pessoa
        public string NomePessoa;      // Nome da pessoa
        public double ValorInicial;    // Saldo inicial
        protected List<Movimentacao> Movimentacoes;

        // Construtor
        public ExtratoBancario(string cpf, string nome, double valorInicial, List<Movimentacao> movimentacoes)
        {
            CpfPessoa = cpf;
            NomePessoa = nome;
            ValorInicial = valorInicial;
            Movimentacoes = movimentacoes ?? new List<Movimentacao>();
        }

        // ----------------------------
        // Método para calcular saldo final
        // ----------------------------
        public double CalcularSaldo()
        {
            double saldoFinal = ValorInicial;
            for (int indice = 0; indice < Movimentacoes.Count; indice++)
            {
                saldoFinal += Movimentacoes[indice].ValorTransacao;

            }
            // TODO: Implementar cálculo do saldo final
            return 0;
        }

        // ----------------------------
        // Método para obter saldos diários
        // ----------------------------
        public List<string> ObterSaldosDiarios()

        {
            Dictionary<DateTime,double> ValoresPorDia = new Dictionary<DateTime,double>();
            double saldo = ValorInicial;
            for(int indice = 0; indice < Movimentacoes.Count; indice++)
            {
                DateTime dia = Movimentacoes[indice].DataInclusao.Date;

                if (!ValoresPorDia.ContainsKey(dia))
                {

                   ValoresPorDia[dia] = saldo;
                
                    }

                ValoresPorDia[dia] += Movimentacoes[indice].ValorTransacao;
                saldo += Movimentacoes[indice].ValorTransacao;
            }

            List<string> extratoPorDia =  new List<string>();
            foreach(DateTime dia in ValoresPorDia.Keys)
            {
               string texto = $"Valor no dia {dia.Date} é {ValoresPorDia[dia.Date]}";
               extratoPorDia.Add(texto);

            }



                // TODO: Implementar cálculo de saldo diário
                return extratoPorDia;
        }
    }

    // ----------------------------
    // Classe App com método Main
    // ----------------------------
    public class App
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Sistema de Extrato Bancário ===\n");
            string cpfgabriel ="12345689";

            // TODO: Instanciar ExtratoBancario e Movimentacoes conforme o exercício
            // Exemplo de comentário:


            Movimentacao mov1 = new Movimentacao(cpfgabriel,DateTime.Now, 19.2);
            Movimentacao mov2 = new Movimentacao(cpfgabriel, DateTime.Now.AddDays(2), 10.2);
            Movimentacao mov4 = new Movimentacao(cpfgabriel, DateTime.Now.AddDays(3), -19.12);
            Movimentacao mov5 = new Movimentacao(cpfgabriel, DateTime.Now.AddDays(4), 19.2);
            List<Movimentacao> movimentacoes = new List<Movimentacao> (){};
            movimentacoes.Add(mov1);
            movimentacoes.Add(mov2);
            movimentacoes.Add(mov4);
            movimentacoes.Add(mov5);
            ExtratoBancario extratoGabriel = new ExtratoBancario(cpfgabriel,"Gabriel",50,movimentacoes);
            // var extrato = new ExtratoBancario("CPF", "Nome", 1000, movimentacoes);

            // TODO: Chamar CalcularSaldo e ObterSaldosDiarios, imprimir resultados
            Console.WriteLine("\nFim do programa. Implemente as funcionalidades solicitadas no exercício.");
        }
    }

}
