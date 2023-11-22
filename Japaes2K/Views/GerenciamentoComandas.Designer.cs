namespace Japaes2K.Views
{
    partial class GerenciamentoComandas
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
            this.grbInformações = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbProdutoL = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProdutoL = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.grbInformações.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformações
            // 
            this.grbInformações.Controls.Add(this.btnContinuar);
            this.grbInformações.Controls.Add(this.txbProduto);
            this.grbInformações.Controls.Add(this.lblProduto);
            this.grbInformações.Controls.Add(this.txbComanda);
            this.grbInformações.Controls.Add(this.lblComanda);
            this.grbInformações.ForeColor = System.Drawing.Color.White;
            this.grbInformações.Location = new System.Drawing.Point(12, 116);
            this.grbInformações.Name = "grbInformações";
            this.grbInformações.Size = new System.Drawing.Size(231, 222);
            this.grbInformações.TabIndex = 0;
            this.grbInformações.TabStop = false;
            this.grbInformações.Text = "Informações:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.Location = new System.Drawing.Point(10, 160);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(205, 46);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.ForeColor = System.Drawing.Color.Black;
            this.txbProduto.Location = new System.Drawing.Point(115, 110);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(100, 20);
            this.txbProduto.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(8, 113);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(102, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "CÓD PRODUTO:";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(115, 32);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 20);
            this.txbComanda.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(37, 35);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(72, 13);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "COMANDA:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbProdutoL);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.lblProdutoL);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.ForeColor = System.Drawing.Color.White;
            this.grbLancamento.Location = new System.Drawing.Point(12, 344);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(231, 197);
            this.grbLancamento.TabIndex = 1;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento:";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(104, 91);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 6;
            // 
            // txbProdutoL
            // 
            this.txbProdutoL.Location = new System.Drawing.Point(104, 50);
            this.txbProdutoL.Name = "txbProdutoL";
            this.txbProdutoL.Size = new System.Drawing.Size(100, 20);
            this.txbProdutoL.TabIndex = 5;
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.White;
            this.btnLancar.Location = new System.Drawing.Point(10, 128);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(205, 46);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(7, 92);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(91, 16);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProdutoL
            // 
            this.lblProdutoL.AutoSize = true;
            this.lblProdutoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoL.Location = new System.Drawing.Point(33, 51);
            this.lblProdutoL.Name = "lblProdutoL";
            this.lblProdutoL.Size = new System.Drawing.Size(65, 16);
            this.lblProdutoL.TabIndex = 0;
            this.lblProdutoL.Text = "Produto:";
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(249, 74);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(472, 467);
            this.dgvComandas.TabIndex = 2;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTitulo.Location = new System.Drawing.Point(75, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(504, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gerenciamento de Comandas";
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::Japaes2K.Properties.Resources._3930510;
            this.pibIcone.Location = new System.Drawing.Point(598, 8);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(68, 60);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibIcone.TabIndex = 4;
            this.pibIcone.TabStop = false;
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(733, 553);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformações);
            this.Name = "GerenciamentoComandas";
            this.Text = "Gerenciamento de Comandas";
            this.grbInformações.ResumeLayout(false);
            this.grbInformações.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformações;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProdutoL;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProdutoL;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcone;
    }
}