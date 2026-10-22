public class Retangulo : IForma
{
    public int Largura { get; }
    public int Altura { get; }

    public Retangulo(int largura, int altura)
    {
        if (largura <= 0 || altura <= 0)
            throw new ArgumentOutOfRangeException(nameof(largura), "Medidas devem ser positivas.");
        Largura = largura;
        Altura = altura;
    }

    public int CalcularArea() => Largura * Altura;
}
