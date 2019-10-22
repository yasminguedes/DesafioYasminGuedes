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
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            {
               conexaoFireBird.Open();
               const string mSql = @"INSERT into Endereco (cep, rua, numero, complemento, bairro, cidade, estado, pais )
                                    Values(@Cep, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Pais )";

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
        }
    }
}

