using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Model;
using ProjetoDesafio.Feature.Cliente.Model;
using ProjetoDesafio.Feature.Endereco.Model;
using ProjetoDesafio.Feature.Funcionario.Model;

namespace ProjetoDesafio.Feature.Cliente.Dao
{
    public class ClienteDao
    {
        public bool Cadastrar(ClienteModel cliente, FbCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Profissao", FbDbType.VarChar).Value = cliente.ProfissaoCliente;
            cmd.Parameters.Add("@DataCadastro", FbDbType.Date).Value = cliente.DataCadastro;
            cmd.Parameters.Add("@IdPessoa", FbDbType.Integer).Value = cliente.IdPessoa;

            cmd.CommandText = @"INSERT into Cliente (profissao_cliente, data_cadastro_cliente, id_pessoa) 
                                VALUES (@Profissao, @DataCadastro, @IdPessoa)";

            cmd.ExecuteNonQuery();
            return true;
        }

        internal IEnumerable<ClienteModel> Listar(ClienteFiltroModel filtro)
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();
            try
            {
                cmd.Connection = conexaoFirebird;
                var sql = new StringBuilder();
                sql.Append(@"Select * from Cliente c inner join pessoa as p on c.id_pessoa = p.id_pessoa");

                if (filtro.PesquisarPorNome)
                {
                    sql.Append(" WHERE Upper(p.Nome_Pessoa) LIKE Upper(@NomePessoa)");
                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = $"{filtro.NomePessoa}%";
                }
                else if (filtro.PesquisarPorProfissao)
                {
                    sql.Append(" WHERE Upper(c.profissao_cliente) LIKE Upper(@Profissao)");
                    cmd.Parameters.Add("@Profissao", FbDbType.VarChar).Value = $"{filtro.ProfissaoCliente}%";
                }
                else
                {
                    sql.Append(" WHERE Upper(c.data_cadastro_cliente) LIKE Upper(DataCadastro)");
                    cmd.Parameters.Add("@DataCadastro", FbDbType.VarChar).Value = $"{filtro.DataCadastro}%";
                }

                cmd.CommandText = sql.ToString();

                var dr = cmd.ExecuteReader();

                var listaCliente = new List<ClienteModel>();
                while (dr.Read())
                    listaCliente.Add(new ClienteModel()
                    {
                        IdCliente = int.Parse(dr["id_cliente"].ToString()),
                        NomePessoa = dr["nome_pessoa"].ToString(),
                        Sexo = dr["sexo"].ToString(),
                        DataNascimento = DateTime.Parse(dr["data_nascimento"].ToString()),
                        RgIe = dr["rg_ie"].ToString(),
                        CpfCnpj = dr["cpf_cnpj"].ToString(),
                        EmailPessoa = dr["email_pessoa"].ToString(),
                        TelefonePessoa = dr["telefone_pessoa"].ToString(),
                        ProfissaoCliente = dr["profissao_cliente"].ToString(),
                        Endereco = new EnderecoModel
                        {
                            IdEndereco = int.Parse(dr["id_endereco"].ToString()),
                            Cep = dr["cep"].ToString(),
                            Rua = dr["rua"].ToString(),
                            Numero = dr["numero"].ToString(),
                            Complemento = dr["complemento"].ToString(),
                            Cidade = dr["cidade"].ToString(),
                            Estado = dr["estado"].ToString(),
                            Pais = dr["pais"].ToString()
                        },
                        DataCadastro = DateTime.Parse(dr["data_cadastro_cliente"].ToString())
                        });

                return listaCliente;
            }
            finally
            {
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        }
    }
}
