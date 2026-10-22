using System;
using System.Linq;

// VIOLAÇÃO DO SRP: esta classe calcula, persiste e notifica.
// Três motivos distintos podem exigir alterações nela.
public class PedidoService
{
    public void Processar(decimal[] precos, string emailCliente)
    {
        decimal total = precos.Sum(); // Regra de negócio
        Console.WriteLine($"Total calculado: R$ {total:F2}");

        Console.WriteLine($"Pedido de R$ {total:F2} salvo no banco (simulação)."); // Persistência
        Console.WriteLine($"E-mail enviado para {emailCliente} (simulação)."); // Notificação
    }
}

public static class Program
{
    public static void Main()
    {
        new PedidoService().Processar(new[] { 100m, 40m, 60m }, "cliente@exemplo.com");
    }
}
