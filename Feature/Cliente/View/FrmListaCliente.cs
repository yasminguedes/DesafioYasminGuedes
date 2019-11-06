using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cliente.Model;

namespace ProjetoDesafio.Feature.Cliente.View
{
    public partial class FrmSelecionaCliente : Form
    {

       public FrmSelecionaCliente()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente adicionado com sucesso!");
        }

        public ClienteModel RetornarClienteSelecionado()
        {
            ShowDialog();

            return DialogResult == DialogResult.OK
                ? new ClienteModel {NomePessoa = "Teste"}
                : new ClienteModel();
        }
    }
}
