using LBAcai.DataContext;
using LBAcai.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LBAcai
{
    public partial class FrmPedido : Form
    {
        Boolean incluindo;
        public FrmPedido()
        {
            InitializeComponent();
        }


        private void CarregarDados(){
            
           
            using (MyDataContext db = new MyDataContext())
            {
                var c = from pdd in db.Pedidos
                          select new
                          {
                              id = pdd.Id,
                              Cliente = pdd.CodCliente,
                              Data = pdd.Data,
                              Observacao = pdd.Observacao,
                              Desconto = pdd.Desconto,
                              Valor = pdd.Valor,

                          };
                dataGridView1.DataSource = c.ToList();
                db.Dispose();
            }
            
    }

        private void GravarDados()
         {
             try
             {
                 
                 //obj para gravar no banco de dados
                 MyDataContext db = new MyDataContext();
                 if (incluindo)
                 {

                     var pd = new Pedido
                     {
                         CodCliente = "1",
                         Desconto = 0,
                         Valor  = 0,
                         Data = DateTime.Now.ToString("dd/MM/yyyy"),
                         Observacao = "",
                         
                     };

                     db.Pedidos.Add(pd);

                 }
                 
                 db.SaveChanges(); // aqui que grava
                 db.Dispose(); // fecha banco dados


                 incluindo = false;
                 CarregarDados();
                

             }
             catch (Exception)
             {
                 MessageBox.Show("Erro ao salvar o registro.");
                 //throw;
             }

        }

        private void ExcluirDados()
        {
            try
            {
                //obj para gravar no banco de dados
                MyDataContext db = new MyDataContext();

                //Recupera os Dados
                int CodEdit = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                
                var contoso = db.Pedidos
                    .Where(x => x.Id == CodEdit).FirstOrDefault();

                db.Pedidos.Remove(contoso);
                db.SaveChanges();
                db.Dispose();
                CarregarDados();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Excluir registro.");
            }
            

        }    
     

            private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void FrmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                incluindo = true;
                GravarDados();


                FrmPedidoItem frm = new FrmPedidoItem();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F5)
            {
                ExcluirDados();
            }
        }
}
}