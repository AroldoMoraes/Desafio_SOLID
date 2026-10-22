public class DescontoComum : IPoliticaDesconto
{
    public decimal Aplicar(decimal preco) => preco;
}

public class DescontoPremium : IPoliticaDesconto
{
    public decimal Aplicar(decimal preco) => preco * 0.90m;
}

public class DescontoVip : IPoliticaDesconto
{
    public decimal Aplicar(decimal preco) => preco * 0.80m;
}

// Nova funcionalidade por extensão, sem editar CalculadoraPrecoFinal.
public class DescontoCampanha : IPoliticaDesconto
{
    public decimal Aplicar(decimal preco) => preco * 0.85m;
}
