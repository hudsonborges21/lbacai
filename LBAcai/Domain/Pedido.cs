using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBAcai.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public string CodCliente { get; set; }

        public string Data { get; set; }

        public string Observacao { get; set; }

        public Double Desconto { get; set; }
        public Double  Valor{ get; set; }
        
    }
}
