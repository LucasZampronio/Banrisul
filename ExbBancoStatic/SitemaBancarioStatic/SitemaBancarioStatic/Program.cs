using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaBancarioStatic
{
    class Banco
    {
        public static Dictionary<int, int> ListaClientes = new Dictionary<int, int>();
        public static Dictionary<int, long> ContaAssociada= new Dictionary<int, long>();
        public static int Idcliente = 1;
        public static int Idconta = 1;
       



        static void Main(string[] args)
        {
            

            while (true)
            {
                Menu();


                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        {
                            Banco.CadastroCliente();
                            break;
                        }
                    case "2":
                        {
                            Banco.CadastroConta();
                            break;
                        }
                    case "3":
                        {
                            Banco.ListarContas();
                            break;
                        }
                    case "4":
                        {
                            Banco.listarSaldo();
                    
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
        }//

        static void Menu()
        {
            Console.WriteLine("\n1 - Cadastro cliente");
            Console.WriteLine("2 - Cadastro conta");
            Console.WriteLine("3 - Listagem de cliente");
            Console.WriteLine("4 - Vizualizar saldo");
            Console.WriteLine("5 - Realizar deposito");
            Console.WriteLine("6 - Saque");
            Console.WriteLine("7 - Transferência");
            Console.WriteLine("S - Sair");
            Console.Write("Selecione a ação: ");
        }

        static void CadastroCliente() {
            
            Console.WriteLine("Digite o seu nome");
            string nome  = Console.ReadLine();
            Console.WriteLine("Digite o seu CPF");
            long cpf = Convert.ToInt64(Console.ReadLine());
            Clientes.cadastraClientes(Idcliente, nome, cpf);
            Idcliente++;
            
            }




        static void CadastroConta()
        {
            Console.WriteLine("Digite o numero da conta");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o tipo da conta: poupança ou corrente");
            string tipo = Console.ReadLine();
            Console.WriteLine("Digite o saldo inicial");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o CPF que deseja associar");
            long cpf = Convert.ToInt64(Console.ReadLine());
            ContaBancaria.criar(Idconta,numero,tipo,saldo);
            ContaAssociada.Add(numero,cpf);
            Idconta++;
           

        }

        static void ListarContas()
        {
            Console.WriteLine("Digite um CPF para buscar as contas");
            long cpf = Convert.ToInt64(Console.ReadLine());
            ContaBancaria.listar(cpf);
        }

        static void listarSaldo()
        {
            Console.WriteLine("Digite o número da conta");
            int numero = Convert.ToInt16(Console.ReadLine());
            ContaBancaria.listarSaldo(numero);
        }


        class Clientes {

            static Dictionary<int, string> Nome = new Dictionary<int, string>();
            static Dictionary<int, long> Cpf = new Dictionary<int, long>();



            public static void cadastraClientes(int Idcliente,String nome, long cpf)
            {

                Nome.Add(Idcliente, nome);
                Cpf.Add(Idcliente,cpf);
            }


        }
    
        
        
    class ContaBancaria {

  
            static Dictionary<int, int> Numero = new Dictionary<int, int>();
            static Dictionary<int, string> Tipo = new Dictionary<int, string>();
            static Dictionary<int, double> Saldo = new Dictionary<int, double>();


            public static void criar(int Idconta, int numero, string tipo, double saldo ){


                Numero.Add(Idconta,numero);
                Tipo.Add(Idconta,tipo);
                Saldo.Add(Idconta,saldo);
           
                
               }

            public static void listar(long cpf)
            {
           
                    foreach(var conta in ContaAssociada)
                    {

                        foreach(var tipo in Tipo)
                        {
                            foreach(var saldo in Saldo)
                            {
                                if (conta.Value == cpf)
                                {
                                    Console.WriteLine($"------------------------------");
                                    Console.WriteLine($"Conta número: {conta.Key}");
                                    Console.WriteLine($"Conta número: {tipo.Value}");
                                    Console.WriteLine($"Conta número: {saldo.Value}");
                                    Console.WriteLine($"------------------------------");

                                }
                            else {
                                Console.WriteLine("Nenhuma conta encontrada com esse CPF");

                                }
                           
                              
                            }

                        }
                    }

            }

            public static void listarSaldo(int numero)
            {
                foreach (var conta in ContaAssociada)
                {

                    foreach (var tipo in Tipo)
                    {
                        foreach (var saldo in Saldo)
                        {
                            if (conta.Key == numero)
                            {
                                Console.WriteLine($"------------------------------");
                                Console.WriteLine($"Conta número: {conta.Key}");
                                Console.WriteLine($"Conta número: {tipo.Value}");
                                Console.WriteLine($"Conta número: {saldo.Value}");
                                Console.WriteLine($"------------------------------");

                            }
                            else
                            {
                                Console.WriteLine("Nenhuma conta encontrada com esse número");

                            }


                        }

                    }
                }
               

            }

            public static void Depositov(int numero, double qntdeposito)
            {
                foreach (var conta in ContaAssociada)
                {

                    foreach (var tipo in Tipo)
                    {
                        foreach (var saldo in Saldo)
                        {
                            if (conta.Key == numero)
                            {
                                int idsaldo = saldo.Key;
                                Console.WriteLine("Salto anterior");
                                Console.WriteLine($"{saldo.Value}");
                                Console.WriteLine($"------------------------------");
                                Console.WriteLine($"Conta número: {conta.Key}");
                                Console.WriteLine($"Conta número: {tipo.Value}");
                                Console.WriteLine($"Conta número: {saldo.Value}");
                                Console.WriteLine($"------------------------------");

                            }
                            else
                            {
                                Console.WriteLine("Nenhuma conta encontrada com esse número");

                            }


                        }

                    }
                }


            }

        }
    }
}

 

