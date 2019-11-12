using ProjetoDesafio.Feature.Produto.Model;
using ProjetoDesafio.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroDaPromocao : Form
    {
        private readonly List<ProdutoModel> _produtos;
        private readonly PromocaoModel _promocaoModel;

        public FrmCadastroDaPromocao()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
            _promocaoModel = new PromocaoModel();
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                txtNomePromoção.Enabled = true;
            }
        }

        private void TxtNomePromoção_TextChanged(object sender, EventArgs e)
        {
            btnInserirProdutos.Enabled = !string.IsNullOrWhiteSpace(txtNomePromoção.Text);
        }

        private void BtnInserirProdutos_Click(object sender, EventArgs e)
        {
            _produtos.AddRange(new FrmInsereProdutos().RetornarProdutos());

            if (_produtos.Count <= 0) return;

            produtoModelBindingSource1.DataSource = null;
            produtoModelBindingSource1.DataSource = _produtos;
            dtgProdutosPromocao.Refresh();

            if (_produtos.Count <= 0) return;
            rdPorcentagem.Enabled = true;
            rdValor.Enabled = true;
            txtDesconto.Enabled = true;
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDesconto();

            dtInicio.Enabled = !string.IsNullOrWhiteSpace(txtDesconto.Text);
            dtFim.Enabled = !string.IsNullOrWhiteSpace(txtDesconto.Text);
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _promocaoModel.NomePromocao = txtNomePromoção.Text;
            _promocaoModel.TipoPromocao = cmbTipo.Text;
            _promocaoModel.InicioPromocao = DateTime.Parse(dtFim.Text);
            _promocaoModel.TerminoPromocao = DateTime.Parse(dtFim.Text);

            MessageBox.Show(@"Promoção cadastrada com sucesso!");

            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        public PromocaoModel RetornaPromocao()
        {
            ShowDialog();

            return DialogResult == DialogResult.OK ? _promocaoModel : new PromocaoModel();
        }

        private void DtgProdutosPromocao_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dtgProdutosPromocao.Columns["precoDeVendaComDesconto"].Index != e.ColumnIndex || e.RowIndex < 0) return;

            e.CellStyle.ForeColor = Color.Red;
        }
    }
}

