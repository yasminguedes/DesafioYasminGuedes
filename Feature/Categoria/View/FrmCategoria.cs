using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Categoria.Controller;
using ProjetoDesafio.Feature.Categoria.Model;

namespace ProjetoDesafio.Feature.Categoria.View
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();

        }
        private void LimparCampos()
        {
            txtCategoria.Text = "";
        }

        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            txtCategoria.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var categoria = new CategoriaModel
            {
                NomeCategoria = txtCategoria.Text
            };

            new CategoriaController().Cadastrar(categoria);
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
