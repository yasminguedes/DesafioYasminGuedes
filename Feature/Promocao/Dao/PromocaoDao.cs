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

        public bool Cadastrar(PromocaoModel promocao)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                var commandText = new StringBuilder();

                commandText.Append(@"INSERT into Promocao(nome_promocao, status_promocao, desconto, tipo_promoção,
                                    inicio_promocao,termino_promocao)Values ");
                commandText.Append(@"(@NomePromocao, @StatusPromocao, @Desconto, @TipoPromocao, @InicioPromocao, @TerminoPromocao)");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@NomePromocao", FbDbType.VarChar).Value = promocao.NomePromocao;
                cmd.Parameters.Add("@StatusPromocao", FbDbType.Numeric).Value = promocao.StatusPromocao;
                cmd.Parameters.Add("@Desconto", FbDbType.Numeric).Value = promocao.Desconto;
                cmd.Parameters.Add("@TipoPromocao", FbDbType.Integer).Value = promocao.TipoPromocao;
                cmd.Parameters.Add("@InicioPromocao", FbDbType.Date).Value = promocao.InicioPromocao;
                cmd.Parameters.Add("@TerminoPromocao", FbDbType.Date).Value = promocao.TerminoPromocao;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                if (conexaoFireBird.State != ConnectionState.Closed)
                    conexaoFireBird.Close();
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
                        IdPromocao = int.Parse(dr["id_produto"].ToString()),
                        NomePromocao = dr["nome_produto"].ToString(),
                        Desconto = double.Parse(dr["preco_compra"].ToString()),
                        TipoPromocao = dr["preco_venda"].ToString(),
                        InicioPromocao = DateTime.Parse(dr["qtde_estoque"].ToString()),
                        TerminoPromocao = DateTime.Parse(dr["ativo"].ToString())
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
