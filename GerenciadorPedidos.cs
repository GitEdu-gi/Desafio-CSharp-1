using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Pedidos_e_Clientes
{
    class GerenciadorPedidos
    {
        public List<Pedido> pedidos { get; set; }
        public void RegistrarPedido(Pedido pedido)
        {
            if(pedido == null)
            {
                throw new ArgumentNullException("O pedido não pode ser nulo");
            }
            if (pedido.Client != null && pedido.Data != null && pedido.IDPedido != null && pedido.itemsPedidos != null)
            {
                pedidos.Add(pedido);
            }
            else
            {
                throw new InvalidOperationException("Pedido não foi configurado");
            }

        }
        public decimal ObterTotalVendidoPorCliente(int clientid)
        {
            decimal total = pedidos.Where(p => p.Client.ClientId == clientid).Sum(p => p.CalcularTotalPedido());
            return total;
        }
        public void ListarItemsDoPedido(int clientid)
        {
            Pedido Pedido = pedidos.FirstOrDefault(p => p.Client.ClientId == clientid);
            StringBuilder criado = new StringBuilder();
            foreach (ItemPedido aa in Pedido.itemsPedidos)
            {
                criado.Append(" " + aa.produto.nome);
            }
            Console.WriteLine($"O cliente {Pedido.Client.ClientId} comprou {criado.ToString()} ");

        }
       
        
    }
}
