public class Quadrado : IForma
{
    public int Lado { get; }

    public Quadrado(int lado)
    {
        if (lado <= 0)
            throw new ArgumentOutOfRangeException(nameof(lado), "O lado deve ser positivo.");
        Lado = lado;
    }

    public int CalcularArea() => Lado * Lado;
}
