using ProjetoDesafio.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Promocao.View
{
    public partial class FrmPromocao : Form
    {
        private IList<PromocaoModel> _promocao;
        public FrmPromocao()
        {
        
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            var promocao = new FrmCadastroDaPromocao().RetornaPromocao();
            if (string.IsNullOrWhiteSpace(promocao.NomePromocao)) return;
            _promocao.Add(promocao);
            dtgPromocao.DataSource = null;
            dtgPromocao.DataSource = _promocao;
        }

        private void FrmPromocao_Load(object sender, EventArgs e)
        {
            _promocao = new List<PromocaoModel>
            {
                new PromocaoModel
                {
                    IdPromocao = 1,
                    NomePromocao = "Desconto Percentual Saboraki",
                    Descricao = "Promoção com X% de desconto da marca Saboraki",
                    TipoPromocao = "Desconto Percentual/Valor atribuído",
                    StatusPromocao = "Ativa",
                    InicioPromocao = DateTime.Parse("08/11/2019"),
                    TerminoPromocao = DateTime.Parse("14/11/2019")
                },
                new PromocaoModel
                {
                    IdPromocao = 2,
                    NomePromocao = "Desconto por categoria",
                    Descricao = "Promoção com R$ X,xx de desconto da categoria Destilados",
                    TipoPromocao = "Desconto Percentual/Valor atribuído",
                    StatusPromocao = "Ativa",
                    InicioPromocao = DateTime.Parse("14/11/2019"),
                    TerminoPromocao = DateTime.Parse("18/11/2019")
                }
            };
            dtgPromocao.DataSource = _promocao;
        }
    }
}
