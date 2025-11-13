
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp6
{
    class TextAnalyzer
    {
        int TotalLines;
        int TotalWords;
        int TotalChars;
        Dictionary<string, int> WordFrequency;

        static void Main(string[] args)
        {
            TextAnalyzer analisador = new TextAnalyzer();

            analisador.ContarLetras(@"C:\Users\T10863\source\repos\ConsoleApp6\ConsoleApp6\texto.txt");

        }

        public void ContarLinhas(string path)
        {
           
            using (var arquivo = new StreamReader(path))
            {
                int contadorLinhas = 0;
                string linha; 
                while ((linha = arquivo.ReadLine()) != null)
                {
                    contadorLinhas++;
                }

                TotalLines = contadorLinhas;


            }
            
            
        }
        public void ContarPalavras(string path)
        {
            string arquivo = File.ReadAllText(path);
            int contadorPalavra = 1;
            for (int i = 0; i < arquivo.Length; i++)
            {
                if (arquivo[i] == ' ')
                {
                    contadorPalavra++;
                } 
            }
            TotalWords = contadorPalavra;
        }

        public void ContarLetras(string path)
        {
            string arquivo = File.ReadAllText(path);
            int contadorLetra = 0;
            for(int i = 0; i < arquivo.Length; i++)
            {
                if (arquivo[i] != ' ' &&  ! char.IsDigit(arquivo[i]))
                {
                    contadorLetra++;
                }
            }
            TotalChars = contadorLetra;
        }

        public void GetTopWords()
        {

        }

        public void SaveReport(string outputPath)
        {

        }
    }

}
