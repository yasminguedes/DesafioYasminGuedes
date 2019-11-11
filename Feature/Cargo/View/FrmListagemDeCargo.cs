using ProjetoDesafio.Feature.Cargo.Controller;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Cargo.View
{
    public partial class FrmListagemDeCargo : Form
    {
        private readonly CargoController _cargoController;
        public FrmListagemDeCargo()
        {
            InitializeComponent();
            _cargoController = new CargoController();
            ListarCargo();
        }

        private void ListarCargo() => dtListaCargos.DataSource = _cargoController.Listar();

        private void DtListaCargos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaCargos, e);
    }
}
