namespace Japaes2K.Views
{
    partial class GerenciamentoProdutos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblEdNome = new System.Windows.Forms.Label();
            this.lblEdPreco = new System.Windows.Forms.Label();
            this.lblEdCategoria = new System.Windows.Forms.Label();
            this.txbEdNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(554, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 84);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(554, 246);
            this.dgvProdutos.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Japaes2K.Properties.Resources._1312307;
            this.pictureBox1.Location = new System.Drawing.Point(20, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbCategoria);
            this.grbCadastrar.Controls.Add(this.txbPreco);
            this.grbCadastrar.Controls.Add(this.txbNome);
            this.grbCadastrar.Controls.Add(this.lblCategoria);
            this.grbCadastrar.Controls.Add(this.lblPreco);
            this.grbCadastrar.Controls.Add(this.lblNome);
            this.grbCadastrar.ForeColor = System.Drawing.Color.White;
            this.grbCadastrar.Location = new System.Drawing.Point(20, 336);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(255, 142);
            this.grbCadastrar.TabIndex = 3;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbEdNome);
            this.grbEditar.Controls.Add(this.lblEdCategoria);
            this.grbEditar.Controls.Add(this.lblEdPreco);
            this.grbEditar.Controls.Add(this.lblEdNome);
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(295, 336);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(252, 142);
            this.grbEditar.TabIndex = 4;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(61, 70);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(44, 106);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(106, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(106, 67);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(100, 20);
            this.txbPreco.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(106, 103);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // grbApagar
            // 
            this.grbApagar.ForeColor = System.Drawing.Color.White;
            this.grbApagar.Location = new System.Drawing.Point(98, 484);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(449, 60);
            this.grbApagar.TabIndex = 5;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar:";
            // 
            // lblEdNome
            // 
            this.lblEdNome.AutoSize = true;
            this.lblEdNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdNome.Location = new System.Drawing.Point(6, 31);
            this.lblEdNome.Name = "lblEdNome";
            this.lblEdNome.Size = new System.Drawing.Size(93, 13);
            this.lblEdNome.TabIndex = 1;
            this.lblEdNome.Text = "Nome do Produto:";
            // 
            // lblEdPreco
            // 
            this.lblEdPreco.AutoSize = true;
            this.lblEdPreco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEdPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdPreco.Location = new System.Drawing.Point(61, 70);
            this.lblEdPreco.Name = "lblEdPreco";
            this.lblEdPreco.Size = new System.Drawing.Size(38, 13);
            this.lblEdPreco.TabIndex = 2;
            this.lblEdPreco.Text = "Preço:";
            // 
            // lblEdCategoria
            // 
            this.lblEdCategoria.AutoSize = true;
            this.lblEdCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdCategoria.Location = new System.Drawing.Point(44, 106);
            this.lblEdCategoria.Name = "lblEdCategoria";
            this.lblEdCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblEdCategoria.TabIndex = 3;
            this.lblEdCategoria.Text = "Categoria:";
            // 
            // txbEdNome
            // 
            this.txbEdNome.Location = new System.Drawing.Point(105, 31);
            this.txbEdNome.Name = "txbEdNome";
            this.txbEdNome.Size = new System.Drawing.Size(100, 20);
            this.txbEdNome.TabIndex = 4;
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(578, 556);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblEdCategoria;
        private System.Windows.Forms.Label lblEdPreco;
        private System.Windows.Forms.Label lblEdNome;
        private System.Windows.Forms.TextBox txbEdNome;
    }
}