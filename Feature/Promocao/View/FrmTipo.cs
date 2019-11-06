using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            new FrmInsereProdutosPromocao().Show();
        }
    }
}
