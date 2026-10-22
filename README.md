# Projeto SOLID — C# / .NET 8

Projeto educacional que demonstra **violações e correções dos cinco princípios SOLID**.
Cada exemplo é uma aplicação console independente e executável.

## Estrutura exigida

```text
Projeto_SOLID_CSharp/
├── SRP/
│   ├── Violacao/
│   └── Solucao/
├── OCP/
│   ├── Violacao/
│   └── Solucao/
├── LSP/
│   ├── Violacao/
│   └── Solucao/
├── ISP/
│   ├── Violacao/
│   └── Solucao/
├── DIP/
│   ├── Violacao/
│   └── Solucao/
├── Projeto_SOLID.sln
└── README.md
```

Cada subpasta `Violacao` e `Solucao` possui o próprio `Program.cs` e arquivo `.csproj`.
As soluções também possuem classes e interfaces separadas em arquivos próprios.

## Requisitos e execução

- Instalar o **SDK do .NET 8** (ou SDK compatível com projetos `net8.0`).
- Abrir `Projeto_SOLID.sln` no Visual Studio 2022 ou abrir a pasta no VS Code.
- Ou executar no terminal, a partir da raiz do projeto:

```powershell
dotnet run --project SRP/Violacao/SOLID.SRP.Violacao.csproj
dotnet run --project SRP/Solucao/SOLID.SRP.Solucao.csproj

dotnet run --project OCP/Violacao/SOLID.OCP.Violacao.csproj
dotnet run --project OCP/Solucao/SOLID.OCP.Solucao.csproj

dotnet run --project LSP/Violacao/SOLID.LSP.Violacao.csproj
dotnet run --project LSP/Solucao/SOLID.LSP.Solucao.csproj

dotnet run --project ISP/Violacao/SOLID.ISP.Violacao.csproj
dotnet run --project ISP/Solucao/SOLID.ISP.Solucao.csproj

dotnet run --project DIP/Violacao/SOLID.DIP.Violacao.csproj
dotnet run --project DIP/Solucao/SOLID.DIP.Solucao.csproj
```

> Os projetos `Violacao` mostram conscientemente um mau projeto de classes; os projetos
> `Solucao` demonstram a refatoração correspondente. Todas as operações de banco,
> e-mail e SMS são **simulações em console**; não usam serviços externos.

## 1. SRP — Single Responsibility Principle

**Definição:** uma classe deve ter um único motivo para mudar.

- **Violação:** `PedidoService` faz cálculos, salva pedidos e envia notificações.
- **Solução:** `CalculadoraPedido` calcula; `RepositorioPedidoConsole` simula a persistência;
  `NotificadorEmailConsole` simula a notificação; `ProcessadorPedido` coordena o caso de uso.
- **Benefício:** é possível alterar persistência ou notificação sem mexer na regra de cálculo.
- **Resultado esperado:** total R$ 200,00, seguido de mensagens de salvamento e notificação.

## 2. OCP — Open/Closed Principle

**Definição:** módulos devem ser abertos para extensão e fechados para modificação.

- **Violação:** `CalculadoraDesconto` usa `if/else` por tipo de cliente; adicionar um tipo exige
  modificar seu código.
- **Solução:** `IPoliticaDesconto` define um contrato para políticas independentes.
  `CalculadoraPrecoFinal` opera sobre esse contrato. `DescontoCampanha` exemplifica uma extensão.
- **Benefício:** introduzir descontos novos sem alterar a calculadora.
- **Resultado esperado:** preço base R$ 200,00; comum R$ 200,00, premium R$ 180,00,
  VIP R$ 160,00 e campanha R$ 170,00.

## 3. LSP — Liskov Substitution Principle

**Definição:** uma implementação substituta deve respeitar as expectativas do contrato base.

- **Violação:** `Quadrado : Retangulo` altera largura e altura conjuntamente.
  O código que supõe dimensões independentes define 5 × 4 e obtém área 16, não 20.
- **Solução:** `Retangulo` e `Quadrado` implementam `IForma`, que oferece somente `CalcularArea()`;
  não há promessa de que largura e altura sejam ajustáveis separadamente.
- **Benefício:** qualquer `IForma` pode ser usado por `ExibirArea` sem quebrar o contrato.
- **Resultado esperado:** violação imprime 20 para retângulo e 16 para quadrado;
  solução imprime 20 e 16 para duas formas válidas distintas.

## 4. ISP — Interface Segregation Principle

**Definição:** nenhuma classe deve ser obrigada a depender de métodos que não utiliza.

- **Violação:** `ImpressoraSimples` implementa impressão, scanner e fax,
  mas lança `NotSupportedException` nos métodos que não suporta.
- **Solução:** interfaces `IImpressora`, `IDigitalizadora` e `IFax` independentes.
  A impressora simples implementa só a primeira; a multifuncional implementa as três.
- **Benefício:** contratos menores, coerentes com as capacidades reais do dispositivo.
- **Resultado esperado:** violação exibe erro capturado de digitalização;
  solução executa impressão, digitalização e fax sem erros.

## 5. DIP — Dependency Inversion Principle

**Definição:** regras de alto nível não devem depender diretamente de classes de baixo nível;
ambas devem depender de abstrações.

- **Violação:** `ServicoAlertas` instancia diretamente `NotificadorEmail`.
- **Solução:** `ServicoAlertas` recebe `INotificador` via construtor, podendo funcionar
  com e-mail, SMS ou um notificador em memória para testes.
- **Benefício:** menor acoplamento e testes mais fáceis.
- **Resultado esperado:** notificações simuladas por e-mail e SMS e mensagem capturada em memória.

## Observações técnicas

- As classes estão separadas por subprojetos para evitar colisões de nomes entre exemplos.
- A pasta `Solucao` refatora a mesma ideia ilustrada pela pasta `Violacao`.
- Nenhuma dependência NuGet de terceiros é necessária.
- O projeto foi estruturado para o SDK do .NET 8. Os exemplos de console não requerem
  configuração de banco de dados nem credenciais.
