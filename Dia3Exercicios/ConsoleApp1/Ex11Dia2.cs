using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex11Dia2
{
    public static void Resposta ()
    {
        Console.WriteLine("Digite seu animal favorito");
        string animal = Console.ReadLine();
        Console.WriteLine("Digite uma cor");

        string cor = Console.ReadLine();
        Console.WriteLine("Digite uma aventura");
        string aventura = Console.ReadLine();
        string novaAventura = "";
        string nomeCor = "";
        string nomeAnimal ="";

        if (animal.ToLower() == "cao")
        {
             nomeAnimal = "ANIMAL_COMPANHEIRO";
        }
        else if ( animal.ToLower() == "gato")
        {
             nomeAnimal = "ANIMAL_ASTUTO";
        }
        else if (animal.ToLower() == "coruja")
        {
             nomeAnimal = "ANIMAL_GUARDIAO";
        }
        else if (animal.ToLower() == "dragão")
        {
             nomeAnimal = "ANIMAL_FEROZ";
        }
        else if (animal.ToLower() == "outro animal")
        {
             nomeAnimal = "ANIMAL_DESCONHECIDO";

        }
        if (cor.ToLower() == "vermelho")
        {
             nomeCor = "COR_FLAMEJANTE";
        }
        else if (cor.ToLower() == "azul")
        {
             nomeCor = "COR_SABEDORIA";
        }
        else if (cor.ToLower() == "verde")
        {
             nomeCor = "COR_SILVESTRE";
        }
        else if (cor.ToLower() == "amarelo")
        {
             nomeCor = "COR_RADIANTE";
        }
        else if (cor.ToLower() == "outra cor")
        {
             nomeCor = "COR_MISTERIOSA";
        }

   
        if (aventura.ToLower() == "explorar")
        {
             novaAventura = "AVENTURA_EXPLORAR";
        }
        else if (aventura.ToLower() == "descansar")
        {
             novaAventura = "AVENTURA_DESCANSAR";
        }
        else if (aventura.ToLower() == "criar")
        {
             novaAventura = "AVENTURA_CRIAR";
        }
        else if (aventura.ToLower() == "competir")
        {
             novaAventura = "AVENTURA_COMPETIR";
        }
        else if (aventura.ToLower() == "outra aventura")
        {
             novaAventura = "AVENTURA_DESTEMIDA";
        }
      
        Console.WriteLine($"Seu avatar é: {nomeAnimal} {nomeCor} - {novaAventura}");


    
    }
}