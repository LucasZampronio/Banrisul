using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppNotificacao
{
    public static void Rodar()
    {
        Email email1 = new Email("lucas10609@gmail.com");
        Sms sms1 = new Sms("51-997234531");
        Push push1 = new Push("Iphone de lucas");


        sms1.enviarMensagem("Mensagem enviada por sms");
        email1.enviarMensagem("Mensagem enviada por email");
        push1.enviarMensagem("Mensagem enviada por airdrop");

    }


}

public interface Notificacao
{
    void enviarMensagem(string mensagem);

}

public class Email : Notificacao 
{ 
    protected string email;

    public Email(string Email)
    {
        email = Email;
    }

    public void enviarMensagem(string mensagem)
    {
        Console.WriteLine($"Email: {email} Mensagem: {mensagem}");
    }
}

public class Sms : Notificacao
{
    protected string numero;


    public Sms( string Numero)
    {
        numero = Numero;
    }

    public void enviarMensagem(string mensagem)
    {
        Console.WriteLine($"Número: {numero} Mensagem: {mensagem}");
    }
}

public class Push : Notificacao
{
    protected string celular;

    public Push( string Celular)

    {
        celular = Celular;
    }

    public void enviarMensagem(string mensagem)
    {
        Console.WriteLine($"Número: {celular} Mensagem: {mensagem}");
    }

}

