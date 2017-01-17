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
    public partial class FrmCliente : Form
    {
        Boolean incluindo;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CarregarDados(){
            
           
            using (MyDataContext db = new MyDataContext())
            {
                var c = from clt in db.Clientes
                          select new
                          {
                              id = clt.Id,
                              Nome = clt.Nome,
                              Celular = clt.TelefoneCelular,

                          };
                dataGridView1.DataSource = c.ToList();
                db.Dispose();
            }
            Habilitar();

        }

        

         private void Habilitar()
        {
            BtnIncluir.Enabled = true;
            btnExcluir.Enabled = true;
            BtnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

        }
         private void Desabilitar()
         {
             BtnIncluir.Enabled = false;
             btnExcluir.Enabled = false;
             BtnConfirmar.Enabled = true;
             btnCancelar.Enabled = true;

         }
         public void limparTextBoxes(Control controles)
         {
             foreach (Control ctrl in controles.Controls)
             {
                 if (ctrl is TextBox)
                 {
                     ((TextBox)(ctrl)).Text = String.Empty;
                 }
                 else if (ctrl.Controls.Count > 0)
                 {
                     limparTextBoxes(ctrl);
                 }
             }
         }

         private void BtnIncluir_Click(object sender, EventArgs e)
         {
             incluindo = true; //variavel para incluir
             limparTextBoxes(this);//limpado
             TBDescricao.Focus();
             Desabilitar();
         }

         private void btnExcluir_Click(object sender, EventArgs e)
         {
             try
             {
                 //obj para gravar no banco de dados
                 MyDataContext db = new MyDataContext();

                 //Recupera os Dados
                 int CodEdit = Convert.ToInt16(TBCodigo.Text);
                 var contoso = db.Clientes
                     .Where(x => x.Id == CodEdit).FirstOrDefault();

                 db.Clientes.Remove(contoso);
                 db.SaveChanges();
                 db.Dispose();

                 limparTextBoxes(this);
                 CarregarDados();

             }
             catch (Exception)
             {
                 MessageBox.Show("Erro ao Excluir o registro.");
                 
             }


         }

         private void BtnConfirmar_Click(object sender, EventArgs e)
         {
             try
             {
                 if (string.IsNullOrEmpty(TBDescricao.Text))
                 {
                     TBDescricao.Text = " ";
                 }
                 else
                 {
                     string valor = Convert.ToString(TBDescricao.Text);
                 }

                 //obj para gravar no banco de dados
                 MyDataContext db = new MyDataContext();
                 if (incluindo)
                 {

                     var Cli = new Cliente
                     {
                         Nome = TBDescricao.Text,
                         Observacao = TBMarca.Text,
                         TelefoneCelular = MTelCelular.Text,
                         TelefoneFixo = MTelFixo.Text,

                     };
                     db.Clientes.Add(Cli); //gravar no banco - status

                 }
                 else
                 {

                     //Recupera os Dados
                     int CodEdit = Convert.ToInt16(TBCodigo.Text);
                     var contoso = db.Clientes
                         .Where(x => x.Id == CodEdit).FirstOrDefault();


                     contoso.Nome = TBDescricao.Text;
                     contoso.Observacao = TBMarca.Text;
                     contoso.TelefoneFixo = MTelFixo.Text;
                     contoso.TelefoneCelular = MTelCelular.Text;

                     //Edita 
                     db.Entry<Cliente>(contoso).State =
                          System.Data.Entity.EntityState.Modified; // grava no banco -stats

                 }

                 db.SaveChanges(); // aqui que grava
                 db.Dispose(); // fecha banco dados


                 incluindo = false;
                 CarregarDados();
                 Habilitar();

             }
             catch (Exception)
             {
                 MessageBox.Show("Erro ao salver o registro.");
                 //throw;
             }
         }

         private void TBDescricao_KeyPress(object sender, KeyPressEventArgs e)
         {
             Desabilitar();
         }

         private void MTelCelular_KeyPress(object sender, KeyPressEventArgs e)
         {
             Desabilitar();
         }

         private void TBMarca_KeyPress(object sender, KeyPressEventArgs e)
         {
             Desabilitar();
         }

         private void MTelFixo_KeyPress(object sender, KeyPressEventArgs e)
         {
             Desabilitar();
         }

         private void FrmCliente_Load(object sender, EventArgs e)
         {
             CarregarDados();
         }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             int CodEdit = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

             MyDataContext db = new MyDataContext();

             var contoso = db.Clientes
                 .Where(x => x.Id == CodEdit).FirstOrDefault();

             TBCodigo.Text = Convert.ToString(contoso.Id);
             TBDescricao.Text = contoso.Nome;
             TBMarca.Text = contoso.Observacao;
             MTelCelular.Text = contoso.TelefoneCelular;
             MTelFixo.Text = contoso.TelefoneFixo;

             db.Dispose();
         }


    }
}
