using System;

var calculadora = new CalculadoraPrecoFinal();

// O código da calculadora não muda quando surge uma nova política.
Exibir("Comum", new DescontoComum());
Exibir("Premium", new DescontoPremium());
Exibir("VIP", new DescontoVip());
Exibir("Campanha 15%", new DescontoCampanha());

void Exibir(string categoria, IPoliticaDesconto politica)
{
    Console.WriteLine($"{categoria}: R$ {calculadora.Calcular(200m, politica):F2}");
}
