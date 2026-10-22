using System;

// VIOLAÇÃO DO ISP: todo equipamento é obrigado a oferecer
// digitalização e fax, mesmo sem suporte a esses recursos.
public interface IEquipamentoMultifuncional
{
    void Imprimir(string texto);
    void Digitalizar();
    void EnviarFax();
}

public class ImpressoraSimples : IEquipamentoMultifuncional
{
    public void Imprimir(string texto) => Console.WriteLine($"Imprimindo: {texto}");
    public void Digitalizar() => throw new NotSupportedException("Sem scanner.");
    public void EnviarFax() => throw new NotSupportedException("Sem fax.");
}

public static class Program
{
    public static void Main()
    {
        IEquipamentoMultifuncional equipamento = new ImpressoraSimples();
        equipamento.Imprimir("Relatório");
        try
        {
            equipamento.Digitalizar(); // O contrato permite, mas a classe não suporta.
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine($"Falha ao usar a interface: {ex.Message}");
        }
    }
}
