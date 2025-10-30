using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao
{
    class Sistemaentregas
    {
        public static void Rodar()
        {
            EntregaEconomica entrega1 = new EntregaEconomica(1010,50,"Xique-Xique","São Paulo");
            EntregaExpressa entrega2 = new EntregaExpressa(2020,50,"Fortaleza","Vitoria");
            EntregaExpressa entrega3 = new EntregaExpressa(3030, 50, "Fortaleza", "Fortaleza");
            EntregaInternacional entrega4 = new EntregaInternacional(4040,50,"brasil","estados unidos");
            EntregaInternacional entrega5 = new EntregaInternacional(5050, 50, "brasil", "colombia");
            entrega1.CalcularFrete();
            entrega2.CalcularFrete();
            entrega3.CalcularFrete();
            entrega4.CalcularFrete();
            entrega5.CalcularFrete();
        }
    }
    class Entrega
    {
        protected int numeroProduto;
        protected double peso;

        public Entrega( int NumeroProduto, double Peso)
        {
            numeroProduto = NumeroProduto;
            peso = Peso;
        }

        public virtual void CalcularFrete()
        {
            Console.WriteLine($"O valor do frete da encomenda {numeroProduto} é R$: {peso}");
        }
    }

    class EntregaEconomica : Entrega 
    { 
        private int frete = 5;
        
        public EntregaEconomica(int numeroProduto, double peso, string origem, string destino) : base(numeroProduto, peso) { }

        public override void CalcularFrete()
        {
            Console.WriteLine($"O valor do frete da encomenda Economica {numeroProduto} é R$: {peso * frete}");
        }
    }

    class EntregaExpressa : Entrega

    {
        private string origem;
        private string destino;
        private int frete = 7;

        public EntregaExpressa(int numeroProduto, double peso, string Origem, string Destino) : base(numeroProduto, peso)
        { 
            origem = Origem;
            destino = Destino;                 
        }
        public override void CalcularFrete()
        {
            if(origem != destino)
            {
                Console.WriteLine($"O valor do frete da encomenda Expressa {numeroProduto} é R$: {(peso * frete) + 10} Origem: {origem} Destino: {destino}");

            }
            else
            {
                Console.WriteLine($"O valor do frete da encomenda Expressa {numeroProduto} é R$: {peso * frete} Origem: {origem} Destino: {destino}");
            }
        }
    }

    class EntregaInternacional : Entrega
    {
        private string paisdestino;
        private string paisorigem;
        private int frete = 12;

        public EntregaInternacional(int numeroProduto, double peso, string paisOrigem, string paisDestino) : base(numeroProduto, peso) 
        { 
            paisdestino = paisDestino;
           paisorigem = paisOrigem;
        }
        public override void CalcularFrete()
        {
            if (paisorigem != paisdestino)
            {
                if(paisdestino.ToLower() == "estados unidos" || paisdestino == "eua")
                {
                    Console.WriteLine($"O valor do frete da encomenda Internacional {numeroProduto} é R$: {(peso * frete) + 40} Origem: {paisorigem} Destino: {paisdestino}");
                }
                else
                {
                    Console.WriteLine($"O valor do frete da encomenda Internacional {numeroProduto} é R$: {(peso * frete) + 20} Origem: {paisorigem} Destino: {paisdestino}");
                }
            }
        }
    }
}
