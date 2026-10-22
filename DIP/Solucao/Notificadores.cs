public class NotificadorEmail : INotificador
{
    public void Enviar(string mensagem) =>
        Console.WriteLine($"E-mail: {mensagem} (simulação)");
}

public class NotificadorSms : INotificador
{
    public void Enviar(string mensagem) =>
        Console.WriteLine($"SMS: {mensagem} (simulação)");
}

public class NotificadorMemoria : INotificador
{
    public List<string> Mensagens { get; } = new();

    public void Enviar(string mensagem) => Mensagens.Add(mensagem);
}
