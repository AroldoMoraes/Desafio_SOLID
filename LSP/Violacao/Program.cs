using System;

// VIOLAÇÃO DO LSP: um Quadrado não respeita o comportamento
// de largura e altura independentes prometido por Retangulo.
public class Retangulo
{
    public virtual int Largura { get; set; }
    public virtual int Altura { get; set; }
    public int Area => Largura * Altura;
}

public class Quadrado : Retangulo
{
    public override int Largura
    {
        get => base.Largura;
        set { base.Largura = value; base.Altura = value; }
    }

    public override int Altura
    {
        get => base.Altura;
        set { base.Altura = value; base.Largura = value; }
    }
}

public static class Program
{
    private static void TestarRetangulo(Retangulo forma)
    {
        forma.Largura = 5;
        forma.Altura = 4;
        Console.WriteLine($"Área esperada: 20; área obtida: {forma.Area}");
        Console.WriteLine(forma.Area == 20 ? "Contrato preservado." : "Contrato violado!");
    }

    public static void Main()
    {
        Console.WriteLine("Retângulo:");
        TestarRetangulo(new Retangulo());
        Console.WriteLine("Quadrado usado no lugar de Retângulo:");
        TestarRetangulo(new Quadrado());
    }
}
