using System;
using System.Threading;

namespace Cliente
{
    public class Program
    {
        private const string PROTOCOLO = "http";
        private const string DOMINIO = "localhost";
        private const int PORTA = 3088;

        public static void Main(string[] args)
        {
            Console.WriteLine("::::::::::::::::::");
            Console.WriteLine($":::: {ClienteHttp.IDENTIFICADOR} :::::");
            Console.WriteLine("::::::::::::::::::\n");
            Console.WriteLine("Pressione ENTER para encerrar...\n");
            var cliente  =  new ClienteHttp();
            string flag = "10";
            while (flag != "0")
            {
                Menu();
                flag = Console.ReadLine();
                switch (flag)
                {
                    case "1":
                        var respostaGET = cliente.EnviarGet(ObterCaminho());
                        break;
                    case "2":
                        Console.WriteLine("Digite o corpo da requisição");
                        string corpo  = Console.ReadLine();
                        var respostaPOST = cliente.EnviarPost(ObterCaminho(),corpo);
                        break;
                     case "3":
                        Console.WriteLine("Digite o corpo da requisição");
                        string corpoPut = Console.ReadLine();
                        var respostaPut = cliente.EnviarPut(ObterCaminho(),corpoPut);
                        break;
                     case "4":
                        var respostaDelete = cliente.EnviarDelete(ObterCaminho());
                        break;
                     case "5":
                        Console.WriteLine("Saindo...");
                        flag = "0";
                        break;
                     default:
                        Console.WriteLine("Digite uma opção valida");
                        break;
                    
                }
                cliente.Encerrar();

            }
        }

        private static string ObterCaminho()
        {
            return $"{PROTOCOLO}://{DOMINIO}:{PORTA}/";
        }
        public static void Menu()
        {
            Console.WriteLine("1 - GET");
            Console.WriteLine("2 - POST");
            Console.WriteLine("3 - PUT");
            Console.WriteLine("4 - DELETE");
            Console.WriteLine("5 - SAIR");
        }
    }
}
