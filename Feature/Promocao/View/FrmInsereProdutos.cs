using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmInsereProdutos : Form
    {
        public FrmInsereProdutos()
        {
            InitializeComponent();
            ListarProduto();
        }

        private void ListarProduto()
        {
            var filtro = Filtrar();
            dtgListaProdutos.DataSource = new ProdutoController().Listar(filtro);
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
                   Marca = {NomeMarca = txtProdutos.Text},
                   PesquisarPorMarca = true
                };
            }

            if (rdCodigo.Checked)
            {
                try
                {
                    return new ProdutoFiltroModel
                    {
                        Codigo = int.Parse(txtProdutos.Text),
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
                Categoria = {NomeCategoria = txtProdutos.Text}
            };

        }


        private void TxtProdutos_TextChanged(object sender, EventArgs e)
        {
            ListarProduto();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

    }
}
