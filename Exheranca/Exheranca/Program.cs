using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exheranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();
            ContaCorrente contacorrente1 = new ContaCorrente("LucasCorrente", "100");
            Poupanca poupanca1 = new Poupanca("LucasPoupanca","200");
            ContaConjunta contaconjunta1 = new ContaConjunta("Lucas","300","Beatriz");
            contas.Add(contacorrente1);
            contas.Add(poupanca1);
            contas.Add(contaconjunta1);
            foreach(var conta in contas)
            {
                conta.Resumo();
            }

        }
    }

    public class Conta
    {
        protected string titular;
        protected string numeroConta;
        protected decimal saldo;

        public Conta(string titular, string numeroConta)
        {
            this.titular = titular;
            this.numeroConta = numeroConta;
            this.saldo = 0;
        }

        public virtual void Depositar(decimal valor) 
        {
            if(valor>= 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor dado é menor do que zero! Operação não foi feita.");
                return;           
            }

        }
        public  virtual void Sacar(decimal valor)
        {

            if (valor > 0 && saldo > valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor dado é menor do que zero! Operação não foi feita.");
                return;

            }

        }

        public virtual void Resumo()
        {
            Console.WriteLine($"Número da conta: {numeroConta}\nNome titular: {titular}\nSaldo: {saldo:F2}");
        }
    }

    public class ContaCorrente : Conta
    {
        private const decimal tarifaSaque = 1;

        public ContaCorrente(string titular, string numeroConta) : base(titular, numeroConta) { }

        public override void Sacar(decimal valor)
        {
            if (valor > 0 && saldo >= valor + tarifaSaque)
            {
                saldo -= valor + tarifaSaque;
            }
            else
            {
                Console.WriteLine("Valor dado é menor do que zero! Operação não foi feita.");
                return;
            }
        }
    }

    public class Poupanca : Conta
    {
        private const decimal taxaRendimentoAnual = 0.08m;

        public Poupanca(string titular, string numeroConta): base(titular, numeroConta) { }


        private void RenderJuro(int dias)
        {
            decimal rendimento = saldo * taxaRendimentoAnual * dias /365 ;
            base.Depositar(rendimento);
        }
    }

    public class ContaConjunta : ContaCorrente
    {
        private string segundoTitular;

        public ContaConjunta(string titular, string numeroConta, string segundoTitular) : base(titular, numeroConta) 
        { 
           
            this.segundoTitular = segundoTitular;
            
            
        }

        public override void Resumo()
        {
            Console.WriteLine($"Número da conta: {numeroConta}\nNome primeiro titular: {titular}\nNome segundo titular: {segundoTitular}\nSaldo: {saldo:F2}");

        }
    }

}
        



