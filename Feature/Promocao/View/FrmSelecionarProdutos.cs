using ProjetoDesafio.Feature.Produto.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmSelecionarProdutos : Form
    {
        private readonly IList<ProdutoModel> _produtos;

        public FrmSelecionarProdutos()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            var desconto = Convert.ToDouble(txtDesconto.Text);

            foreach (var p in _produtos)
            {
                p.PrecoDeVendaComDesconto = p.PrecoVenda - (p.PrecoVenda * desconto) / 100;
            }

            AdicionarProdutosNaGrid();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produtos adicionados com sucesso!");
            Close();
        }

        private void TrvProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!trvProdutos.SelectedNode.Text.Contains("|")) return;

            var produto = new ProdutoModel
            {
                NomeProduto = trvProdutos.SelectedNode.Text.Split('|')[0].Trim(),
                PrecoVenda = double.Parse(trvProdutos.SelectedNode.Text.Split('|')[1].Trim().Replace(".", ","))
            };

            _produtos.Add(produto);

            AdicionarProdutosNaGrid();
        }

        public IList<ProdutoModel> RetornarProdutosSelecionados()
        {
            ShowDialog();

            return _produtos;
        }

        private void AdicionarProdutosNaGrid()
        {
            dtgProduto.Rows.Clear();

            foreach (var p in _produtos)
                dtgProduto.Rows.Add(p.NomeProduto, p.PrecoVenda, p.PrecoDeVendaComDesconto);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            dtgProduto.Rows.Remove(dtgProduto.CurrentRow ?? throw new InvalidOperationException());
        }
    }
}
