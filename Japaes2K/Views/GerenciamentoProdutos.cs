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
    public partial class GerenciamentoProdutos : Form
    {
        // Atributos globais:
        Classes.Usuario usuario = new Classes.Usuario();
        int idSelecionado = 0;
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Classes.Produto produto = new Classes.Produto();
            cmbCategoria.DataSource = produto.ListarTudo();
            cmbEdCategoria.DataSource = produto.ListarTudo();
            AtualizarTudo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void AtualizarTudo()
        {
            Classes.Produto produto = new Classes.Produto();
            // Atualizar o DGV:
            dgvProdutos.DataSource = produto.ListarTudo();
            // Listar os campos de edição:
            txbEdNome.Clear();
            txbEdPreco.Clear();
            lblApagar.Text = "Selecione um produto para apagar.";
            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
            // Limpar os campos:
            txbNome.Clear();
            txbPreco.Clear();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:                     
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;
            // Obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvProdutos.Rows[linhaSelecionada];

            // Preencher os campos:
            txbEdNome.Text = linha.Cells[1].Value.ToString();
            txbEdPreco.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o ID do selecionado na variável global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o produto:
            Classes.Produto produto = new Classes.Produto();
            // Obter os valores dos campos:
            produto.Nome = txbNome.Text;
            produto.Preco = int.Parse(txbPreco.Text);
            produto.IdCategoria = cmbCategoria.SelectedIndex;
            produto.IdRespCadastro = usuario.Id;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Produto cadastrado!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o produto.", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            // Obter os valores dos txbs:
            produto.Id = idSelecionado;
            produto.Nome = txbEdNome.Text;
            produto.Preco = int.Parse(txbEdPreco.Text);
            produto.IdCategoria = cmbEdCategoria.SelectedIndex;

            if(usuario.Editar())
            {
                MessageBox.Show("Produto editado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                AtualizarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao editar o produto.", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = idSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (produto.Apagar())
                {
                    MessageBox.Show("Produto removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto.", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
