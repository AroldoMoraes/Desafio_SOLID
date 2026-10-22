public class NotificadorEmailConsole : INotificadorPedido
{
    // Simulação didática: não envia um e-mail real.
    public void Notificar(Pedido pedido) =>
        Console.WriteLine($"E-mail enviado para {pedido.EmailCliente} (simulação).");
}
