using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppGeometria
{

    public static void Rodar()
    {
        Retangulo ret = new Retangulo(12,15);
        Quadrado qua = new Quadrado(10);
        Circulo cir = new Circulo(8.9);

        ret.Area();
        ret.Perimetro();
        qua.Area();
        qua.Perimetro();
        cir.Area();
        cir.Perimetro();

    }
}

public interface FormaGeometrica
{

    void Area();
    void Perimetro();
}

public class Retangulo : FormaGeometrica
{
    protected double _base;
    protected double _altura;


    public Retangulo(double Base, double altura){
    
        _base = Base;
        _altura = altura;
    }

    public void Area()
    {
        double area = _base * _altura;
        Console.WriteLine($"A area do retangulo de base {_base} e altura {_altura} é {area}");
    }

    public void Perimetro()
    {
        double perimetro = 2 * (_base + _altura);
        Console.WriteLine($"O perimetro do retangulo de base {_base} e altura {_altura} é {perimetro}");
    }
}

public class Quadrado : FormaGeometrica
{
    protected double _lado;

    public Quadrado(double Lado)
    {
        _lado = Lado;
    }

    public void Area()
    {
        double area = _lado * _lado;
        Console.WriteLine($"A area do quadrado de lado {_lado} é {area}");
    }

    public void Perimetro()
    {
        double perimetro = 4 * _lado;
        Console.WriteLine($"O perimetro do quadrado de lado {_lado} {perimetro}");
    }
}

public class Circulo : FormaGeometrica
{
    protected double _raio;

    public Circulo(double Raio)
    {
        _raio = Raio;
    }

    public void Area()
    {
        double area = Math.PI * (_raio *2);
        Console.WriteLine($"A area do circulo de raio {_raio} é {area}");
    }

    public void Perimetro()
    {
        double perimetro = 2 * Math.PI * _raio;
        Console.WriteLine($"O perimetro do circulo de raio {_raio} é {perimetro}");
    }
}