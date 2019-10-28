using System;
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
    public class FornecedorController:PessoaModel
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

                cmd = EnderecoDao.Cadastrar(fornecedor.Endereco, cmd);
                cmd = PessoaDao.Cadastrar(fornecedor, cmd);

                var cadastro = new FornecedorDao().Cadastrar(fornecedor, cmd);

                if (cadastro)
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
    }
}
