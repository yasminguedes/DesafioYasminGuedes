using System;
using System.Reflection;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Produto.Controller;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Produto.View
{
    public partial class FrmListarProduto : Form
    {
        public FrmListarProduto()
        {
            InitializeComponent();
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            var filtro = Filtrar();
            dtListaProdutos.DataSource = new ProdutoController().Listar(filtro);
        }

        private ProdutoFiltroModel Filtrar() =>
            new ProdutoFiltroModel
            {
                NomeProduto = txtPesquisar.Text,
                Categoria = {NomeCategoria = txtPesquisar.Text},
                Marca = {NomeMarca = txtPesquisar.Text},
                PesquisarPorMarca = rdbMarca.Checked,
                PesquisarPorNomeProduto = rdbProduto.Checked
            };

        private void DtListaProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dtListaProdutos.Rows[e.RowIndex].DataBoundItem != null) && (dtListaProdutos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dtListaProdutos.Rows[e.RowIndex].DataBoundItem, dtListaProdutos.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        public object BindProperty(object propriedade, string propriedadeName)
        {
            var retValue = "";
            if (propriedadeName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propriedadeName.Substring(0, propriedadeName.IndexOf(".", StringComparison.Ordinal));
                arrayProperties = propriedade.GetType().GetProperties();
                foreach (var propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name != leftPropertyName) continue;
                    retValue = (string)BindProperty(
                        propertyInfo.GetValue(propriedade, null),
                        propriedadeName.Substring(propriedadeName.IndexOf(".", StringComparison.Ordinal) + 1));
                    break;
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = propriedade.GetType();
                propertyInfo = propertyType.GetProperty(propriedadeName);
                if (propertyInfo != null) retValue = propertyInfo.GetValue(propriedade, null).ToString();
            }
            return retValue;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListarProdutos();
        }
    }
}
