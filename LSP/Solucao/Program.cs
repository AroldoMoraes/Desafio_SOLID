using System;

// Ambas as implementações atendem ao contrato de IForma.
ExibirArea(new Retangulo(5, 4));
ExibirArea(new Quadrado(4));

static void ExibirArea(IForma forma) =>
    Console.WriteLine($"{forma.GetType().Name}: área = {forma.CalcularArea()}");
