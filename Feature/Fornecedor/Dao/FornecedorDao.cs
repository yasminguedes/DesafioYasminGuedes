using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Fornecedor.Model;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ProjetoDesafio.Feature.Endereco.Model;

namespace ProjetoDesafio.Feature.Fornecedor.Dao
{
    public class FornecedorDao
    {
        public bool Cadastrar(FornecedorModel fornecedor, FbCommand cmd)
        {
            cmd.Parameters.Add("@RazaoSocial", FbDbType.VarChar).Value = fornecedor.RazaoSocial;
            cmd.Parameters.Add("@Representante", FbDbType.VarChar).Value = fornecedor.Representante;
            cmd.Parameters.Add("@CelularRepresentante", FbDbType.VarChar).Value = fornecedor.CelularRepresentante;
            cmd.Parameters.Add("@EmailRepresentante", FbDbType.VarChar).Value = fornecedor.EmailRepresentante;
            cmd.Parameters.Add("@IdPessoa", FbDbType.Integer).Value = fornecedor.IdPessoa;

            cmd.CommandText =
                @"INSERT into Fornecedor (razao_social, representante,celular_represetante,email_representante, id_pessoa)
                                Values(@RazaoSocial, @Representante, @CelularRepresentante, @EmailRepresentante, @IdPessoa)";

            cmd.ExecuteNonQuery();
            return true;
        }

        internal IEnumerable<FornecedorModel> Listar(FornecedorFiltroModel filtro)
        {
            using (var conexaoFireBird = Connection.PegarInstancia().PegarConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    var cmd = new FbCommand { Connection = conexaoFireBird };

                    var sql = new StringBuilder();
                     sql.Append(@"Select * from Fornecedor f INNER JOIN pessoa AS p on f.id_pessoa = p.id_pessoa 
                                     inner join endereco as e on p.id_endereco = e.id_endereco");


                    if (filtro.PesquisarPorNomeFantasia)
                    {
                        sql.Append(" WHERE Upper(p.nome_pessoa) LIKE Upper(@NomePessoa)");
                        cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = $"{filtro.NomePessoa}%";
                    }
                    else if (filtro.PesquisarPorRazaoSocial)
                    {
                        sql.Append(" WHERE Upper(f.razao_social) LIKE Upper(@RazaoSocial)");
                        cmd.Parameters.Add("@RazaoSocial", FbDbType.VarChar).Value = $"{filtro.RazaoSocial}%";
                    }
                    else
                    {
                        sql.Append(" WHERE Upper(f.representante) LIKE Upper(@representante)");
                        cmd.Parameters.Add("@Representante", FbDbType.VarChar).Value = $"{filtro.Representante}%";
                    }

                    cmd.CommandText = sql.ToString();

                    var dr = cmd.ExecuteReader();

                    var listaFornecedor = new List<FornecedorModel>();
                    while (dr.Read())
                    {
                        var fornecedorModel = new FornecedorModel()
                        {
                            IdFornecedor = int.Parse(dr["id_fornecedor"].ToString()),
                            NomePessoa = dr["nome_pessoa"].ToString(),
                            RazaoSocial = dr["razao_social"].ToString(),
                            RgIe = dr["rg_ie"].ToString(),
                            CpfCnpj = dr["cpf_cnpj"].ToString(),
                            EmailPessoa = dr["email_pessoa"].ToString(),
                            Representante = dr["representante"].ToString(),
                            TelefonePessoa = dr["telefone_pessoa"].ToString(),
                            CelularRepresentante = dr["celular_represetante"].ToString(),
                            EmailRepresentante = dr["email_representante"].ToString(),
                            Endereco = new EnderecoModel()
                            {
                                IdEndereco = int.Parse(dr["id_endereco"].ToString()),
                                Rua = dr["rua"].ToString(),
                                Numero = dr["numero"].ToString(),
                                Bairro = dr["bairro"].ToString(),
                                Cidade = dr["cidade"].ToString(),
                                Estado = dr["estado"].ToString()
                            }
                        };
                        listaFornecedor.Add(fornecedorModel);
                    }

                    return listaFornecedor;
                }
                finally
                {
                    if (conexaoFireBird.State != ConnectionState.Closed)
                        conexaoFireBird.Close();
                }
            }
            
        }
    }
}
