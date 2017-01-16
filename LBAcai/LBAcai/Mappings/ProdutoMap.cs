using LBAcai.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace LBAcai.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("TblProduto");

            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            
            Property(x => x.Observacao)
                .HasMaxLength(100);
 
            Property(x => x.Preco)
                .IsRequired();


        }
    }
}
