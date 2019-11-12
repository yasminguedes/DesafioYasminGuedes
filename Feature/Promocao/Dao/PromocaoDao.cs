using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoDesafio.Feature.Promocao.Dao
{
    public class PromocaoDao
    {

        public bool Cadastrar(PromocaoModel promocao, FbCommand cmd)
        {
            

              var commandText = new StringBuilder();

                commandText.Append(@"INSERT into Promocao(nome_promocao, status_promocao, desconto, tipo_promocao,
                                    inicio_promocao,termino_promocao)Values ");
                commandText.Append(@"(@NomePromocao, @StatusPromocao, @Desconto, @TipoPromocao, @InicioPromocao, @TerminoPromocao) returning id_promocao");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@NomePromocao", FbDbType.VarChar).Value = promocao.NomePromocao;
                cmd.Parameters.Add("@StatusPromocao", FbDbType.Numeric).Value = promocao.StatusPromocao;
                cmd.Parameters.Add("@Desconto", FbDbType.Numeric).Value = promocao.Desconto;
                cmd.Parameters.Add("@TipoPromocao", FbDbType.VarChar).Value = promocao.TipoPromocao;
                cmd.Parameters.Add("@InicioPromocao", FbDbType.Date).Value = promocao.InicioPromocao;
                cmd.Parameters.Add("@TerminoPromocao", FbDbType.Date).Value = promocao.TerminoPromocao;

                promocao.IdPromocao = int.Parse(cmd.ExecuteScalar().ToString());
                CadastrarItensPromocao(promocao,cmd);
                return true;
            
        }

        public void CadastrarItensPromocao(PromocaoModel promocao, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Promo_Produto(preco_desconto, id_promocao, id_produto)Values ");
            commandText.Append(@"(@ValorDesconto, @IdPromocao, @IdProduto)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@ValorDesconto", FbDbType.Numeric);
            cmd.Parameters.Add("@IdPromocao", FbDbType.Integer);
            cmd.Parameters.Add("@IdProduto", FbDbType.Integer);

            foreach (var produto in promocao.Produto)
            {
                cmd.Parameters["@ValorDesconto"].Value = produto.PrecoDeVendaComDesconto;
                cmd.Parameters["@IdPromocao"].Value = promocao.IdPromocao;
                cmd.Parameters["@IdProduto"].Value = produto.IdProduto;

                cmd.ExecuteNonQuery();
            }
        }

        internal IEnumerable<PromocaoModel> Listar()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();
            try
            {
                cmd.Connection = conexaoFirebird;

                var sql = new StringBuilder();
                sql.Append(@"Select * from Promocao");

                cmd.CommandText = sql.ToString();

                var dr = cmd.ExecuteReader();

                var listaPromocao = new List<PromocaoModel>();
                while (dr.Read())
                    listaPromocao.Add(new PromocaoModel
                    {
                        IdPromocao = int.Parse(dr["id_promocao"].ToString()),
                        NomePromocao = dr["nome_promocao"].ToString(),
                        Desconto = double.Parse(dr["desconto"].ToString()),
                        TipoPromocao = dr["tipo_promocao"].ToString(),
                        InicioPromocao = DateTime.Parse(dr["inicio_promocao"].ToString()),
                        TerminoPromocao = DateTime.Parse(dr["termino_promocao"].ToString()),
                        StatusPromocao = dr["status_promocao"].ToString()
                    });
                return listaPromocao;
            }
            finally
            {
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        }
    }
}
