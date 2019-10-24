using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
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
            lstProdutos.Text = "";
            txtTotal.Text = "";
            txtProduto.Text = "";
            txtValor.Text = "";
            dtgItens.Rows.Clear();
            nrQtde.Text = "";
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
            var lista = new List<object>
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
            lstProdutos.DisplayMember = "NomeProduto";
            lstProdutos.Items.Add(lista[0]);
            lstProdutos.Items.Add(lista[1]);
            lstProdutos.Items.Add(lista[2]);
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
    }
}
