using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoBanco
{
    // Desafio dojo: Sistema bancário

    using System;
    using System.Collections.Generic;
        
    class App
    {

        public List<Banco> bancos;

        static void Main()
        {
            Banco banrisul = new Banco("Banrisul");
            Console.WriteLine("Iniciando o sistema bancário...");

            // Menu de operações
            while (true)
            {
                Console.WriteLine("\n1 - Cadastrar novo cliente");
                Console.WriteLine("2 - Cadastrar conta para cliente");
                Console.WriteLine("3 - Listar clientes");
                Console.WriteLine("4 - Consultar saldo de conta");
                Console.WriteLine("5 - Efetuar depósito");
                Console.WriteLine("6 - Efetuar saque");
                Console.WriteLine("7 - Efetuar transferência");
                Console.WriteLine("S - Sair");
                Console.Write("Selecione a ação: ");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                switch (opcao)
                {
                    case "1":
                        banrisul.CadastrarNovoCliente();

                        break;
                    case "2":
                        banrisul.CadastrarNovaContaBancaria();

                        break;
                    case "3":
                        banrisul.ListarClientesEContas();

                        break;
                    case "4":
                        banrisul.ConsultarSaldoContaBancaria();

                        break;
                    case "5":
                        banrisul.RealizarDeposito();

                        break;
                    case "6":
                        banrisul.RealizarSaque();

                        break;
                    case "7":
                        banrisul.RealizarTransferencia();

                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");

                        break;
                }
            }

            Console.WriteLine("\nEncerrando o sistema bancário...");
        }

    }

    class Cliente
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }
        public List<ContaBancaria> contas { get; private set; }


        public Cliente(string Nome, string Cpf)
        {
            nome = Nome;
            cpf = Cpf;
        }
    }

    class ContaBancaria
    {
        public int numeroConta { get; private set; }
        public string tipo { get; private set; }
        public decimal saldo { get; private set; }


        public ContaBancaria(int NumeroConta, string Tipo, decimal Saldo)
        {
            numeroConta = NumeroConta;
            tipo = Tipo;
            saldo = Saldo;


        }

        public void setSaldo(decimal Saldo)
        {
            saldo = Saldo;
        }

    }

    class Banco
    {
        public List<Cliente> clientes { get; private set; }
        public string nome;

        public Banco(string Nome)
        {
            nome = Nome;
        }

        public void CadastrarNovoCliente()
        {
            Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
            string inputCPF = Console.ReadLine();

            foreach(var c in clientes)
            {
                if(c.cpf == inputCPF)
                {
                    Console.WriteLine("Já existe um cliente com esse CPF");
                    return;
                }
            }

            if (inputCPF.ToUpper() == "S")
                return;

            Console.WriteLine($"Digite o nome do cliente (ou 'S' para sair):");
            string inputNome = Console.ReadLine();

            foreach (var c in clientes)
            {
                if (c.nome == inputNome)
                {
                    Console.WriteLine("Já existe um cliente com esse Nome");
                    return;
                }
            }

            if (inputNome.ToUpper() == "S")
                return;

            Cliente cliente  = new Cliente(inputCPF, inputNome);

            clientes.Add(cliente);
            

            Console.WriteLine($"Cliente '{cliente.cpf}' cadastrado com sucesso!");
        }

        public void CadastrarNovaContaBancaria()
        {
            Random random = new Random();
            int NumeroConta = random.Next(1,10000);
            Console.WriteLine("\nDigite o CPF do cliente (ou 'S' para sair):");
            string inputCPF = Console.ReadLine();


            if (inputCPF.ToUpper() == "S")
                return;

            if (VerificarCadastroCliente(inputCPF))
            {
                Console.WriteLine("Cliente não encontrado.");

                return;
            }

            Console.WriteLine("Digite o número respectivo ao tipo de conta, sendo 1 para 'Poupança' e 2 para 'Corrente' (ou 'S' para sair):");
            string inputTipo = Console.ReadLine();

            string tipo = "Indefinido";

            if(inputTipo.ToLower() == "1")
            {
                tipo = "Poupança";
            }
            else if (inputTipo.ToLower() == "2")
            {
                tipo = "Corrente";
            }

            if (inputTipo.ToUpper() == "S")
                return;

            if (inputTipo.ToLower() != "1" || inputTipo.ToLower() != "2")
            {
                Console.WriteLine("Tipo de conta inválido.");

                return;
            }

            Console.WriteLine("Digite o saldo inicial (R$):");
            decimal inputSaldo = Convert.ToDecimal(Console.ReadLine());

            if (VerificarSaldoPositivo(inputSaldo))
            {
                Console.WriteLine("Saldo inválido. Conta iniciará com saldo R$ 0,00.");
                inputSaldo = 0;
            }

            ContaBancaria conta = new ContaBancaria(NumeroConta, tipo, inputSaldo);
            Cliente cliente  = RetornarClientePeloCPF(inputCPF);

            Console.WriteLine($"Conta {NumeroConta} criada para o cliente {cliente.cpf} com sucesso! Saldo de {inputSaldo}.");

        }

        public void ListarClientesEContas()
        {
            if (clientes.Count() == 0)
            {
                Console.WriteLine("Não há clientes cadastrados.");

                return;
            }

            Console.WriteLine("\nLista de clientes");

            foreach(var c in clientes)
            {
                if (c.contas.Count() == 0)
                {
                    Console.WriteLine($">>> Nenhuma conta cadastrada no CPF {c.cpf}.");

                    continue;
                }
                else
                {
                    Console.WriteLine($">>> Cliente {c.nome}.");
                }

                foreach (var conta in c.contas)
                {
                    Console.WriteLine($">>> Conta {conta.tipo} número {conta.numeroConta}: {conta.saldo}.");
                }

                Console.WriteLine("");
            }
        }

        public void ConsultarSaldoContaBancaria()
        {

            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
            {
                return;
            }

            int inputConvertido = Convert.ToInt32(inputNumeroConta);

            foreach( var c in clientes)
            {
                foreach(var conta in c.contas)
                {
                    if(conta.numeroConta == inputConvertido)
                    {
                        Console.WriteLine($"Cliente {c.nome}.");
                        Console.WriteLine($"Saldo da conta número {conta.numeroConta}: {conta.saldo}.");
                        return;

                    }
                }
            }

            Console.WriteLine("Conta não encontrada");
            return;
        }

        public void RealizarDeposito()
        {

            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
            {
                return;
            }

            decimal deposito = Convert.ToDecimal(Console.ReadLine());

            int inputConvertido = Convert.ToInt32(inputNumeroConta);

            foreach (var c in clientes)
            {
                foreach (var conta in c.contas)
                {
                    if (conta.numeroConta == inputConvertido)
                    {
                        decimal saldoAtualizado = conta.saldo + deposito;
                        conta.setSaldo(saldoAtualizado);
                        Console.WriteLine($"Cliente {c.nome}.");
                        Console.WriteLine($"Depósito de R$ {deposito:F2} realizado com sucesso na conta {conta.numeroConta}! Saldo de {conta.saldo}.");

                        return;

                    }
                }
            }

            Console.WriteLine("Conta não encontrada");
        }

        public void RealizarSaque()
        {
            Console.WriteLine("\nDigite o número da conta (ou 'S' para sair):");
            string inputNumeroConta = Console.ReadLine();

            if (inputNumeroConta.ToUpper() == "S")
            {
                return;
            }

            decimal saque = Convert.ToDecimal(Console.ReadLine());

            int inputConvertido = Convert.ToInt32(inputNumeroConta);

            foreach (var c in clientes)
            {
                foreach (var conta in c.contas)
                {
                    if (conta.numeroConta == inputConvertido)
                    {
                        decimal saldoAtualizado = conta.saldo - saque;

                        if ( conta.saldo<0)
                        {
                            Console.WriteLine($"Saque não efetuado. Você tem R$ {conta.saldo} para saque, Tente novamente.");
                            return;
                        }
                        conta.setSaldo(saldoAtualizado);
                        Console.WriteLine($"Cliente {c.nome}.");
                        Console.WriteLine($"Saque de R$ {saque:F2} realizado com sucesso na conta {conta.numeroConta}! Saldo de {conta.saldo}.");

                        return;

                    }
                }
            }
        }

        public static void RealizarTransferencia()
        {
            Console.WriteLine("\nDigite o número da conta originária (ou 'S' para sair):");
            string inputNumeroContaOriginaria = Console.ReadLine();

            if (inputNumeroContaOriginaria.ToUpper() == "S")
                return;









            for

            if (!int.TryParse(inputNumeroContaOriginaria, out int numeroContaOriginaria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroContaOriginaria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("\nDigite o número da conta destinatária (ou 'S' para sair):");
            string inputNumeroContaDestinataria = Console.ReadLine();

            if (inputNumeroContaDestinataria.ToUpper() == "S")
                return;

            if (!int.TryParse(inputNumeroContaDestinataria, out int numeroContaDestinataria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            if (!ContaBancaria.Cadastrada(numeroContaDestinataria))
            {
                Console.WriteLine("Conta não encontrada.");

                return;
            }

            Console.WriteLine("Digite o valor da transferência (R$):");
            string inputTransferencia = Console.ReadLine();

            if (!double.TryParse(inputTransferencia, out double transferencia))
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            if (transferencia <= 0)
            {
                Console.WriteLine("Valor inválido.");

                return;
            }

            bool saqueBemSucedido = ContaBancaria.Sacar(numeroContaOriginaria, transferencia);

            if (!saqueBemSucedido)
            {
                Console.WriteLine($"Transferência de R$ {transferencia:F2} NÃO foi realizada devido a saldo insuficiente na conta originária {numeroContaOriginaria}! Saldo de {ContaBancaria.ObterSaldo(numeroContaOriginaria)}.");

                return;
            }

            ContaBancaria.Depositar(numeroContaDestinataria, transferencia);

            Console.WriteLine($"Transferência de R$ {transferencia:F2} realizada com sucesso da conta originária {numeroContaOriginaria} para a conta destinatária {numeroContaDestinataria}!");
        }

        public bool VerificarCadastroCliente(string Cpf)
        {
            foreach (var c in clientes)
            {
                if (c.cpf == Cpf)
                {
                    return true;
                }
            }
            return false;
        }

        public bool VerificarSaldoPositivo(decimal saldo)
        {
            if(saldo >= 0)
            {
                return true;
            }
            return false;
        }

        public Cliente RetornarClientePeloCPF(string Cpf)
        {
            Cliente cliente = new Cliente("Indefinido","Indefinido");

            foreach (var c in clientes)
            {
                if (Cpf == c.cpf)
                {
                    cliente = c;

                    return cliente;
                }
            }
            return cliente;

        }
    }

}
