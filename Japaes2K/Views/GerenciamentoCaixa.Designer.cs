namespace Japaes2K.Views
{
    partial class GerenciamentoCaixa
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
            this.lblNComanda = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblReais = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbConfirmacao = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcon = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNComanda
            // 
            this.lblNComanda.AutoSize = true;
            this.lblNComanda.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComanda.ForeColor = System.Drawing.Color.White;
            this.lblNComanda.Location = new System.Drawing.Point(45, 69);
            this.lblNComanda.Name = "lblNComanda";
            this.lblNComanda.Size = new System.Drawing.Size(211, 37);
            this.lblNComanda.TabIndex = 0;
            this.lblNComanda.Text = "N°COMANDA:";
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(12, 123);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(674, 203);
            this.dgvCaixa.TabIndex = 1;
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(262, 64);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(145, 42);
            this.txbComanda.TabIndex = 3;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReais.ForeColor = System.Drawing.Color.White;
            this.lblReais.Location = new System.Drawing.Point(462, 350);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(54, 33);
            this.lblReais.TabIndex = 4;
            this.lblReais.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(507, 350);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 33);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0,00";
            // 
            // chbConfirmacao
            // 
            this.chbConfirmacao.AutoSize = true;
            this.chbConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConfirmacao.ForeColor = System.Drawing.Color.White;
            this.chbConfirmacao.Location = new System.Drawing.Point(468, 397);
            this.chbConfirmacao.Name = "chbConfirmacao";
            this.chbConfirmacao.Size = new System.Drawing.Size(218, 24);
            this.chbConfirmacao.TabIndex = 6;
            this.chbConfirmacao.Text = "PAGAMENTO RECEBIDO";
            this.chbConfirmacao.UseVisualStyleBackColor = true;
            this.chbConfirmacao.CheckedChanged += new System.EventHandler(this.chbConfirmacao_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(468, 432);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(218, 40);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTitulo.Location = new System.Drawing.Point(223, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 42);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "CAIXA: JAPÃES";
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::Japaes2K.Properties.Resources._3321014;
            this.pibIcon.Location = new System.Drawing.Point(12, 332);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(136, 140);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibIcon.TabIndex = 9;
            this.pibIcon.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(413, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(703, 484);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbConfirmacao);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.lblNComanda);
            this.Name = "GerenciamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento do Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNComanda;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbConfirmacao;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcon;
        private System.Windows.Forms.Button btnBuscar;
    }
}