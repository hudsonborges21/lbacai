using LBAcai.Domain;
using LBAcai.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LBAcai.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext()
            : base("MyConnectionString")
        {
            //Database.SetInitializer<MyDataContext>(new Initializer());   
        }

        public DbSet<Produto> Produtos { get; set; }
        

        //usar MAPING PARA CRIAR ESTRUTURA DO BANCO DE DADOS
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProdutoMap());
            
        }
    }
    public class Initializer : DropCreateDatabaseAlways<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            context.Produtos.Add(new Produto { Id = 1, Nome = "AÇAI", Preco = 9 });
            context.Produtos.Add(new Produto { Id = 2, Nome = "LEITE NINHO", Preco = 1 });
            context.Produtos.Add(new Produto { Id = 3, Nome = "LEITE CONDENÇADO", Preco = 1 });
            context.Produtos.Add(new Produto { Id = 1, Nome = "GRANOLA", Preco = 1 });
            context.Produtos.Add(new Produto { Id = 1, Nome = "BANANA", Preco = 1 });
            context.Produtos.Add(new Produto { Id = 1, Nome = "PAÇOCA", Preco = 1 });
            context.Produtos.Add(new Produto { Id = 1, Nome = "BACON", Preco = 1 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
