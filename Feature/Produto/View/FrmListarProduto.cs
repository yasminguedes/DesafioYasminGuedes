using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;

namespace ProjetoDesafio.Feature.Produto.View
{
    public partial class FrmListarProduto : Form
    {
        public FrmListarProduto()
        {
            InitializeComponent();
        }

        private void FrmListarProduto_Load(object sender, EventArgs e)
        {
            dtListaProdutos.DataSource = new ProdutoController().Listar();
        }
    }
}
