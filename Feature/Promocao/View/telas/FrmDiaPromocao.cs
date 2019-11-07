using System;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View.telas
{
    public partial class FrmDiaPromocao : Form
    {
        public FrmDiaPromocao()
        {
            InitializeComponent();
            SelecionarDiaSemana();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelecionarDiaSemana()
        {
            cmbDiaSemana.Items.Add("Segunda-Feira");
            cmbDiaSemana.Items.Add("Terça-Feira");
            cmbDiaSemana.Items.Add("Quarta-Feira");
            cmbDiaSemana.Items.Add("QUinta-Feira");
            cmbDiaSemana.Items.Add("Sexta-Feira");
            cmbDiaSemana.Items.Add("Sábado");
            cmbDiaSemana.Items.Add("Domingo");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            dtgDiasAdicionados.Rows.Add(cmbDiaSemana.Text, dtDiaInicio.Text, dtDiaTermino.Text, dtHoraInicio.Text,
                dtHoraTermino.Text);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Período da promoção salvo com sucesso!");
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtgDiasAdicionados.Rows.Remove(dtgDiasAdicionados.CurrentRow ?? throw new InvalidOperationException());
        }
    }
}
