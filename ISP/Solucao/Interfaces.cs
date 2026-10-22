// Interfaces pequenas: clientes dependem só dos recursos necessários.
public interface IImpressora
{
    void Imprimir(string texto);
}

public interface IDigitalizadora
{
    void Digitalizar();
}

public interface IFax
{
    void EnviarFax();
}
