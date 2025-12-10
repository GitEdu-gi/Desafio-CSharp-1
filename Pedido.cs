using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Pedidos_e_Clientes
{
    class Pedido
    {
        public int IDPedido { get; set; }
        public DateTime Data { get; set; }
        public Cliente Client { get; set; }
        public List<ItemPedido> itemsPedidos { get; set; }
        public void AdicionarPedido(Produto produto, int quantidade)
        {
            ItemPedido item = new ItemPedido();
            item.produto = produto;
            item.Quantidade = quantidade;
            itemsPedidos.Add(item);
        }
        public decimal CalcularTotalPedido()
        {
            decimal value = 0;
            foreach (ItemPedido itemm in itemsPedidos)
            {
                value += itemm.CalcSubTotal();
            }
            return value;
        }
    }
}
