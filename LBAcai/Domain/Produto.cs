using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBAcai.Domain
{
    public class Produto
    {


        public int Id { get; set; }

        public string Ean { get; set; }
        
        public string Nome { get; set; }
        
        public string Observacao { get; set; }

        public Double Estoque { get; set; }

        public Decimal Preco { get; set; }
        
    }
}
