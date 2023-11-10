using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japaes2K
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciar um usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            // Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if (resultado.Rows.Count == 1)
            {
                // Senha correta: Prosseguir..
            }
            else
            {
                //Senha incorreta:
                MessageBox.Show("Email ou Senha incorretos!", "Erro", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
