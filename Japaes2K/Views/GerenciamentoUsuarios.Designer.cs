namespace Japaes2K.Views
{
    partial class GerenciamentoUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbEdSenha = new System.Windows.Forms.TextBox();
            this.txbEdEmail = new System.Windows.Forms.TextBox();
            this.txbEdNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEdSenha = new System.Windows.Forms.Label();
            this.lblEdEmail = new System.Windows.Forms.Label();
            this.lblEdNomeCompleto = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 60);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(468, 230);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.Gray;
            this.grbEditar.Controls.Add(this.txbEdSenha);
            this.grbEditar.Controls.Add(this.txbEdEmail);
            this.grbEditar.Controls.Add(this.txbEdNomeCompleto);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblEdSenha);
            this.grbEditar.Controls.Add(this.lblEdEmail);
            this.grbEditar.Controls.Add(this.lblEdNomeCompleto);
            this.grbEditar.Enabled = false;
            this.grbEditar.ForeColor = System.Drawing.Color.White;
            this.grbEditar.Location = new System.Drawing.Point(252, 296);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(228, 157);
            this.grbEditar.TabIndex = 1;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // txbEdSenha
            // 
            this.txbEdSenha.Location = new System.Drawing.Point(97, 86);
            this.txbEdSenha.Name = "txbEdSenha";
            this.txbEdSenha.Size = new System.Drawing.Size(100, 20);
            this.txbEdSenha.TabIndex = 7;
            // 
            // txbEdEmail
            // 
            this.txbEdEmail.Location = new System.Drawing.Point(97, 55);
            this.txbEdEmail.Name = "txbEdEmail";
            this.txbEdEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEdEmail.TabIndex = 6;
            // 
            // txbEdNomeCompleto
            // 
            this.txbEdNomeCompleto.Location = new System.Drawing.Point(97, 24);
            this.txbEdNomeCompleto.Name = "txbEdNomeCompleto";
            this.txbEdNomeCompleto.Size = new System.Drawing.Size(100, 20);
            this.txbEdNomeCompleto.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(6, 116);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(216, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEdSenha
            // 
            this.lblEdSenha.AutoSize = true;
            this.lblEdSenha.Location = new System.Drawing.Point(21, 89);
            this.lblEdSenha.Name = "lblEdSenha";
            this.lblEdSenha.Size = new System.Drawing.Size(70, 13);
            this.lblEdSenha.TabIndex = 3;
            this.lblEdSenha.Text = "Nova Senha:";
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Location = new System.Drawing.Point(56, 55);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEdEmail.TabIndex = 2;
            this.lblEdEmail.Text = "Email:";
            // 
            // lblEdNomeCompleto
            // 
            this.lblEdNomeCompleto.AutoSize = true;
            this.lblEdNomeCompleto.Location = new System.Drawing.Point(6, 27);
            this.lblEdNomeCompleto.Name = "lblEdNomeCompleto";
            this.lblEdNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblEdNomeCompleto.TabIndex = 1;
            this.lblEdNomeCompleto.Text = "Nome Completo:";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbSenha);
            this.grbCadastro.Controls.Add(this.txbEmail);
            this.grbCadastro.Controls.Add(this.txbNomeCompleto);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.lblNomeCompleto);
            this.grbCadastro.ForeColor = System.Drawing.Color.White;
            this.grbCadastro.Location = new System.Drawing.Point(12, 296);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(234, 157);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastrar:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(97, 86);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 6;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(97, 55);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // txbNomeCompleto
            // 
            this.txbNomeCompleto.Location = new System.Drawing.Point(97, 24);
            this.txbNomeCompleto.Name = "txbNomeCompleto";
            this.txbNomeCompleto.Size = new System.Drawing.Size(100, 20);
            this.txbNomeCompleto.TabIndex = 4;
            this.txbNomeCompleto.TextChanged += new System.EventHandler(this.txbNomeCompleto_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(6, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(222, 35);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(47, 89);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 27);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.Gray;
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.ForeColor = System.Drawing.Color.White;
            this.grbApagar.Location = new System.Drawing.Point(81, 459);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(399, 63);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Firebrick;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(314, 13);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(79, 44);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(23, 30);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(207, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(447, 45);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Gerenciamento de Usuários";
            // 
            // pibUsuarios
            // 
            this.pibUsuarios.Image = global::Japaes2K.Properties.Resources.people_icon;
            this.pibUsuarios.Location = new System.Drawing.Point(13, 459);
            this.pibUsuarios.Name = "pibUsuarios";
            this.pibUsuarios.Size = new System.Drawing.Size(62, 63);
            this.pibUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibUsuarios.TabIndex = 4;
            this.pibUsuarios.TabStop = false;
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 524);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibUsuarios);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GerenciamentoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbNomeCompleto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txbEdSenha;
        private System.Windows.Forms.TextBox txbEdEmail;
        private System.Windows.Forms.TextBox txbEdNomeCompleto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEdSenha;
        private System.Windows.Forms.Label lblEdEmail;
        private System.Windows.Forms.Label lblEdNomeCompleto;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.PictureBox pibUsuarios;
        private System.Windows.Forms.Label lblTitulo;
    }
}