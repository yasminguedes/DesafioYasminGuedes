using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Endereco.Dao;
using ProjetoDesafio.Feature.Fornecedor.Dao;
using ProjetoDesafio.Feature.Fornecedor.Model;
using ProjetoDesafio.Feature.Pessoa.Dao;
using ProjetoDesafio.Feature.Pessoa.Model;

namespace ProjetoDesafio.Feature.Fornecedor.Controller
{
    public class FornecedorController : PessoaModel
    {
        public bool Cadastrar(FornecedorModel fornecedor)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                cmd.Transaction = conexaoFireBird.BeginTransaction();

                var commit = new EnderecoDao().Cadastrar(fornecedor.Endereco, cmd) &&
                             new PessoaDao().Cadastrar(fornecedor, cmd) &&
                             new FornecedorDao().Cadastrar(fornecedor, cmd);

                if (commit)
                {
                    MessageBox.Show(@"Fornecedor cadastrado com sucesso.");
                    cmd.Transaction.Commit();
                    return true;
                }

                MessageBox.Show(@"Erro ao cadastrar");
                cmd.Transaction.Rollback();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao salvar cadastro: {fbex.Message}");
                cmd.Transaction.Rollback();
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao cadastrar funcionário: {e.Message}");
                cmd.Transaction.Rollback();
            }
            finally
            {
                cmd.Dispose();
                if (conexaoFireBird.State != ConnectionState.Closed)
                    conexaoFireBird.Close();
            }

            return false;

        }

        public IEnumerable<FornecedorModel> Listar(FornecedorFiltroModel filtro = null)
        {
            try
            {
                filtro = filtro ?? new FornecedorFiltroModel();
                return new FornecedorDao().Listar(filtro);
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar fornecedor: {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar fornecedor: {e.Message}");
            }

            return new List<FornecedorModel>();
        }
    }
}
