using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Funcionario.Dao
{
    public class FuncionarioDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.GetInstancia().GetConexao();
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
        public static int Cadastrar(Model.FuncionarioModel funcionario)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            conexaoFireBird.Open();

            var commandText = new StringBuilder();

            var transaction = conexaoFireBird.BeginTransaction();
            var cmd = new FbCommand(commandText.ToString(), conexaoFireBird, transaction);

            commandText.Append(@"INSERT into Funcionario (usuario_funcionario, senha_funcionario, id_pessoa, id_cargo");
            commandText.Append("Values(@UsuarioFuncionario, @SenhaFuncionario, @IdPessoa, @Cargo) RETURNING id_funcionario");

            try
            {
                    cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
                    cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
                    cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = funcionario.IdPessoa;
                    cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = funcionario.Cargo;
                    
                
                    var idFuncionario = int.Parse(cmd.ExecuteScalar().ToString());
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return idFuncionario;
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

        public static Model.FuncionarioModel Listar(int idFn)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
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
                        funcionario.Cargo = Convert.ToInt32(dr["id_cargo"]);

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
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
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
                    cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value =funcionario.IdPessoa;
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

