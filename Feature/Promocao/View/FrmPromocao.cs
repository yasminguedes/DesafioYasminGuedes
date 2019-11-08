using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Promocao.Model;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmPromocao : Form
    {
        private IList<PromocaoModel> _promocao;
        public FrmPromocao()
        {
            InitializeComponent();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new  FrmCadastroDaPromocao().Show();
        }
    }
}
