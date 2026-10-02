using System;

namespace EcommerceCheckout.App
{
    public class PedidoService
    {
        // 1. Retorna a região em maiúsculas com o número do pedido preenchido com zeros à esquerda (4 dígitos)
        public string GerarCodigoRastreio(string regiao, int numeroPedido)
        {
            return $"{regiao.ToUpper()}-{numeroPedido:D4}";
        }

        // 2. Para cada R$ 10 em compras, o cliente ganha 2 pontos de fidelidade
        public int CalcularPontosFidelidade(int valorTotal)
        {
            return (valorTotal / 10) * 2;
        }

        // 3. O frete é grátis se o valor total for maior ou igual a R$ 200 OU se o comprador for um cliente VIP
        public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
        {
            return valorTotal >= 200 || eClienteVIP;
        }
    }
}