public class CalculadoraPedido
{
    // Responsabilidade única: calcular o total.
    public decimal CalcularTotal(IEnumerable<decimal> precos) => precos.Sum();
}
