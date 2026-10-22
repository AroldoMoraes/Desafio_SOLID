public class ServicoAlertas
{
    private readonly INotificador _notificador;

    // Inversão de dependência por injeção de construtor.
    public ServicoAlertas(INotificador notificador)
    {
        _notificador = notificador ?? throw new ArgumentNullException(nameof(notificador));
    }

    public void Avisar(string mensagem) => _notificador.Enviar(mensagem);
}
