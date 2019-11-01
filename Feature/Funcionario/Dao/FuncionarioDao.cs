using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ProjetoDesafio.Feature.Cargo.Model;
using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Endereco.Model;
using ProjetoDesafio.Feature.Fornecedor.Model;
using ProjetoDesafio.Feature.Funcionario.Model;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Funcionario.Dao
{
    public class FuncionarioDao
    {
        public bool Cadastrar(FuncionarioModel funcionario, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Funcionario (usuario_funcionario, senha_funcionario, id_pessoa,id_cargo) ");
            commandText.Append("Values(@UsuarioFuncionario, @SenhaFuncionario, @IdPessoa,@IdCargo)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
            cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
            cmd.Parameters.Add("@IdPessoa", FbDbType.Integer).Value = funcionario.IdPessoa;
            cmd.Parameters.Add("@IdCargo", FbDbType.Integer).Value = funcionario.Cargo.IdCargo;

            cmd.ExecuteNonQuery();
            return true;
        }


        internal IEnumerable<FuncionarioModel> Listar(FuncionarioFiltroModel filtro)
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();
            try
            {
                var sql = new StringBuilder();
                sql.Append(@"Select * from Funcionario f inner join cargo as c on f.id_cargo = c.id_cargo
                            inner join pessoa as p on f.id_pessoa = p.id_pessoa
                            inner join endereco as e on p.id_endereco = e.id_endereco");

                if (filtro.PesquisarPorNome)
                {
                    sql.Append(" WHERE Upper(p.Nome_Pessoa) LIKE Upper(@NomePessoa)");
                    cmd.Parameters.Add("@NomePessoa", FbDbType.VarChar).Value = $"{filtro.NomePessoa}%";
                }
                else if (filtro.PesquisarPorCargo)
                {
                    sql.Append(" WHERE Upper(c.Nome_Cargo) LIKE Upper(@NomeCargo)");
                    cmd.Parameters.Add("@NomeCargo", FbDbType.VarChar).Value = $"{filtro.Cargo.NomeCargo}%";
                }
                else
                {
                    sql.Append(" WHERE Upper(f.Usuario_Funcionario) LIKE Upper(@UsuarioFuncionario)");
                    cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = $"{filtro.UsuarioFuncionario}%";
                }

                cmd.CommandText = sql.ToString();

                var dr = cmd.ExecuteReader();

                var listaFuncionario = new List<FuncionarioModel>();
                while (dr.Read())
                    listaFuncionario.Add(new FuncionarioModel
                    {
                        IdFuncionario = int.Parse(dr["id_funcionario"].ToString()),
                        NomePessoa = dr["nome_pessoa"].ToString(),
                        Sexo = dr["sexo"].ToString(),
                        DataNascimento = DateTime.Parse(dr["data_nascimento"].ToString()),
                        RgIe = dr["rg_ie"].ToString(),
                        CpfCnpj = dr["cpf_cnpj"].ToString(),
                        EmailPessoa = dr["email_pessoa"].ToString(),
                        TelefonePessoa = dr["telefone_pessoa"].ToString(),
                        Cargo = new CargoModel
                        {
                            IdCargo = int.Parse(dr["id_cargo"].ToString()),
                            NomeCargo = dr["nome_cargo"].ToString()
                        },
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
                        UsuarioFuncionario = dr["usuario_funcionario"].ToString(),
                        SenhaFuncionario = dr["senha_funcinario"].ToString()
                    });

                return listaFuncionario;
            }
            finally
            {
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        }

        public static void Alterar(FuncionarioModel funcionario)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            conexaoFireBird.Open();

            var commandText = new StringBuilder();

            var transaction = conexaoFireBird.BeginTransaction();
            var cmd = new FbCommand(commandText.ToString(), conexaoFireBird, transaction);
            try
            {
                const string mSql = @"Update Funcionario set usuario_funcionario= @UsuarioFuncionario, senha_funcionario= @SenhaFuncionario,
                                    id_pessoa= @IdPessoa, id_cargo= @Cargo WHERE id_funcionario= @IdFuncionario";

                cmd.Parameters.Add("@UsuarioFuncionario", FbDbType.VarChar).Value = funcionario.UsuarioFuncionario;
                cmd.Parameters.Add("@SenhaFuncionario", FbDbType.VarChar).Value = funcionario.SenhaFuncionario;
                cmd.Parameters.Add("@IdPessoa", FbDbType.VarChar).Value = funcionario.IdPessoa;
                cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = funcionario.Cargo;

                cmd.CommandText = mSql;

                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                cmd.Dispose();
                conexaoFireBird.Close();
            }
        }
    }
}

