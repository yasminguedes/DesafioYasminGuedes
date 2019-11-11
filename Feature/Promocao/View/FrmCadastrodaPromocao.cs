using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Model;
using ProjetoDesafio.Feature.Promocao.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroDaPromocao : Form
    {
        private IList<ProdutoModel> _produtos;
        private readonly PromocaoModel _promocaoModel;
        public FrmCadastroDaPromocao()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
            _promocaoModel = new PromocaoModel();
        }
       
        private void BtnInserirProdutos_Click(object sender, EventArgs e)
        {
            _produtos = new FrmInsereProdutos().RetornarProdutos();

            if (_produtos.Count <= 0) return;

            produtoModelBindingSource.DataSource = _produtos;
            dtgProdutosPromocao.Refresh();
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _promocaoModel.NomePromocao = txtNomePromoção.Text;
            _promocaoModel.Descricao = txtDescricao.Text;
            _promocaoModel.TipoPromocao = cmbTipo.Text;
            _promocaoModel.StatusPromocao = cmbStatus.Text;
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

        private void CmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
           if (cmbTipo.SelectedIndex == 1)
           {
               lblDesconto.Location = new Point(18, 220);
               rdPorcentagem.Location = new Point(143, 220);
               rdValor.Location = new Point(250, 220);
               txtDesconto.Location = new Point(345, 215);
               lblStatus.Location = new Point(19, 260);
               cmbStatus.Location = new Point(143, 255);
               btnInserirProdutos.Location = new Point(310, 253);
               dtgProdutosPromocao.Location = new Point(25, 300);
               btnSalvar.Location = new Point(138, 630);
               btnCancelar.Location = new Point(343, 630);

               txtValor.Visible = true;
               lblAcima.Visible = true;
           }
           else if (cmbTipo.SelectedIndex == 2)
           {

           }
        }
    }
}
