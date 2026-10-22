using System;

var calculadora = new CalculadoraPedido();
var repositorio = new RepositorioPedidoConsole();
var notificador = new NotificadorEmailConsole();

var processador = new ProcessadorPedido(calculadora, repositorio, notificador);
processador.Processar(new[] { 100m, 40m, 60m }, "cliente@exemplo.com");
