using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Model;

namespace ProjetoDesafio.DAO
{
    public class PessoaDAO
    {
        public static DataTable fb_GetDados()
        {
            using (FbConnection conexaoFirebird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    string mSQL = @"Select * from Pessoa";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFirebird);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }

        public static int fb_InserirDados(Pessoa pessoa)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = @"INSERT into Pessoa (nome_pessoa, sexo, rg_ie, cpf_cnpj, email_pessoa, telefone_pessoa, id_endereco)
                                    Values(@NomePessoa, @Sexo, @RgIe, @CpfCnpj, @EmailPessoa, @TelefonePessoa, @Endereco) RETURNING id_pessoa";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);

                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.nomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.rgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.cpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.emailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.telefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.Endereco;

                    cmd.ExecuteNonQuery();

                    var idPessoa = int.Parse(cmd.ExecuteScalar().ToString());
                    return idPessoa;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static Pessoa fb_ProcuraDados(int idP)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = @"Select * from Pessoa p INNER JOIN endereco AS e on p.id_endereco = e.id_endereco Where id_pessoa = " + idP;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Pessoa pessoa = new Pessoa();
                    while (dr.Read())
                    {
                        pessoa.idPessoa = Convert.ToInt32(dr["id_pessoa"]);
                        pessoa.nomePessoa = dr["nome_pessoa"].ToString();
                        pessoa.sexo = dr["sexo"].ToString();
                        pessoa.rgIe = dr["rg_ie"].ToString();
                        pessoa.cpfCnpj = dr["cpf_cnpj"].ToString();
                        pessoa.emailPessoa = dr["email_pessoa"].ToString();
                        pessoa.telefonePessoa = dr["telefone_pessoa"].ToString();
                        pessoa.Endereco.idEndereco = Convert.ToInt32(dr["id_endereco"]);
                      
                    }

                    return pessoa;
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void fb_AlterarDados(Pessoa pessoa)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = @"Update Pessoa set nome_pessoa= @NomePessoa, sexo= @Sexo, rg_ie= @RgIe, cpf_cnpj= @CpfCnpj,
                                    email_pessoa= @EmailPessoa, telefone_pessoa= @TelefonePessoa,
                                    id_endereco= @Endereco WHERE id_Pessoa= @IdPessoa";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);

                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.nomePessoa;
                    cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.sexo;
                    cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.rgIe;
                    cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.cpfCnpj;
                    cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.emailPessoa;
                    cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.telefonePessoa;
                    cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.Endereco;

                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
}
