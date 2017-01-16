namespace LBAcai
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.TBPrecoAvista = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Celular});
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 217);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(126, 360);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 26);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(31, 360);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(89, 26);
            this.BtnIncluir.TabIndex = 42;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(608, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 26);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.Location = new System.Drawing.Point(513, 360);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(89, 26);
            this.BtnConfirmar.TabIndex = 40;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.TBPrecoAvista);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TBMarca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBDescricao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 108);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro do Produto";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(529, 35);
            this.maskedTextBox1.Mask = "00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(161, 20);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // TBPrecoAvista
            // 
            this.TBPrecoAvista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPrecoAvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecoAvista.Location = new System.Drawing.Point(529, 74);
            this.TBPrecoAvista.MaxLength = 8;
            this.TBPrecoAvista.Name = "TBPrecoAvista";
            this.TBPrecoAvista.Size = new System.Drawing.Size(161, 23);
            this.TBPrecoAvista.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefone Celular";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TBMarca
            // 
            this.TBMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMarca.Location = new System.Drawing.Point(28, 74);
            this.TBMarca.MaxLength = 60;
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(421, 23);
            this.TBMarca.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observacao";
            // 
            // TBDescricao
            // 
            this.TBDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescricao.Location = new System.Drawing.Point(83, 32);
            this.TBDescricao.MaxLength = 60;
            this.TBDescricao.Name = "TBDescricao";
            this.TBDescricao.Size = new System.Drawing.Size(366, 23);
            this.TBDescricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome";
            // 
            // TBCodigo
            // 
            this.TBCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo.Location = new System.Drawing.Point(28, 32);
            this.TBCodigo.MaxLength = 13;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(49, 23);
            this.TBCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefone Fixo";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Nome";
            this.Descricao.HeaderText = "Nome";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 480;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Celular.DefaultCellStyle = dataGridViewCellStyle1;
            this.Celular.HeaderText = "Tel. Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 130;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TBPrecoAvista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}