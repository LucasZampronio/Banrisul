using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppGetter
{
    public static void Rodar()
    {
        ContaBancaria conta1 = new ContaBancaria(1010,90320769,"Lucas",500);
        conta1.Depositar();
        conta1.Sacar();
        Console.WriteLine(conta1.getSaldo());


    }

}

class ContaBancaria
{

    public int Numero { get; private set; }
    public int Cpf { get; private set; }
    public string Nome { get; private set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, int cpf, string nome, double saldo) {

        Numero = numero;
        Cpf = cpf;
        Nome = nome;
        Saldo = saldo;
            
        }

    public double getSaldo()
    {
        return Saldo;
    }

    public double SetSaldo(double novoSaldo)
    {
        Saldo = novoSaldo;

        return Saldo;
    }

    public void Depositar()
    {
        Console.WriteLine("Digite o valor do deposito");
        double deposito = Convert.ToDouble(Console.ReadLine());
        if (deposito < 0)
        {
            Console.WriteLine("Você deve depositar um valor maior que 0");
        }
        else
        {
            double saldoAtual = getSaldo();
            double SaldoFinal = saldoAtual + deposito;
            SetSaldo(SaldoFinal);
        }
    }

    public bool Sacar()
    {
        Console.WriteLine("Digite o valor do saque");
        double saque = Convert.ToDouble(Console.ReadLine());
        if (saque > Saldo)
        {
            
            Console.WriteLine("O saque não pode ser maior que o seu saldo atual");
            return false;
        }
        else
        {
            double saldoAtual = getSaldo();
            double SaldoFinal = saldoAtual - saque;
            SetSaldo(SaldoFinal);
            Console.WriteLine("Saque efetuado com sucesso!");
            return true;
        }
    }
}
