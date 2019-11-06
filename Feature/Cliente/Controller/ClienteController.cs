using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cliente.Dao;
using ProjetoDesafio.Feature.Cliente.Model;
using ProjetoDesafio.Feature.Endereco.Dao;
using ProjetoDesafio.Feature.Pessoa.Dao;

namespace ProjetoDesafio.Feature.Cliente.Controller
{
    public class ClienteController
    {
        public bool Cadastrar(ClienteModel cliente)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                cmd.Transaction = conexaoFireBird.BeginTransaction();

                var commit = new EnderecoDao().Cadastrar(cliente.Endereco, cmd) && 
                            new PessoaDao().Cadastrar(cliente, cmd) && 
                            new ClienteDao().Cadastrar(cliente, cmd);

                if (commit)
                {
                    cmd.Transaction.Commit();
                    MessageBox.Show(@"Cliente cadastrado com sucesso!");
                    return true;
                }

                MessageBox.Show(@"Erro ao cadastrar!");
                cmd.Transaction.Rollback();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao salvar cadastro: {fbex.Message}");
                cmd.Transaction.Rollback();
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao cadastrar Cliente : {e.Message}");
                cmd.Transaction.Rollback();
            }
            finally
            {
                cmd.Dispose();
                if(conexaoFireBird.State != ConnectionState.Closed)
                    conexaoFireBird.Close();
            }

            return false;
        }

        public IEnumerable<ClienteModel> Listar(ClienteFiltroModel filtro)
        {
            try
            {
                return new ClienteDao().Listar(filtro);
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar cliente : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar cliente: {e.Message}");
            }
            return new List<ClienteModel>();
        }
    }
}
