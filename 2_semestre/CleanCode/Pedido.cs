using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class Pedido
    {
        public Guid Id { get; set; }
        public List<int> Itens { get; set; }

        public decimal Amount { get; set; }

        public Pedido()
        {
            Itens.ForEach(x => x.)
        }
    }
}
