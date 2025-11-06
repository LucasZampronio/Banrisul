using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharp2
{
    class Ex9
    {

        public static void Rodar()
        {
            string nome;
            int idade;
            string email;
            while (true)
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                if (nome != "" && nome.Length < 3)
                {

                }
                else
                {
                    break;
                }

                Console.Write("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade> 0 && idade < 120)
                {

                }
                else
                {
                    break;
                }

                Console.Write("Digite seu email: ");
                email = Console.ReadLine();
                if(email.Contains("@") && email.Contains("."))
                {

                }
                else
                {
                    break;
                }
                // TODO: Valide o nome
                // Se válido: break
                // Se inválido: mostre erro e tente novamente
            }

            // 2. Idade (entre 0 e 120)
            // TODO: Implemente validação similar

            // 3. Email (deve conter @ e .)
            // TODO: Implemente validação

            Console.WriteLine("\nDados válidos:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
