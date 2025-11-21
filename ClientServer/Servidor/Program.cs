using PseudoFramework.ServidorUtils;
using PseudoFramework.SharedUtils;
using System;
using System.Linq;

namespace Servidor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var servidor = new ServidorHttp(ConectorHttp.ObterCaminho());

            Console.WriteLine(":::::::::::::::::");
            Console.WriteLine($":::: {ServidorHttp.IDENTIFICADOR} :::");
            Console.WriteLine(":::::::::::::::::\n");

            Console.WriteLine("Pressione ENTER para encerrar...\n");

            servidor.ProcessarHook =
                (verbo, caminho, json) => InterceptarRequisicao(verbo, caminho, json);

            servidor.Iniciar();

            Console.ReadKey();

            servidor.Encerrar();
            
            Console.ReadKey();
        }

        private static Saudacao InterceptarRequisicao(string verboHttp, string caminho, string json)
        {
            switch (verboHttp)
            {
                case "PUT":
                    return InterceptarPut(json);
                case "GET":
                    return InterceptarGet(json);
                case "DELETE":
                    return InterceptarDelete(json);
                case "POST":
                    return InterceptarPost(json);
                default:
                    return null;
            }
        }

        private static Saudacao InterceptarDelete(string json)
        {
            var saudacaoCliente = ConversorJson.Desserializar<Saudacao>(json);

            var saudacaoServidor = new Saudacao()
            {
                Cumprimento = "Olá , DELETE",
                NumeroCumprimentos = 1,
                PronomeTratamento = "Sr. ",
                Nome = "Cliente",
            };

            return saudacaoServidor;

        }

        private static Saudacao InterceptarPost(string json)
        {
            var saudacaoCliente = ConversorJson.Desserializar<Saudacao>(json);

            string cumprimentos = string.Concat(Enumerable.Repeat(saudacaoCliente.Cumprimento + " ", saudacaoCliente.NumeroCumprimentos));

            string saudacaoClienteExpressao = $"{cumprimentos}{saudacaoCliente.PronomeTratamento} {saudacaoCliente.Nome}!";

            Console.WriteLine($"\n\n{saudacaoClienteExpressao} \n");

            var saudacaoServidor = new Saudacao()
            {
                Cumprimento = "Olá , POST",
                NumeroCumprimentos = 1,
                PronomeTratamento = "Sr. ",
                Nome = "Cliente",
            };

            return saudacaoServidor;

        }

        private static Saudacao InterceptarGet(string json)
        {

            var saudacaoCliente = ConversorJson.Desserializar<Saudacao>(json);

            var saudacaoServidor = new Saudacao()
            {
                Cumprimento = "Olá , GET",
                NumeroCumprimentos = 1,
                PronomeTratamento = "Sr. ",
                Nome = "Cliente",
            };

            return saudacaoServidor;

        }

        private static Saudacao InterceptarPut(string json)
        {
            var saudacaoCliente = ConversorJson.Desserializar<Saudacao>(json);

            string cumprimentos = string.Concat(Enumerable.Repeat(saudacaoCliente.Cumprimento + " ", saudacaoCliente.NumeroCumprimentos));

            string saudacaoClienteExpressao = $"{cumprimentos}{saudacaoCliente.PronomeTratamento} {saudacaoCliente.Nome}!";

            Console.WriteLine($"\n\n{saudacaoClienteExpressao} \n");

            var saudacaoServidor = new Saudacao()
            {
                Cumprimento = "Olá, PUT",
                NumeroCumprimentos = 1,
                PronomeTratamento = "Sr.",
                Nome = "Cliente",
            };

            return saudacaoServidor;
        }
    }
}