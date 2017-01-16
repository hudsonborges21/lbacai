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
    public partial class FrmProduto : Form
    {
        Boolean incluindo;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            using (MyDataContext db = new MyDataContext())
            {
                var crt = from cart in db.Produtos
                          select new
                          {
                              id = cart.Id,
                              Nome = cart.Nome,
                              Preco = cart.Preco,

                          };
                dataGridView1.DataSource = crt.ToList();
                db.Dispose();
            }
            Habilitar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodEdit = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            MyDataContext db = new MyDataContext();

            var contoso = db.Produtos
                .Where(x => x.Id == CodEdit).FirstOrDefault();

            TBCodigo.Text = Convert.ToString(contoso.Id);
            TBDescricao.Text = contoso.Nome;
            TBMarca.Text = contoso.Observacao;
            TBPrecoAvista.Text = Convert.ToString(contoso.Preco);
            
            db.Dispose();
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
            //obj para gravar no banco de dados
            MyDataContext db = new MyDataContext();

            //Recupera os Dados
            int CodEdit = Convert.ToInt16(TBCodigo.Text);
            var contoso = db.Produtos
                .Where(x => x.Id == CodEdit).FirstOrDefault();

            db.Produtos.Remove(contoso);
            db.SaveChanges();
            db.Dispose();

            limparTextBoxes(this);
            atuGrid();
        }

        private void Desabilitar()
        {
            BtnIncluir.Enabled = false;
            btnExcluir.Enabled = false;
            BtnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void atuGrid()
        {
            using (MyDataContext db = new MyDataContext())
            {
                var crt = from cart in db.Produtos
                          select new
                          {
                              id = cart.Id,
                              Nome = cart.Nome,
                              Preco = cart.Preco,

                          };
                dataGridView1.DataSource = crt.ToList();
                db.Dispose();
            }
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

        private void Habilitar()
        {
            BtnIncluir.Enabled = true;
            btnExcluir.Enabled = true;
            BtnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

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
                
                if (string.IsNullOrEmpty(TBPrecoAvista.Text))
                {
                    TBPrecoAvista.Text = "0";
                }
                else
                {
                    double valor = Convert.ToDouble(TBPrecoAvista.Text);
                }

               
                //obj para gravar no banco de dados
                MyDataContext db = new MyDataContext();
                if (incluindo)
                {

                    var prod = new Produto
                    {
                        Nome = TBDescricao.Text,
                        Observacao = TBMarca.Text,
                        Preco = Convert.ToDecimal(TBPrecoAvista.Text),
                        
                    };

                    db.Produtos.Add(prod);
                    
                }
                else
                {

                    //Recupera os Dados
                    int CodEdit = Convert.ToInt16(TBCodigo.Text);
                    var contoso = db.Produtos
                        .Where(x => x.Id == CodEdit).FirstOrDefault();

                    
                    contoso.Nome = TBDescricao.Text;
                    contoso.Observacao = TBMarca.Text;
                    
                    contoso.Preco = 0;
                    if (TBPrecoAvista.Text != "")
                        contoso.Preco = Convert.ToDecimal(TBPrecoAvista.Text);

                    //Edita 
                    db.Entry<Produto>(contoso).State =
                         System.Data.Entity.EntityState.Modified;

                }

                db.SaveChanges(); // aqui que grava
                db.Dispose(); // fecha banco dados

                
                incluindo = false;
                atuGrid();
                Habilitar();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salver o registro.");
                //throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Recupera os Dados
            int CodEdit = Convert.ToInt16(TBCodigo.Text);

            //obj para gravar no banco de dados
            MyDataContext db = new MyDataContext();

            var contoso = db.Produtos
                .Where(x => x.Id == CodEdit).FirstOrDefault();

            TBCodigo.Text = Convert.ToString(contoso.Id);
            TBDescricao.Text = contoso.Nome;
            TBMarca.Text = contoso.Observacao;
            TBPrecoAvista.Text = Convert.ToString(contoso.Preco);
            
            db.Dispose();
            Habilitar();
        }

        private void TBDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desabilitar();
        }

        private void TBPrecoAvista_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desabilitar();
        }

        private void TBMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desabilitar();
        }
    }
}
