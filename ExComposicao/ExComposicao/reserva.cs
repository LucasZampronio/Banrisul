using System;

class Appreserva
{

    public static void Rodar()
    {
        Reserva reservaCompleta = new Reserva("João da Silva", 101, 5, 250.00m,"CONFIRMADO");
        Console.WriteLine("Reserva completa:");
        reservaCompleta.ExibirResumo();


        Reserva reservaNomeQuarto = new Reserva("Maria Souza", 202, 300.00m);
        Console.WriteLine("Reserva com nome e quarto:");
        reservaNomeQuarto.ExibirResumo();

        Console.WriteLine();

        Reserva reservaQuarto = new Reserva(303, 350.00m);
        Console.WriteLine("Reserva com quarto e valor da diária:");
        reservaQuarto.ExibirResumo();
    }

    public class Reserva
    {
        public string NomeCliente { get; private set; }
        public int NumeroQuarto { get; private set; }
        public int NumeroDias { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string Status { get; private set; } = "CONFIRMADO";

        public Reserva(string nome, int quarto, int dias, decimal diaria)
        {
            NomeCliente = nome;
            NumeroQuarto = quarto;
            NumeroDias = dias;
            ValorDiaria = diaria;
            ValorTotal = dias * diaria;
        }

        public Reserva(string nome, int quarto, decimal diaria) : this(nome, quarto, 2, diaria)
        {
            Status = "PENDENTE";
        }

        public Reserva(int quarto, decimal diaria) : this("A definir", quarto, 2, diaria)
        {
            Status = "PENDENTE";
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Cliente: {NomeCliente}");
            Console.WriteLine($"Quarto: {NumeroQuarto}");
            Console.WriteLine($"Número de dias: {NumeroDias}");
            Console.WriteLine($"Valor da diária: {ValorDiaria:C}");
            Console.WriteLine($"Valor total: {ValorTotal:C}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}



