using LBAcai.DataContext;
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

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
}
}