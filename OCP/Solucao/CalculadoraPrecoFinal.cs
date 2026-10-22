public class CalculadoraPrecoFinal
{
    public decimal Calcular(decimal preco, IPoliticaDesconto politica) =>
        politica.Aplicar(preco);
}
