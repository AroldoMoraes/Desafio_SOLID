using System;

var servicoEmail = new ServicoAlertas(new NotificadorEmail());
servicoEmail.Avisar("Pedido aprovado!");

// Troca por outra implementação sem modificar ServicoAlertas.
var servicoSms = new ServicoAlertas(new NotificadorSms());
servicoSms.Avisar("Entrega a caminho!");

// Prova de testabilidade: implementação de teste sem serviço externo.
var teste = new NotificadorMemoria();
new ServicoAlertas(teste).Avisar("Teste de DIP");
Console.WriteLine($"Mensagem capturada no teste: {teste.Mensagens[0]}");
