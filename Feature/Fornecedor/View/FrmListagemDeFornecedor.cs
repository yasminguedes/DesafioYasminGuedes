using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Fornecedor.Controller;
using ProjetoDesafio.Feature.Fornecedor.Model;

namespace ProjetoDesafio.Feature.Fornecedor.View
{
    public partial class FrmListagemDeFornecedor : Form
    {
        public FrmListagemDeFornecedor()
        {
            InitializeComponent();
            ListarFornecedor();
        }

        private void ListarFornecedor()
        {
            var filtro = Filtrar();
            dtListaFornecedor.DataSource = new FornecedorController().Listar(filtro);
        }

        private FornecedorFiltroModel Filtrar() =>
            new FornecedorFiltroModel()
            {
                NomePessoa = txtPesquisar.Text,
                RazaoSocial = txtPesquisar.Text,
                Representante = txtPesquisar.Text,
                PesquisarPorNomeFantasia = rdbNomeFantasia.Checked,
                PesquisarPorRazaoSocial = rdbNomeFantasia.Checked
            };
        private void DtListFornecedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedades.BuscaPropriedadesComPonto(dtListaFornecedor, e);
        
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ListarFornecedor();
        }

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ListarFornecedor();
        }
    }
}
