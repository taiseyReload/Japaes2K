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
    public partial class GerenciamentoCaixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoCaixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void chbConfirmacao_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar/desativar o botão de encerrar comanda de acordo com o Checked:
            btnEncerrar.Enabled = chbConfirmacao.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verificar se o txb está vazio:
            if(txbComanda.Text != "")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                var r = ordem.BuscarFicha();
                // Verificar se existem itens na comanda:
                if (r.Rows.Count > 0)
                {
                    dgvCaixa.DataSource = r;
                    // Atualizar o valor total:
                    lblTotal.Text = r.Compute("SUM(Total_Item)", "True").ToString();
                }
                else
                {
                    MessageBox.Show("Não existem lançamentos nessa comanda.", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCaixa.DataSource = null;
                    lblTotal.Text = "0,00";
                    txbComanda.Clear();
                }
            }
            else
            {
                MessageBox.Show("Digite o número da ficha.", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes) 
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                if(ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encerrada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar:
                    txbComanda.Clear();
                    dgvCaixa.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
