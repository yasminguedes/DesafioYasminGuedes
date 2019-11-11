using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmInsereProdutos : Form
    {
        private List<ProdutoModel> _produtos;

        public FrmInsereProdutos()
        {
            InitializeComponent();
            _produtos = new List<ProdutoModel>();
        }

        private void ListarProduto()
        {
            var filtro = Filtrar();
            ckbProdutos.DataSource = new ProdutoController().Listar(filtro);
            ckbProdutos.DisplayMember = "NomeProduto";
        }

        private ProdutoFiltroModel Filtrar()
        {
            if (rdProduto.Checked)
            {
                return new ProdutoFiltroModel
                {
                    NomeProduto = txtProdutos.Text,
                    PesquisarPorNomeProduto = true
                };
            }

            if (rdMarca.Checked)
            {
                return new ProdutoFiltroModel
                {
                    Marca = { NomeMarca = txtProdutos.Text },
                    PesquisarPorMarca = true
                };
            }

            if (rdCodigo.Checked)
            {
                try
                {
                    return new ProdutoFiltroModel
                    {
                        CodigoBarras = txtProdutos.Text,
                        PesquisarPorCodigo = true
                    };
                }
                catch
                {
                    return new ProdutoFiltroModel();
                }
            }

            if (rdValidade.Checked)
            {
                try
                {
                    return new ProdutoFiltroModel
                    {
                        DataValidade = Convert.ToDateTime(txtProdutos.Text),
                        PesquisarPorValidade = true
                    };
                }
                catch
                {
                    return new ProdutoFiltroModel();
                }
            }
            return new ProdutoFiltroModel
            {
                Categoria = { NomeCategoria = txtProdutos.Text }
            };
        }

        public IList<ProdutoModel> RetornarProdutos() =>
            ShowDialog() == DialogResult.OK ? _produtos : new List<ProdutoModel>();

        private void TxtProdutos_TextChanged(object sender, EventArgs e) => ListarProduto();

        private void AdicionarProdutosNaGrid()
        {
            dtgListaProdutos.DataSource = null;
            dtgListaProdutos.DataSource = _produtos;
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _produtos = dtgListaProdutos.DataSource as List<ProdutoModel>;
            MessageBox.Show(@"Produtos Adicionados com sucesso!");
            DialogResult = DialogResult.OK;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _produtos.AddRange(ckbProdutos.CheckedItems.Cast<ProdutoModel>().ToList());
            
            AdicionarProdutosNaGrid();
        }
    }
}
