using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Pedidos_e_Clientes
{
    class ItemPedido
    {
        public Produto produto { get; set; }
        public int Quantidade { get; set; }
        public decimal CalcSubTotal()
        {
            return produto.preco * Quantidade;
        }
    }
}
