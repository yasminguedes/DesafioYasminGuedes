using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Cliente.View;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Pedido.View
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
            HabilitarOuDesabilitarCampos(false);
            LimparCampos();
        }

        private void LimparCampos()
        {
            lstProdutos.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtValor.Text = string.Empty;
            dtgItens.Rows.Clear();
            nrQtde.Text = string.Empty;
        }

        private void HabilitarOuDesabilitarCampos(bool habilitarCampos)
        {
            lstProdutos.Enabled = habilitarCampos;
            txtTotal.Enabled = habilitarCampos;
            txtProduto.Enabled = habilitarCampos;
            txtValor.Enabled = habilitarCampos;
            dtgItens.Enabled = habilitarCampos;
            nrQtde.Enabled = habilitarCampos;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarOuDesabilitarCampos(true);
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var lista = PreencherLista();
            lstProdutos.DisplayMember = "NomeProduto";
            lstProdutos.DataSource = lista;
        }

        private static List<ProdutoModel> PreencherLista()
        {
            return new List<ProdutoModel>
            {
                new ProdutoModel
                {
                    NomeProduto = "Presunto Sadia",
                    PrecoVenda = 50.00
                },
                new ProdutoModel
                {
                    NomeProduto =  "Tequila José Cuervo",
                    PrecoVenda =  70.00
                },
                new  ProdutoModel
                {
                    NomeProduto = "Refrigerante Coca-Cola",
                    PrecoVenda = 30.00
                }
            };
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LstProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lstProdutos.IndexFromPoint((e.Location));
            if (index == ListBox.NoMatches) return;
            var item = (ProdutoModel)lstProdutos.SelectedItems[0];
            txtProduto.Text = item.NomeProduto;
            txtValor.Text = item.PrecoVenda.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dtgItens.Rows.Add(txtProduto.Text, txtValor.Text,nrQtde.Text);
            CalcularTotal();
        }
        
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            dtgItens.Rows.Remove(dtgItens.CurrentRow ?? throw new InvalidOperationException());
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Pedido cadastrado com sucesso!");
            LimparCampos();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            for (var index = 0; index < dtgItens.Rows.Count; index++)
            {
                var row = dtgItens.Rows[index];
                total += Convert.ToDecimal(row.Cells[@"Valor"].Value) * Convert.ToInt32(row.Cells[@"Quantidade"].Value);
            }

            txtTotal.Text = Convert.ToDouble(total).ToString(CultureInfo.InvariantCulture);
        }

        private void TxtPesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnCliente_Click(null, null);
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            var cliente = new FrmSelecionaCliente().RetornarClienteSelecionado();
            txtPesquisaCliente.Text = cliente.NomePessoa;
        }

        private void BtnPesquisaProduto_Click(object sender, EventArgs e)
        {
            lstProdutos.DataSource = PreencherLista()
                .Where(p => p.NomeProduto.ToLower().Contains(txtPesquisaProdutos.Text.ToLower())).ToList();
        }

        private void txtPesquisaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                BtnPesquisaProduto_Click(null,null);
        }
    }
}
