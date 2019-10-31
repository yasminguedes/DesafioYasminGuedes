using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Endereco.Dao
{
    public class EnderecoDao
    {
        public static DataTable RecuperarEnderecos()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
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

        public bool Cadastrar(Model.EnderecoModel endereco, FbCommand cmd)
        {
            cmd.Parameters.Add("@Cep", FbDbType.VarChar).Value = endereco.Cep;
            cmd.Parameters.Add("@Rua", FbDbType.VarChar).Value = endereco.Rua;
            cmd.Parameters.Add("@Numero", FbDbType.VarChar).Value = endereco.Numero;
            cmd.Parameters.Add("@Complemento", FbDbType.VarChar).Value = endereco.Complemento;
            cmd.Parameters.Add("@Bairro", FbDbType.VarChar).Value = endereco.Bairro;
            cmd.Parameters.Add("@Cidade", FbDbType.VarChar).Value = endereco.Cidade;
            cmd.Parameters.Add("@Estado", FbDbType.VarChar).Value = endereco.Estado;
            cmd.Parameters.Add("@Pais", FbDbType.VarChar).Value = endereco.Pais;

            cmd.CommandText = @"INSERT into Endereco (cep, rua, numero, complemento, bairro, cidade, estado, pais )
                                    Values(@Cep, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Pais ) returning id_endereco";

            endereco.IdEndereco = int.Parse(cmd.ExecuteScalar().ToString());

            return true;
        }
    }
}

