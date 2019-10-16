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
                    string mSQL = "Select * from Pessoa";
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

        public static void fb_InserirDados(Pessoa pessoa)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "INSERT into Pessoa Values(" + pessoa.idPessoa + ", " + pessoa.nomePessoa + "," +
                                  pessoa.sexo + "," + pessoa.rgIe + "," + pessoa.cpfCnpj + "," + pessoa.emailPessoa + "," +
                                  pessoa.telefonePessoa + "," + pessoa.Endereco.idEndereco + ")";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
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

        public static Endereco fb_ProcuraDados(int id)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Select * from Pessoa Where id_pessoa = " + id;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Endereco endereco = new Endereco();
                    while (dr.Read())
                    {
                        endereco.idEndereco = Convert.ToInt32(dr[0]);
                        endereco.cep = dr[1].ToString();
                        endereco.rua = dr[2].ToString();
                        endereco.numero = dr[3].ToString();
                        endereco.complemento = dr[4].ToString();
                        endereco.bairro = dr[5].ToString();
                        endereco.cidade = dr[6].ToString();
                        endereco.estado = dr[7].ToString();
                        endereco.pais = dr[8].ToString();
                    }

                    return endereco;
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

        public static void fb_AlterarDados(Endereco endereco)
        {
            using (FbConnection conexaoFireBird = Connection.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "Update Endereco set cep=" + endereco.cep + ", endereco=" + endereco.rua
                                  + ", endereco=" + endereco.numero + ", endereco=" + endereco.complemento +
                                  ", endereco=" + endereco.bairro + "endereco=" + endereco.cidade + ", endereco="
                                  + endereco.estado + ", endereco=" + endereco.pais + "Where id_endereco=" +
                                  endereco.idEndereco;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
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
