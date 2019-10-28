using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Text;

namespace ProjetoDesafio.Feature.Fornecedor.Dao
{
    public class FornecedorDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Fornecedor";
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

        public bool Cadastrar(Model.FornecedorModel fornecedor, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Fornecedor (razao_social, representante,celular_represetante,email_representante, id_pessoa) ");
            commandText.Append("Values(@RazaoSocial, @Representante, @CelularRepresentante, @EmailRepresentante, @IdPessoa)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@RazaoSocial", FbDbType.VarChar).Value = fornecedor.RazaoSocial;
            cmd.Parameters.Add("@Representante", FbDbType.VarChar).Value = fornecedor.Representante;
            cmd.Parameters.Add("@CelularRepresentante", FbDbType.VarChar).Value = fornecedor.CelularRepresentante;
            cmd.Parameters.Add("@EmailRepresentante", FbDbType.VarChar).Value = fornecedor.EmailRepresentante;
            cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = fornecedor.IdPessoa;

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
