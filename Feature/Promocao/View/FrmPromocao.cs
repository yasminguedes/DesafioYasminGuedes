using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmPromocao : Form
    {
        public FrmPromocao()
        {
            InitializeComponent();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new FrmCadastroPromocao().Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
