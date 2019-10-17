using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Endereco.Dao
{
    public class EnderecoDao
    {
        public static DataTable RecuperarEnderecos()
        {
            using (var conexaoFirebird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFirebird.Open();
                    var mSql = @"Select * from Endereco";
                    FbCommand cmd = new FbCommand(mSql, conexaoFirebird);
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

        public static int Fb_InserirDados(Model.Endereco endereco)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"INSERT into Endereco (cep, rua, numero, complemento, bairro, cidade, estado, pais )
                                    Values(@Cep, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Pais )";

                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@Cep", FbDbType.VarChar).Value = endereco.Cep;
                    cmd.Parameters.Add("@Rua", FbDbType.VarChar).Value = endereco.Rua;
                    cmd.Parameters.Add("@Numero", FbDbType.VarChar).Value = endereco.Numero;
                    cmd.Parameters.Add("@Complemento", FbDbType.VarChar).Value = endereco.Complemento;
                    cmd.Parameters.Add("@Bairro", FbDbType.VarChar).Value = endereco.Bairro;
                    cmd.Parameters.Add("@Cidade", FbDbType.VarChar).Value = endereco.Cidade;
                    cmd.Parameters.Add("@Estado", FbDbType.Integer).Value = endereco.Estado;
                    cmd.Parameters.Add("@Pais", FbDbType.Integer).Value = endereco.Pais;

                    cmd.ExecuteNonQuery();

                    var idEndereco = int.Parse(cmd.ExecuteScalar().ToString());
                    return idEndereco;
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

        public static Model.Endereco Fb_ProcuraDados(int id)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = "Select * from Endereco Where id_endereco = " + id;
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();
                    Model.Endereco endereco = new Model.Endereco();
                    while (dr.Read())
                    {
                        endereco.IdEndereco = Convert.ToInt32(dr["id_endereco"]);
                        endereco.Cep = dr["cep"].ToString();
                        endereco.Rua = dr["rua"].ToString();
                        endereco.Numero = dr["numero"].ToString();
                        endereco.Complemento = dr["complemento"].ToString();
                        endereco.Bairro = dr["bairro"].ToString();
                        endereco.Cidade = dr["cidade"].ToString();
                        endereco.Estado = dr["estado"].ToString();
                        endereco.Pais = dr["pais"].ToString();
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

        public static void Fb_AlterarDados(Model.Endereco endereco)
        {
            using (FbConnection conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    string mSql = @"Update Endereco set cep= @Cep, rua= @Rua, numero= @Numero, complemento= @Complemento,
                                    bairro= @bairro, cidade= @Cidade, estado= @Estado, pais= @Pais WHERE id_endereco= @IdEndereco";
                    FbCommand cmd = new FbCommand(mSql, conexaoFireBird);

                    cmd.Parameters.Add("@Cep", FbDbType.VarChar).Value = endereco.Cep;
                    cmd.Parameters.Add("@Rua", FbDbType.VarChar).Value = endereco.Rua;
                    cmd.Parameters.Add("@Numero", FbDbType.VarChar).Value = endereco.Numero;
                    cmd.Parameters.Add("@Complemento", FbDbType.VarChar).Value = endereco.Complemento;
                    cmd.Parameters.Add("@Bairro", FbDbType.VarChar).Value = endereco.Bairro;
                    cmd.Parameters.Add("@Cidade", FbDbType.VarChar).Value = endereco.Cidade;
                    cmd.Parameters.Add("@Estado", FbDbType.Integer).Value = endereco.Estado;
                    cmd.Parameters.Add("@Pais", FbDbType.Integer).Value = endereco.Pais;

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
