using System.Windows.Forms;
using ProjetoDesafio.Feature.Categoria.Controller;

namespace ProjetoDesafio.Feature.Categoria.View
{
    public partial class FrmListagemDeCategoria : Form
    {
        private readonly CategoriaController _categoriaController;
        public FrmListagemDeCategoria()
        {
            InitializeComponent();
            _categoriaController = new CategoriaController();
            ListarCategoria();
        }
        private void ListarCategoria() => dtListaCategoria.DataSource = _categoriaController.Listar();

        private void DtListaCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaCategoria, e);
    }
}
