using System;

// VIOLAÇÃO DO OCP: cada novo tipo de cliente exige editar esta classe.
public class CalculadoraDesconto
{
    public decimal CalcularPrecoFinal(decimal preco, string tipoCliente)
    {
        if (tipoCliente == "comum")
            return preco;
        else if (tipoCliente == "premium")
            return preco * 0.90m;
        else if (tipoCliente == "vip")
            return preco * 0.80m;
        else
            throw new ArgumentException("Tipo de cliente desconhecido.");
    }
}

public static class Program
{
    public static void Main()
    {
        var calculadora = new CalculadoraDesconto();
        Console.WriteLine($"Cliente comum: R$ {calculadora.CalcularPrecoFinal(200m, "comum"):F2}");
        Console.WriteLine($"Cliente premium: R$ {calculadora.CalcularPrecoFinal(200m, "premium"):F2}");
        Console.WriteLine($"Cliente VIP: R$ {calculadora.CalcularPrecoFinal(200m, "vip"):F2}");
    }
}
