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
    public partial class GerenciamentoComandas : Form
    {
        // Globais:
        Classes.Usuario usuario;
        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mudar o título da janela:
            this.Text = "Gerenciamento Comandas - " +
                "Logado como: " + usuario.NomeCompleto.ToUpper();

            // Popular o DGV com os dados da tabela de produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvComandas.DataSource = produto.ListarTudo();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            grbLancamento.Enabled = true;
            grbInformações.Enabled = false;
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvComandas.CurrentCell.RowIndex;
            var linha = dgvComandas.Rows[linhaSelecionada];

            // Popular os txbs com os valores dos dgvs:
            txbProduto.Text = linha.Cells[0].Value.ToString();
            txbProdutoL.Text = linha.Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) 
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                // Obter os valores dos campos:
                ordem.IdFicha = int.Parse(txbComanda.Text);
                ordem.IdProduto = int.Parse(txbProduto.Text);
                ordem.Quantidade = int.Parse(txbQuantidade.Text);
                ordem.IdResp = usuario.Id;
                // Efetuar o cadastro:
                if(ordem.NovoLancamento() == true)
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbLancamento.Enabled = false;
                    grbInformações.Enabled = true;
                    txbProduto.Clear();
                    txbProdutoL.Clear();
                    txbQuantidade.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao efetuar o lançamento!", "Falha!",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
    }
}
