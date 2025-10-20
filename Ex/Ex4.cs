using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ex4Dia2 { 
   
    public static void Resposta()
    {
        Console.WriteLine("Digite o seu nome");
        String nome = Console.ReadLine();
        int tamanho = nome.Length;
     
        Console.WriteLine("Digite o seu sobrenome");
        String sobrenome = Console.ReadLine();
        int tamanhos = sobrenome.Length;
        String inicialSobrenome = sobrenome.Substring(0,1);
        String inicialNomes = nome.Substring(0,1);
       
        int metadeNome = tamanho/2;
        int metadeS = tamanho/2;

        string inicialSecreto = nome.Substring(0,metadeNome);
        string finalSecreto = nome.Substring(metadeS,metadeS);
 
        Console.WriteLine($"Iniciais e contagem: {inicialNomes.ToUpper()}.{inicialSobrenome.ToUpper()}.({tamanho})");
        Console.WriteLine($"Nome secreto:{inicialSecreto} {finalSecreto}");
        Console.Write("teste");



    }



}
