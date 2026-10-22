using System;

public class NotificadorEmail
{
    public void Enviar(string mensagem) =>
        Console.WriteLine($"E-mail: {mensagem} (simulação)");
}

// VIOLAÇÃO DO DIP: a regra de negócio depende diretamente
// de uma implementação concreta de envio de e-mail.
public class ServicoAlertas
{
    private readonly NotificadorEmail _notificador = new NotificadorEmail();

    public void Avisar(string mensagem) => _notificador.Enviar(mensagem);
}

public static class Program
{
    public static void Main()
    {
        new ServicoAlertas().Avisar("Pedido aprovado!");
    }
}
