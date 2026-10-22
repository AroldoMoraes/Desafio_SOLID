public class Multifuncional : IImpressora, IDigitalizadora, IFax
{
    public void Imprimir(string texto) => Console.WriteLine($"Multifuncional imprimindo: {texto}");
    public void Digitalizar() => Console.WriteLine("Multifuncional digitalizando.");
    public void EnviarFax() => Console.WriteLine("Multifuncional enviando fax.");
}
