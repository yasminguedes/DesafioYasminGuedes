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
        private void FrmSelecionaCliente_Load(object sender, EventArgs e)
        {
            var cliente = new List<ClienteModel>
            {
                new ClienteModel
                {
                    IdCliente = 1,
                    NomePessoa = "João"
                },
                new ClienteModel
                {
                    IdCliente = 2,
                    NomePessoa = "Maria"
                },
                new ClienteModel
                {
                    IdCliente = 3,
                    NomePessoa = "Dimitri"
                }
            };
            dtListaCliente.DataSource = cliente;

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Cliente adicionado com sucesso!");
        }

        public ClienteModel RetornarClienteSelecionado()
        {
            ShowDialog();

            return DialogResult == DialogResult.OK
                ? new ClienteModel { NomePessoa = "João" }
                : new ClienteModel();
        }
    }
}
