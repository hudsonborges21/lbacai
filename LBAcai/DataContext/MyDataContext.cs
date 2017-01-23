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
         //  Database.SetInitializer<MyDataContext>(new Initializer());   
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        

        //usar MAPING PARA CRIAR ESTRUTURA DO BANCO DE DADOS
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            
        }
    }
    public class Initializer : DropCreateDatabaseAlways<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            context.Produtos.Add(new Produto { Id = 1, Nome = "AÇAI", Preco = 9 });
            context.Produtos.Add(new Produto { Id = 2, Nome = "LEITE NINHO", Preco = 1, Adicional="S" });
            context.Produtos.Add(new Produto { Id = 3, Nome = "LEITE CONDENÇADO", Preco = 1, Adicional = "S" });
            context.Produtos.Add(new Produto { Id = 4, Nome = "GRANOLA", Preco = 1, Adicional = "S" });
            context.Produtos.Add(new Produto { Id = 5, Nome = "BANANA", Preco = 1, Adicional = "S" });
            context.Produtos.Add(new Produto { Id = 6, Nome = "PAÇOCA", Preco = 1, Adicional = "S" });
            context.Produtos.Add(new Produto { Id = 7, Nome = "BACON", Preco = 1, Adicional = "S" });

            context.Clientes.Add(new Cliente { Id = 1, Nome = "HUDSON BORGES SANT ANA" });
            context.Clientes.Add(new Cliente { Id = 2, Nome = "FERNANDA" });
            context.Clientes.Add(new Cliente { Id = 3, Nome = "RAYNE" });
            context.Clientes.Add(new Cliente { Id = 4, Nome = "CLAYTON" });
            context.Clientes.Add(new Cliente { Id = 5, Nome = "MANO" });
            context.Clientes.Add(new Cliente { Id = 6, Nome = "DANILO CARLOS" });

            context.Pedidos.Add(new Pedido { Id = 1, CodCliente = "1", Observacao = "Teste 1", Data = "23/01/2017", Valor = 0, Desconto = 0 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
