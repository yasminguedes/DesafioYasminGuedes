using System;
using System.Data;
using ProjetoDesafio.Feature.Endereco.Dao;
using ProjetoDesafio.Feature.Funcionario.Dao;
using ProjetoDesafio.Feature.Funcionario.Model;
using ProjetoDesafio.Feature.Pessoa.Dao;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;


namespace ProjetoDesafio.Feature.Funcionario.Controller
{
    public class FuncionarioController
    {
        public bool Cadastrar(FuncionarioModel funcionario)
        {
            var conexaoFireBird = Connection.GetInstancia().GetConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                cmd.Transaction = conexaoFireBird.BeginTransaction();

                cmd = EnderecoDao.Cadastrar(funcionario.Endereco, cmd);
                cmd = PessoaDao.Cadastrar(funcionario, cmd);

                var cadastro = new FuncionarioDao().Cadastrar(funcionario, cmd);

                if (cadastro)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso.");
                    cmd.Transaction.Commit();
                    return true;
                }

                MessageBox.Show("Erro ao cadastrar");
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
