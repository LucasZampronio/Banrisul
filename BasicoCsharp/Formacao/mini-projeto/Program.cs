using System;
using System.Runtime.InteropServices; 

namespace Ex
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("   BEM-VINDO AO SISTEMA .NET     ");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine() ?? "Visitante";
            Console.WriteLine($"Olá, {nome}!");

            string opcao = "4"; 
            while (opcao != "3") 
            {
                Menu(); 

                opcao = Console.ReadLine(); 
                
                switch (opcao)
                {
                    case "1":
                        {
                            Version versao = Environment.Version;
                            Console.WriteLine($"Sistema: {RuntimeInformation.OSDescription}"); 
                            Console.WriteLine($"Versão: {versao}"); 
                            break;
                        }
                    case "2":
                        {
                            DateTime data = DateTime.Now;
                            Console.WriteLine($"Data e hora: " + data);
                            break;
                        }
                    case "3":
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
        
        public static void Menu()
        {
            Console.WriteLine("MENU:"); 
            Console.WriteLine("[1] Ver informações do sistema"); 
            Console.WriteLine("[2] Ver data e hora"); 
            Console.WriteLine("[3] Sair"); 
            Console.WriteLine(" "); 
            Console.WriteLine("Escolha uma opção"); 

        }
    }
}
