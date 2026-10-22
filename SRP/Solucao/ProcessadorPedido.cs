public class ProcessadorPedido
{
    private readonly CalculadoraPedido _calculadora;
    private readonly IRepositorioPedido _repositorio;
    private readonly INotificadorPedido _notificador;

    public ProcessadorPedido(
        CalculadoraPedido calculadora,
        IRepositorioPedido repositorio,
        INotificadorPedido notificador)
    {
        _calculadora = calculadora;
        _repositorio = repositorio;
        _notificador = notificador;
    }

    // Responsabilidade única: coordenar o processamento do pedido.
    public void Processar(decimal[] precos, string emailCliente)
    {
        var pedido = new Pedido(_calculadora.CalcularTotal(precos), emailCliente);
        Console.WriteLine($"Total calculado: R$ {pedido.Total:F2}");
        _repositorio.Salvar(pedido);
        _notificador.Notificar(pedido);
    }
}
