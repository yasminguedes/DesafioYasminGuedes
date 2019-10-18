using System;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Pessoa.Dao
{
    public class PessoaDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.GetInstancia().GetConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Pessoa";
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

        public static int Cadastrar(Model.PessoaModel pessoa)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            conexaoFireBird.Open();

            var commandText = new StringBuilder();

            var transaction = conexaoFireBird.BeginTransaction();
            var cmd = new FbCommand(commandText.ToString(), conexaoFireBird, transaction);

            commandText.Append(@"INSERT into Pessoa(nome_pessoa, sexo, rg_ie, cpf_cnpj, email_pessoa, telefone_pessoa, id_endereco");
            commandText.Append("Values(@NomePessoa, @Sexo, @RgIe, @CpfCnpj, @EmailPessoa, @TelefonePessoa, @Endereco) RETURNING id_pessoa");
            
            
                try
                {
                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.NomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.Sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.RgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.CpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.IdEndereco;

                    

                    var idPessoa = int.Parse(cmd.ExecuteScalar().ToString());
                    
                    cmd.ExecuteNonQuery();

                    transaction.Commit();

                    return idPessoa;
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

        public static Model.PessoaModel Listar(int idP)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            {
                try
                {
                    conexaoFireBird.Open();
                    var mSql = @"Select * from Pessoa p INNER JOIN endereco AS e on p.id_endereco = e.id_endereco Where id_pessoa = " + idP;
                    var cmd = new FbCommand(mSql, conexaoFireBird);
                    var dr = cmd.ExecuteReader();
                    var pessoa = new Model.PessoaModel();
                    while (dr.Read())
                    {
                        pessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
                        pessoa.NomePessoa = dr["nome_pessoa"].ToString();
                        pessoa.Sexo = dr["sexo"].ToString();
                        pessoa.RgIe = dr["rg_ie"].ToString();
                        pessoa.CpfCnpj = dr["cpf_cnpj"].ToString();
                        pessoa.EmailPessoa = dr["email_pessoa"].ToString();
                        pessoa.TelefonePessoa = dr["telefone_pessoa"].ToString();
                        pessoa.IdEndereco = Convert.ToInt32(dr["id_endereco"]);
                      
                    }

                    return pessoa;
                }
               
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void Alterar(Model.PessoaModel pessoa)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            conexaoFireBird.Open();

            var commandText = new StringBuilder();

            var transaction = conexaoFireBird.BeginTransaction();
            var cmd = new FbCommand(commandText.ToString(), conexaoFireBird, transaction);
            {
                try
                {
                    conexaoFireBird.Open();
                    const string mSql = @"Update Pessoa set nome_pessoa= @NomePessoa, sexo= @Sexo, rg_ie= @RgIe, cpf_cnpj= @CpfCnpj,
                                    email_pessoa= @EmailPessoa, telefone_pessoa= @TelefonePessoa,
                                    id_endereco= @Endereco WHERE id_pessoa= @IdPessoa";
                    

                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.NomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.Sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.RgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.CpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.IdEndereco;

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
}
