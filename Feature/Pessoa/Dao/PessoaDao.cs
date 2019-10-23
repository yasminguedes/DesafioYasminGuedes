using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio.Feature.Pessoa.Dao
{
    public class PessoaDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
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

        public static FbCommand Cadastrar(Model.PessoaModel pessoa, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Pessoa(nome_pessoa, sexo, rg_ie, cpf_cnpj, email_pessoa, telefone_pessoa, id_endereco, data_nascimento)");
            commandText.Append("Values(@NomePessoa, @Sexo, @RgIe, @CpfCnpj, @EmailPessoa, @TelefonePessoa, @Endereco, @DataNascimento) RETURNING id_pessoa");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = pessoa.NomePessoa;
            cmd.Parameters.Add("@Sexo", FbDbType.VarChar).Value = pessoa.Sexo;
            cmd.Parameters.Add("@RgIe", FbDbType.VarChar).Value = pessoa.RgIe;
            cmd.Parameters.Add("@CpfCnpj", FbDbType.VarChar).Value = pessoa.CpfCnpj;
            cmd.Parameters.Add("@EmailPessoa", FbDbType.VarChar).Value = pessoa.EmailPessoa;
            cmd.Parameters.Add("@TelefonePessoa", FbDbType.VarChar).Value = pessoa.TelefonePessoa;
            cmd.Parameters.Add("@Endereco", FbDbType.Integer).Value = pessoa.Endereco.IdEndereco;
            cmd.Parameters.Add("@DataNascimento", FbDbType.Date).Value = pessoa.DataNascimento;

            pessoa.IdPessoa = int.Parse(cmd.ExecuteScalar().ToString());
            return cmd;


        }

    }

}

