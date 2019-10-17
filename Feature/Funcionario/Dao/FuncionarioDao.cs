using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Funcionario.Dao
{
    public class FuncionarioDao
    {
        public static DataTable GetDados()
        {
            using (FbConnection conexaoFirebird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSql = @"Select * from Funcionario";
                    FbCommand cmd = new FbCommand(mSql, conexaoFirebird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }
        public static int Cadastrar(Model.Funcionario funcionario)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"INSERT into Funcionario (usuario_funcionario, senha_funcionario, id_pessoa, id_cargo)
                                    Values(@UsuarioFuncionario, @SenhaFuncionario, @IdPessoa, @Cargo) RETURNING id_funcionario";

                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
                    cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
                    cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = funcionario.IdPessoa;
                    cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = funcionario.Cargo;
                    

                    cmd.ExecuteNonQuery();

                    var idPessoa = int.Parse(cmd.ExecuteScalar().ToString());
                    return idPessoa;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Model.Funcionario Listar(int idFn)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"Select * from Funcionario fn INNER JOIN pessoa AS p on fn.id_pessoa = p.id_pessoa Where id_funcionario = " + idFn;
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Model.Funcionario funcionario = new Model.Funcionario();
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
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void Alterar(Model.Funcionario funcionario)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"Update Funcionario set usuario_funcionario= @UsuarioFuncionario, senha_funcionario= @SenhaFuncionario,
                                    id_pessoa= @IdPessoa, id_cargo= @Cargo WHERE id_funcionario= @IdFuncionario";
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
                    cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
                    cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value =funcionario.IdPessoa;
                    cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = funcionario.Cargo;
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

    }
}
