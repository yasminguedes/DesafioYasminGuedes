using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroDaPromocao : Form
    {
        private readonly IList<ProdutoModel> _produtos;
        public FrmCadastroDaPromocao()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
        }

        private void BtnInserirProdutos_Click(object sender, EventArgs e)
        {
            new FrmInsereProdutos().Show();
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDesconto();
        }

        private void CalcularDesconto()
        {
            if (!double.TryParse(txtDesconto.Text, out var desconto)) return;

            if (rdPorcentagem.Checked)
            {
                foreach (var p in _produtos)
                {
                    p.PrecoDeVendaComDesconto = p.PrecoVenda - p.PrecoVenda * desconto / 100;
                }
            }
            else
            {
                foreach (var p in _produtos)
                {
                    p.PrecoDeVendaComDesconto = p.PrecoVenda - desconto;
                }
            }

            dtgProdutosPromocao.Refresh();
        }

        private void BtnSalvar_Click(object sender, EventArgs e) =>
            MessageBox.Show("Promoção cadastrada com sucesso!");

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
