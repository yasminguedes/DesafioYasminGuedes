using ProjetoDesafio.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoDesafio.Feature.Promocao.Controller;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmPromocao : Form
    {
        private readonly List<PromocaoModel> _promocao;
        private readonly PromocaoController _promocaoController;

        public FrmPromocao()
        {
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
            _promocaoController = new PromocaoController();
            ListarPromocao();
        }

        private void ListarPromocao() => dtgPromocao.DataSource = _promocaoController.Listar();

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            var promocao = new FrmCadastroDaPromocao().RetornaPromocao();
            if (string.IsNullOrWhiteSpace(promocao.NomePromocao)) return;
            _promocao.Add(promocao);
            dtgPromocao.DataSource = null;
            dtgPromocao.DataSource = _promocao;
        }
    }
}
