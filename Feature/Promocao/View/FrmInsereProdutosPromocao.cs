using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmInsereProdutosPromocao : Form
    {
        public FrmInsereProdutosPromocao()
        {
            InitializeComponent();
        }

        private void FrmInsereProdutosPromocao_Load(object sender, EventArgs e)
        {
            var produto = new List<ProdutoModel>
            {
                new ProdutoModel
                {
                    IdProduto = 1,
                    NomeProduto = "Refrigerante de Cola",
                    Marca = {NomeMarca = "Saboraki"},
                    Categoria = {NomeCategoria = "Refrigerantes"},
                    DataValidade = DateTime.Parse("05/10/2020"),
                    PrecoVenda = double.Parse("5,00")
                },
                new ProdutoModel
                {
                    IdProduto = 2,
                    NomeProduto = "Refrigerante de Uva",
                    Marca = {NomeMarca = "Saboraki"},
                    Categoria = {NomeCategoria = "Refrigerantes"},
                    DataValidade = DateTime.Parse("5/12/2019"),
                    PrecoVenda = double.Parse("5,00")
                },
                new ProdutoModel
                {
                    IdProduto = 3,
                    NomeProduto = "Cerveja",
                    Marca = {NomeMarca = "Eisenbahn"},
                    Categoria = {NomeCategoria = "Cervejas"},
                    DataValidade = DateTime.Parse("5/03/2020"),
                    PrecoVenda = double.Parse("10,00")
                },
                new ProdutoModel
                {
                    IdProduto = 4,
                    NomeProduto = "Tequila",
                    Marca = {NomeMarca = "Jose Cuervo"},
                    Categoria = {NomeCategoria = "Destilados"},
                    DataValidade = DateTime.Parse("25/06/2030"),
                    PrecoVenda = double.Parse("5,00")
                }
            };
            dtgSelecionarProdutos.DataSource = produto;
        }
        private void DtSelecionarProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtgSelecionarProdutos, e);

        private void BtnCancelar_Click(object sender, EventArgs e) => Close();

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            new FrmCadastrodaPromocao().Show();
        }
    }
}
