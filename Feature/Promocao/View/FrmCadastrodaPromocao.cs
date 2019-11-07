using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmCadastroDaPromocao : Form
    {
        public FrmCadastroDaPromocao()
        {
            InitializeComponent();
        }

        private void BtnInserirProdutos_Click(object sender, EventArgs e)
        {
            new FrmInsereProdutos().Show();
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
