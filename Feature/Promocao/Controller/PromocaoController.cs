using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Promocao.Dao;
using ProjetoDesafio.Feature.Promocao.Model;

namespace ProjetoDesafio.Feature.Promocao.Controller
{
    public class PromocaoController
    {
        public bool Cadastrar(PromocaoModel promocao)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                cmd.Transaction = conexaoFireBird.BeginTransaction();

                var commit = new PromocaoDao().Cadastrar(promocao, cmd);

                if (commit)
                {
                    MessageBox.Show(@"Promoção cadastrado com sucesso.");
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
                MessageBox.Show($@"Erro ao cadastrar promoção: {e.Message}");
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

        public IEnumerable<PromocaoModel> Listar()
        {
            try
            {
                return new PromocaoDao().Listar();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar promoção : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar promoção : {e.Message}");
            }

            return new List<PromocaoModel>();
        }
    }
}

