using Japaes2K.Classes;
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
            AtualizarTudo();      
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
                AtualizarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o usuário.");
            }

        }
        public void AtualizarTudo()
        {
            Classes.Usuario usuario = new Classes.Usuario();
            // Atualizar o DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
            // Listar os campos de edição:
            txbEdEmail.Clear();
            txbEdNomeCompleto.Clear();
            txbEdSenha.Clear();
            lblApagar.Text = "Selecione um usuário para apagar.";
            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
            // Limpar os campos:
            txbNomeCompleto.Clear();
            txbEmail.Clear();
            txbSenha.Clear();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:                     
            grbEditar.Enabled = true;
            grbEditar.BackColor = Color.Black;
            grbApagar.Enabled = true;
            grbApagar.BackColor = Color.Black;

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

            // Salvar o ID do selecionado na variável global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) 
            {
                // Apagar:
                if(usuario.Apagar())
                {
                    MessageBox.Show("Usuário removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao remover o usuário.", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            // Obter os valores dos txbs:
            usuario.Id = idSelecionado;
            usuario.NomeCompleto = txbEdNomeCompleto.Text;
            usuario.Email = txbEdEmail.Text;
            usuario.Senha = txbEdSenha.Text;

            // Editar:
            if(usuario.Editar() == true)
            {
                MessageBox.Show("Usuário editado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                AtualizarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao editar o usuário.", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
