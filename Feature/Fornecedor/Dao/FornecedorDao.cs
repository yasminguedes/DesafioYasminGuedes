using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Fornecedor.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace ProjetoDesafio.Feature.Fornecedor.Dao
{
    public class FornecedorDao
    {
        public static DataTable PegarDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Fornecedor";
                    var cmd = new FbCommand(mSql, conexaoFirebird);
                    var da = new FbDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }

        public bool Cadastrar(Model.FornecedorModel fornecedor, FbCommand cmd)
        {
            cmd.Parameters.Add("@RazaoSocial", FbDbType.VarChar).Value = fornecedor.RazaoSocial;
            cmd.Parameters.Add("@Representante", FbDbType.VarChar).Value = fornecedor.Representante;
            cmd.Parameters.Add("@CelularRepresentante", FbDbType.VarChar).Value = fornecedor.CelularRepresentante;
            cmd.Parameters.Add("@EmailRepresentante", FbDbType.VarChar).Value = fornecedor.EmailRepresentante;
            cmd.Parameters.Add("@IdPessoa", FbDbType.Integer).Value = fornecedor.IdPessoa;

            cmd.CommandText =
                @"INSERT into Fornecedor (razao_social, representante,celular_represetante,email_representante, id_pessoa)
                                Values(@RazaoSocial, @Representante, @CelularRepresentante, @EmailRepresentante, @IdPessoa)";

            cmd.ExecuteNonQuery();
            return true;
        }

        internal IEnumerable<FornecedorModel> Listar()
        {
            using (var conexaoFireBird = Connection.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    const string sql =
                        @"Select * from Fornecedor f INNER JOIN pessoa AS p on f.id_pessoa = p.id_pessoa ";
                    var cmd = new FbCommand(sql, conexaoFireBird);
                    var dr = cmd.ExecuteReader();

                    var listaFornecedor = new List<FornecedorModel>();
                    while (dr.Read())
                    {
                        var fornecedorModel = new FornecedorModel()
                        {
                            IdFornecedor = int.Parse(dr["id_fornecedor"].ToString()),
                            NomePessoa = dr["nome_pessoa"].ToString()
                        };
                        listaFornecedor.Add(fornecedorModel);
                    }

                    return listaFornecedor;
                }
                finally
                {
                    if (conexaoFireBird.State != ConnectionState.Closed)
                        conexaoFireBird.Close();
                }
            }
            
        }
    }
}
