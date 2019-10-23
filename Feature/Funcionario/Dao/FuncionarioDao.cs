using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Text;

namespace ProjetoDesafio.Feature.Funcionario.Dao
{
    public class FuncionarioDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Funcionario";
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
        public bool Cadastrar(Model.FuncionarioModel funcionario, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Funcionario (usuario_funcionario, senha_funcionario, id_pessoa) ");
            commandText.Append("Values(@UsuarioFuncionario, @SenhaFuncionario, @IdPessoa)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
            cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
            cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = funcionario.IdPessoa;

            cmd.ExecuteNonQuery();
            return true;
        }

        public static Model.FuncionarioModel Listar(int idFn)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFireBird.Open();
                    var mSql = @"Select * from Funcionario fn INNER JOIN pessoa AS p on fn.id_pessoa = p.id_pessoa Where id_funcionario = " + idFn;
                    var cmd = new FbCommand(mSql, conexaoFireBird);
                    var dr = cmd.ExecuteReader();
                    var funcionario = new Model.FuncionarioModel();
                    while (dr.Read())
                    {
                        funcionario.IdFuncionario = Convert.ToInt32(dr["id_funcionario"]);
                        funcionario.UsuarioFuncionario = dr["usuario_funcionario"].ToString();
                        funcionario.SenhaFuncionario = dr["senha_funcionario"].ToString();
                        funcionario.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
                        funcionario.Cargo.IdCargo = Convert.ToInt32(dr["id_cargo"]);

                    }

                    return funcionario;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void Alterar(Model.FuncionarioModel funcionario)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            conexaoFireBird.Open();

            var commandText = new StringBuilder();

            var transaction = conexaoFireBird.BeginTransaction();
            var cmd = new FbCommand(commandText.ToString(), conexaoFireBird, transaction);
            try
            {
                const string mSql = @"Update Funcionario set usuario_funcionario= @UsuarioFuncionario, senha_funcionario= @SenhaFuncionario,
                                    id_pessoa= @IdPessoa, id_cargo= @Cargo WHERE id_funcionario= @IdFuncionario";

                cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
                cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
                cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = funcionario.IdPessoa;
                cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = funcionario.Cargo;

                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                cmd.Dispose();
                conexaoFireBird.Close();
            }
        }
    }
}

