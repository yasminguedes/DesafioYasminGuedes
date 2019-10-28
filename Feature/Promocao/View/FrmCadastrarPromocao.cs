using ProjetoDesafio.Feature.Produto.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroPromocao : Form
    {
        private IList<ProdutoModel> _produtos;

        public FrmCadastroPromocao()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            _produtos = new FrmSelecionarProdutos().RetornarProdutosSelecionados();
            
            foreach (var p in _produtos)
                dtgCadastroItem.Rows.Add(p.NomeProduto, p.PrecoVenda, p.PrecoDeVendaComDesconto);
        }

        private void BtnNovoSemana_Click(object sender, EventArgs e)
        {
            new FrmDiaPromocao().Show();
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Desconto");
            cmbTipo.Items.Add("Compre 3 pague 2");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            dtgCadastroItem.Rows.Remove(dtgCadastroItem.CurrentRow ?? throw new InvalidOperationException());
        }

        private void BtnExcluirSemana_Click(object sender, EventArgs e)
        {
            dtSemana.Rows.Remove(dtSemana.CurrentRow ?? throw new InvalidOperationException());
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Promoção salva com sucesso!");
            Close();
        }
    }
}
