using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japaes2K.Views
{
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos globais:
        int idSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void txbNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void GerenciamentoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            // Obter os valores dos campos:
            usuario.NomeCompleto = txbNomeCompleto.Text;
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCompleto.Clear();
                txbEmail.Clear();
                txbSenha.Clear();
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o usuário.");
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            // Preencher os campos:
            txbEdNomeCompleto.Text = linha.Cells[1].Value.ToString();
            txbEdEmail.Text = linha.Cells[2].Value.ToString();
            // Juntar o ID e o nome para exibir no apagar:

            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Savar o ID do selecionado na variável global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;

            // Apagar: 
        }
    }
}
