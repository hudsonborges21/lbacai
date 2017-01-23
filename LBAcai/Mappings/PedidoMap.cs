using LBAcai.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace LBAcai.Mappings
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
         public PedidoMap()
        {
            ToTable("TblPedido");

            HasKey(x => x.Id);

            Property(x => x.CodCliente)
                .HasMaxLength(6)
                .IsRequired();

            
            Property(x => x.Observacao)
                .HasMaxLength(100);
 
            Property(x => x.Data)
                .IsRequired();

            Property(x => x.Desconto);

            Property(x => x.Valor);

        }
            

    }
}
