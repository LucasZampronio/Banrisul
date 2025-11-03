namespace Formacao
{
    public class Ex
    {
        public static void Main(string[] args)
        {
            string nome = "João";
            int idade = 28;
            double altura = 1.75;
            DateTime hoje = DateTime.Now;

            // TODO: Complete as linhas abaixo usando diferentes métodos de formatação

            // 1. Concatenação
            Console.WriteLine("Olá, " + nome + "!");

            // 2. String.Format
            Console.WriteLine(String.Format("Olá, meu nome é {0} e tenho {1} anos.", nome, idade));

            // 3. Interpolação (recomendado)
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");

            // 4. Formatação de números
            Console.WriteLine($"Altura: {altura:F2} metros");

            // 5. Formatação de data
            Console.WriteLine($"Data de hoje: {hoje:dd/MM/yyyy}");
        }
    }
    
}