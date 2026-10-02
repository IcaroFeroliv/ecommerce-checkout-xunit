# Ecommerce Checkout - xUnit

Este repositório contém uma solução .NET desenvolvida para gerenciar o cálculo de cupons, itens e frete de uma loja online. O projeto foi construído para demonstrar a implementação de regras de negócio em C# e a respectiva cobertura de testes unitários utilizando o framework xUnit.

## 🛠️ Métodos Implementados

A classe `PedidoService` (no projeto `EcommerceCheckout.App`) contém as seguintes regras de negócio:

1. **`GerarCodigoRastreio(string regiao, int numeroPedido)`**
   - Retorna uma string formatada unindo a região em maiúsculas com o número do pedido preenchido com zeros à esquerda (4 dígitos). Exemplo: `SUDESTE-0042`.

2. **`CalcularPontosFidelidade(int valorTotal)`**
   - Retorna a quantidade de pontos ganhos na compra. Para cada R$ 10 gastos, o cliente recebe 2 pontos de fidelidade.

3. **`TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)`**
   - Retorna um booleano validando a isenção de frete. O frete é grátis se o valor total for maior ou igual a R$ 200, ou se o comprador for um cliente VIP.

## ✅ Cobertura de Testes

O projeto de testes (`EcommerceCheckout.Tests`) cobre os seguintes cenários validando os retornos com `Assert.Equal`, `Assert.True` e `Assert.False`:
- Geração exata da máscara do código de rastreio.
- Cálculo matemático correto para a conversão de valores em pontos de fidelidade.
- Garantia de frete grátis para clientes VIP, mesmo com compras abaixo de R$ 200.
- Cobrança de frete para clientes não-VIP com compras abaixo de R$ 200.

## 🚀 Como Executar os Testes

Certifique-se de ter o SDK do .NET instalado. Abra o terminal na raiz da solução e execute o seguinte comando para rodar toda a suíte de testes:

```bash
dotnet test
