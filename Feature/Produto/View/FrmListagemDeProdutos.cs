using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Produto.View
{
    public partial class FrmListagemDeProdutos : Form
    {
        private readonly ProdutoController _produtoController;

        public FrmListagemDeProdutos()
        {
            InitializeComponent();
            _produtoController = new ProdutoController();
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            var filtro = Filtrar();
            dtListaProdutos.DataSource = _produtoController.Listar(filtro);
        }

        private ProdutoFiltroModel Filtrar() =>
            new ProdutoFiltroModel()
            {
                NomeProduto = txtPesquisar.Text,
                Marca = {NomeMarca = txtPesquisar.Text},
                Categoria = {NomeCategoria = txtPesquisar.Text},
                PesquisarPorNomeProduto = rdbProduto.Checked,
                PesquisarPorMarca = rdbMarca.Checked
            };
            

        private void DtListaProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
                e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaProdutos, e);
        
        
        private void BtnPesquisar_Click(object sender, EventArgs e) => ListarProdutos();
        

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListarProdutos();
        }
    }
}
