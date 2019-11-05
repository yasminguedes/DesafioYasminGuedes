using System;
using System.Collections.Generic;
using System.Data;
using ProjetoDesafio.Feature.Endereco.Dao;
using ProjetoDesafio.Feature.Funcionario.Dao;
using ProjetoDesafio.Feature.Funcionario.Model;
using ProjetoDesafio.Feature.Pessoa.Dao;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Controller;
using ProjetoDesafio.Feature.Cargo.Model;


namespace ProjetoDesafio.Feature.Funcionario.Controller
{
    public class FuncionarioController
    {
        public bool Cadastrar(FuncionarioModel funcionario)
        {
            if (!funcionario.SenhasIguais)
            {
                MessageBox.Show(@"Senhas não conferem");
                return false;
            }

            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                cmd.Transaction = conexaoFireBird.BeginTransaction();

                var commit = new EnderecoDao().Cadastrar(funcionario.Endereco, cmd) &&
                            new PessoaDao().Cadastrar(funcionario, cmd) &&
                            new FuncionarioDao().Cadastrar(funcionario, cmd);

                if (commit)
                {
                    MessageBox.Show(@"Funcionário cadastrado com sucesso.");
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

        public IEnumerable<CargoModel> ListarCargos() =>
            new CargoController().Listar();

        public IEnumerable<FuncionarioModel> Listar(FuncionarioFiltroModel filtro)
        {
            try
            {
                return new FuncionarioDao().Listar(filtro);
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar funcionario : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar funcionario: {e.Message}");
            }
            return new List<FuncionarioModel>();
        }
    }
   
}

