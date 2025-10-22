using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class jogodavelha
{
    public static void Rodar()
    {
        string[,] tabuleiro = new string [3,3]{{ "   " , "   " , "   " },{ "   " , "   " , "   " },{ "   " , "   " , "   " } };
        System.Console.WriteLine("Bem vindo ao jogo da velha!");
        for(int turnos = 1; turnos <= 9; turnos+=2)

            {
            MostrarTabuleiro();

            System.Console.WriteLine("É a vez do Jogador X. Selecione uma posição para jogar.");
            System.Console.WriteLine("Digite a posição da linha desejada:");
            int linhaJogadorX = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite a posição da coluna desejada:");
            int colunaJogadorX = Convert.ToInt32(Console.ReadLine());

            if (linhaJogadorX == 9 || colunaJogadorX == 9) {
                
                break;
                
            }

                tabuleiro[colunaJogadorX, linhaJogadorX] = " X ";

            MostrarTabuleiro();


            Console.WriteLine("É a vez do jogador O. selecione uma posição para jogar");
            Console.WriteLine("Digite a posição da linha desejada");
            int linhaJogadorO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a posição da coluna desejada");
            int colunaJogadorO = Convert.ToInt32(Console.ReadLine());
            tabuleiro[colunaJogadorO,linhaJogadorO] = " O ";

            if (linhaJogadorO == 9 || colunaJogadorO == 9)
            {
                break;
            }


        }

        if (tabuleiro[0,0] == " O " && tabuleiro[0,1] == " O " && tabuleiro[0,2] == " O ")
        {
            Console.WriteLine("Parabens! Voce venceu!");
        }




        void MostrarTabuleiro()
        {
            Console.WriteLine($"{tabuleiro[0, 0]}|{tabuleiro[0, 1]}|{tabuleiro[0, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{tabuleiro[1, 0]}|{tabuleiro[1, 1]}|{tabuleiro[1, 2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{tabuleiro[2, 0]}|{tabuleiro[2, 1]}|{tabuleiro[2, 2]}");

        }









    }
}