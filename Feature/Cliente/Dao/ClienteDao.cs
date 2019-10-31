﻿using System.Data;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cliente.Model;

namespace ProjetoDesafio.Feature.Cliente.Dao
{
    public class ClienteDao
    {

        public static DataTable PegarDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Cliente";
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

        public bool Cadastrar(ClienteModel cliente, FbCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Profissao", FbDbType.VarChar).Value = cliente.ProfissaoCliente;
            cmd.Parameters.Add("@DataCadastro", FbDbType.Date).Value = cliente.DataCadastro;
            cmd.Parameters.Add("@IdPessoa", FbDbType.Integer).Value = cliente.IdPessoa;

            cmd.CommandText = @"INSERT into Cliente (profissao_cliente, data_cadastro_cliente, id_pessoa) 
                                VALUES (@Profissao, @DataCadastro, @IdPessoa)";

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}