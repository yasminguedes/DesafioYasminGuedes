using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Pessoa.Dao
{
    public class PessoaDao
    {
        public static DataTable GetDados()
        {
            using (FbConnection conexaoFirebird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSql = @"Select * from Pessoa";
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

        public static int Cadastrar(Pessoa.Model.Pessoa pessoa)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"INSERT into Pessoa (nome_pessoa, sexo, rg_ie, cpf_cnpj, email_pessoa, telefone_pessoa, id_endereco)
                                    Values(@NomePessoa, @Sexo, @RgIe, @CpfCnpj, @EmailPessoa, @TelefonePessoa, @Endereco) RETURNING id_pessoa";

                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.NomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.Sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.RgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.CpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.Endereco;

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

        public static Pessoa.Model.Pessoa Listar(int idP)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"Select * from Pessoa p INNER JOIN endereco AS e on p.id_endereco = e.id_endereco Where id_pessoa = " + idP;
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Pessoa.Model.Pessoa pessoa = new Pessoa.Model.Pessoa();
                    while (dr.Read())
                    {
                        pessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
                        pessoa.NomePessoa = dr["nome_pessoa"].ToString();
                        pessoa.Sexo = dr["sexo"].ToString();
                        pessoa.RgIe = dr["rg_ie"].ToString();
                        pessoa.CpfCnpj = dr["cpf_cnpj"].ToString();
                        pessoa.EmailPessoa = dr["email_pessoa"].ToString();
                        pessoa.TelefonePessoa = dr["telefone_pessoa"].ToString();
                        pessoa.Endereco = Convert.ToInt32(dr["id_endereco"]);
                      
                    }

                    return pessoa;
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

        public static void Alterar(Pessoa.Model.Pessoa pessoa)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"Update Pessoa set nome_pessoa= @NomePessoa, sexo= @Sexo, rg_ie= @RgIe, cpf_cnpj= @CpfCnpj,
                                    email_pessoa= @EmailPessoa, telefone_pessoa= @TelefonePessoa,
                                    id_endereco= @Endereco WHERE id_pessoa= @IdPessoa";
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.NomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.Sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.RgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.CpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.EmailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.Endereco;

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
