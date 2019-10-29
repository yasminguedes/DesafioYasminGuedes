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
        public static DataTable GetDados()
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
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Fornecedor (razao_social, representante,celular_represetante,email_representante, id_pessoa) ");
            commandText.Append("Values(@RazaoSocial, @Representante, @CelularRepresentante, @EmailRepresentante, @IdPessoa)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@RazaoSocial", FbDbType.VarChar).Value = fornecedor.RazaoSocial;
            cmd.Parameters.Add("@Representante", FbDbType.VarChar).Value = fornecedor.Representante;
            cmd.Parameters.Add("@CelularRepresentante", FbDbType.VarChar).Value = fornecedor.CelularRepresentante;
            cmd.Parameters.Add("@EmailRepresentante", FbDbType.VarChar).Value = fornecedor.EmailRepresentante;
            cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = fornecedor.IdPessoa;

            cmd.ExecuteNonQuery();
            return true;
        }

        internal IEnumerable<FornecedorModel> Listar()
        {
            var conexaoFirebid = Connection.PegarInstancia().PegarConexao();
            conexaoFirebid.Open();
            var cmd = new FbCommand();

            try
            {
                cmd.CommandText =
                    @"Select * from Fornecedor f INNER JOIN pessoa AS p on f.id_pessoa = p.id_pessoa Where id_fornecedor =  ";

                var listaFornecedor = new List<FornecedorModel>();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var fornecedorModel = new FornecedorModel()
                    {
                        IdFornecedor = int.Parse(reader["id_fornecedor"].ToString()),
                        NomePessoa = reader["nome_pessoa"].ToString()
                    };
                    listaFornecedor.Add(fornecedorModel);
                }

                return listaFornecedor;
            }
            finally
            {
                cmd.Dispose();
                if(conexaoFirebid.State != ConnectionState.Closed)
                    conexaoFirebid.Close();
            }
        }
    }
}
