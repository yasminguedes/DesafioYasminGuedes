using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Pedido.View
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
        }
        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            lstProdutos.Enabled = habilitarCampos;
            txtTotal.Enabled = habilitarCampos;
            txtProduto.Enabled = habilitarCampos;
            txtValor.Enabled = habilitarCampos;
            dtgItens.Enabled = habilitarCampos;
            nrQtde.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, System.EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }
    }
}
