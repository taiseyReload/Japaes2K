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
    public partial class MenuPrincipal : Form
    {
        // Objetos globais:
        Classes.Usuario usuario = new Classes.Usuario();
        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();


            // Atribuir o usuário local no global:
            this.usuario = usuario;

            // Mudar a label de apresentação:
            lblBoasVindas.Text = "Olá " + usuario.NomeCompleto + "! Por favor, selecione uma opção:";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // Instanciar a janela:
            Views.GerenciamentoProdutos janela = new Views.GerenciamentoProdutos(usuario);
            janela.Show();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoComandas janela = new Views.GerenciamentoComandas(usuario);
            janela.Show();
        }
    }
}
