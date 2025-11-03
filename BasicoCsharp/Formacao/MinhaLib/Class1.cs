namespace MinhaLib.Matematica
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
        public int Dividir(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("Divisão por zero não é permitida.");
            }
        }
    }
}