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
        }

        private void ListarProduto()
        {
            var filtro = Filtrar();
            dtgListaProdutos.DataSource = new ProdutoController().Listar(filtro);
        }
        
        private ProdutoFiltroModel Filtrar() =>
            new ProdutoFiltroModel
            {
                NomeProduto = txtProdutos.Text,
                PesquisarPorMarca = rdMarca.AutoCheck,
                PesquisarPorNomeProduto = rdProduto.Checked,
                PesquisarPorCodigo = rdCodigo.AutoCheck,
                PesquisarPorValidade = rdValidade.Checked
            };
        

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void TxtProdutos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
