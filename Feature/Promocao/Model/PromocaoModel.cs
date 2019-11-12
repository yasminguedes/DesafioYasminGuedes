using System;
using System.Collections.Generic;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Promocao.Model
{
    public class PromocaoModel
    {
        public int IdPromocao { get; set; }
        public string NomePromocao { get; set; }
        public string StatusPromocao { get; set; }
        public double Desconto { get; set; }
        public  string ItemPromocao { get; set; }
        public string TipoPromocao { get; set; }
        public DateTime InicioPromocao { get; set; }
        public DateTime TerminoPromocao { get; set; }
        public List<ProdutoModel> Produto { get; set; }

        public PromocaoModel()
        {
            Produto = new List<ProdutoModel>();
        }
    }
}
