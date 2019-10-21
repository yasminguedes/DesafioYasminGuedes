using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Endereco.Dao
{
    public class EnderecoDao
    {
        public static DataTable RecuperarEnderecos()
        {
            var conexaoFirebird = Connection.GetInstancia().GetConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Endereco";
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

        public static FbCommand Cadastrar(Model.EnderecoModel endereco, FbCommand cmd)
        {
            const string mSql = @"INSERT into Endereco (cep, rua, numero, complemento, bairro, cidade, estado, pais )
                                    Values(@Cep, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Pais ) returning id_endereco";

            cmd.CommandText = mSql;

            cmd.Parameters.Add("@Cep", FbDbType.VarChar).Value = endereco.Cep;
            cmd.Parameters.Add("@Rua", FbDbType.VarChar).Value = endereco.Rua;
            cmd.Parameters.Add("@Numero", FbDbType.VarChar).Value = endereco.Numero;
            cmd.Parameters.Add("@Complemento", FbDbType.VarChar).Value = endereco.Complemento;
            cmd.Parameters.Add("@Bairro", FbDbType.VarChar).Value = endereco.Bairro;
            cmd.Parameters.Add("@Cidade", FbDbType.VarChar).Value = endereco.Cidade;
            cmd.Parameters.Add("@Estado", FbDbType.Integer).Value = endereco.Estado;
            cmd.Parameters.Add("@Pais", FbDbType.Integer).Value = endereco.Pais;

            endereco.IdEndereco = int.Parse(cmd.ExecuteScalar().ToString());
            return cmd;
        }

        public static Model.EnderecoModel Listar(int id)
        {
            using (var conexaoFireBird = Connection.GetInstancia().GetConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var mSql = "Select * from Endereco Where id_endereco = " + id;
                    var cmd = new FbCommand(mSql, conexaoFireBird);
                    var dr = cmd.ExecuteReader();
                    var endereco = new Model.EnderecoModel();
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
                catch (FbException)
                {
                    throw;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public static void Alterar(Model.EnderecoModel endereco)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            {
                try
                {
                    conexaoFireBird.Open();
                    const string mSql = @"Update Endereco set cep= @Cep, rua= @Rua, numero= @Numero, complemento= @Complemento,
                                    bairro= @bairro, cidade= @Cidade, estado= @Estado, pais= @Pais WHERE id_endereco= @IdEndereco";
                    var cmd = new FbCommand(mSql, conexaoFireBird);

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
                catch (FbException)
                {
                    throw;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
}
