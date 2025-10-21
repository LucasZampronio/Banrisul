using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AssistenteVirtual
{
    public static void Rodar()
    {
        bool flag = true;
        while (flag)
        {
            ExibirMenu();
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao){
                case 1:
                    Console.WriteLine(ObterDataAtual());
                    break;
                case 2:
                    Console.WriteLine(ObterHoraAtual());
                    break;
                case 3:
                    DizerOla();
                    break;
                case 0:
                    flag = false;
                    break;
                default:

                    Console.WriteLine("Digite uma opção valida");
                    break;
            }
        }
    

        /* Executar infinitamente o assistente virtual, executando cada ação conforme
         * selecionado pelo usuário, até que o mesmo selecione a opção para encerrar
        */
        // TODO
    }

    // Método para exibir as opções de menu para o usuário
    static void ExibirMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("===== Menu Interativo =====");
        Console.WriteLine("1 - Exibir data atual");
        Console.WriteLine("2 - Exibir hora atual");
        Console.WriteLine("3 - Exibir saudação");
        Console.WriteLine("0 - Finalizar");
        Console.WriteLine("===========================");
        Console.Write("Escolha uma opção válida: ");
        Console.WriteLine("");
    }

    // Método que retorna a data atual formatada
    static string ObterDataAtual()
    {
        return DateTime.Now.ToString("dd/MM/yyyy");
    }

    // Método que retorna a hora atual formatada
    static string ObterHoraAtual()
    {
        return DateTime.Now.ToString("HH:mm");
    }

    // Método que imprime uma saudação
    static void DizerOla()
    {
        Console.WriteLine("Olá, usuário!\n");
    }
}
