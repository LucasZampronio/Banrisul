using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemabancario
{

   
    class Program
    {
        public static List<Banco> lista_bancos = new List<Banco>();

        static void Main(string[] args)
        {

            while (true) { 
          
                Menu();

                Banco banco = SelecionaBanco();
                if (banco.Nome == ""){
                    Console.WriteLine("Banco não encontado");
                    
                    }
 

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        { 
                        banco.cadastroCliente();
                        ;
                        break; 
                        }
                    case "2":
                        {     
                        break; 
                        }
                    case "3":
                        { 
                        break; 
                        }
                    case "4":
                        { 
                        break;
                        }
                    case "5":
                        { 

                        break;
                        }
                    case "6":
                        { 

                        break; 
                        }
                    case "7":
                        {

                        break; 
                        }
                    case "8":
                        {
                        CriarBanco();

                        break;
                        }
                    case "s":
                        {
                         break;
                        }
                    default:
                        { 

                        Console.WriteLine("Digite uma opção valida");
                        break;
                        }

                }
             }

        }


        static void Menu(){

            Console.WriteLine("\n1 - Cadastro cliente");
            Console.WriteLine("2 - Cadastro conta");
            Console.WriteLine("3 - Listagem de cliente");
            Console.WriteLine("4 - Vizualizar saldo");
            Console.WriteLine("5 - Realizar deposito");
            Console.WriteLine("6 - Saque");
            Console.WriteLine("7 - Transferência");
            Console.WriteLine("8 - Criar banco");
            Console.WriteLine("S - Sair");
            Console.Write("Selecione a ação: ");

        } 

        static void CriarBanco()
        {
            Console.WriteLine("Digite o nome do banco que seja criar:");
            string nome = Console.ReadLine();
            Banco novoBanco = new Banco(nome);

            lista_bancos.Add(novoBanco);

        }

        static Banco SelecionaBanco()
        {
            Console.Write("Digite o nome do banco que deseja selecionar");

            Banco bancoVazio = new Banco(" ");

            foreach(Banco banco in lista_bancos)
            {
                Console.WriteLine("");
                Console.WriteLine($"{banco.Nome}");
            }

            string nome = Console.ReadLine();

            foreach(Banco banco in lista_bancos)
            {
                if(nome.ToLower() == banco.Nome.ToLower())
                {
                    return banco;
                }
                else
                {
                    Console.WriteLine("Não há bancos com esse nome");
                }
            }

            return bancoVazio;

        }


    }

    class Banco
    {
        public String Nome;
        public List<Cliente> lista_clientes = new List<Cliente>();

        public Banco(string nome)
        {
            Nome = nome;
        }


        public void cadastroCliente()
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu CPF:");
            string cpf = Console.ReadLine();

            Cliente novoCliente = new Cliente(nome,cpf);

            lista_clientes.Add(novoCliente);
        }
 

    }

    class Cliente
    {
        public String Nome;
        public String Cpf;
        public List<ContaBancaria> contas_associadas = new List<ContaBancaria>();

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

    }
    
    class ContaBancaria
    {
        public int Numero_conta;
        public string Tipo;
        public double Saldo;

        public ContaBancaria(int numero, string tipo, double saldo)
        {
            Numero_conta = numero;
            Tipo = tipo;
            Saldo = saldo;
        }

    }
}

