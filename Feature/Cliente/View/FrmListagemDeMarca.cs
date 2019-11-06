using System.Windows.Forms;
using ProjetoDesafio.Feature.Marca.Controller;

namespace ProjetoDesafio.Feature.Cliente.View
{
    public partial class FrmListagemDeMarca : Form
    {
        private readonly MarcaController _marcaController;

        public FrmListagemDeMarca()
        {
            InitializeComponent();
            _marcaController = new MarcaController();
            ListarMarca();
        }

        private void ListarMarca() => dtListaMarca.DataSource = _marcaController.Listar();

        private void DtListaMarca_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaMarca, e);
    }
}

