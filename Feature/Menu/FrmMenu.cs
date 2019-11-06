using System;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Administrador.View;
using ProjetoDesafio.Feature.Cargo.View;
using ProjetoDesafio.Feature.Categoria.View;
using ProjetoDesafio.Feature.Cliente.View;
using ProjetoDesafio.Feature.Fornecedor.View;
using ProjetoDesafio.Feature.Funcionario.View;
using ProjetoDesafio.Feature.Marca.View;
using ProjetoDesafio.Feature.Pedido.View;
using ProjetoDesafio.Feature.Produto.View;
using ProjetoDesafio.Feature.Promocao.View;
namespace ProjetoDesafio.Feature.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            new FrmFuncionario().Show();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            new FrmFornecedor().Show();
        }
        
        private void BtnMarca_Click(object sender, EventArgs e)
        {
            new FrmMarca().Show();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            new FrmCategoria().Show();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            new FrmCliente().Show();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            new FrmProduto().Show();
        }

        private void BtnPromocao_Click(object sender, EventArgs e)
        {
            new FrmPromocao().Show(); 
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            new FrmPedido().Show();
        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            new  FrmCargo().Show();
        }
    }
}
