public class RepositorioPedidoConsole : IRepositorioPedido
{
    // Simulação didática: não grava em um banco de dados real.
    public void Salvar(Pedido pedido) =>
        Console.WriteLine($"Pedido de R$ {pedido.Total:F2} salvo (simulação).");
}
