using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View.telas
{
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
            SelecionaTipo();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            new FrmInsereProdutosPromocao().Show();
        }

        private void SelecionaTipo()
        {
            cmbTipo.Items.Add(@"Desconto Percentual/ Valor atribuído");
            cmbTipo.Items.Add(@"Cada X em compras, ganhe Y em desconto");
            cmbTipo.Items.Add(@"Leve X, pague Y");
        }
    }
}
