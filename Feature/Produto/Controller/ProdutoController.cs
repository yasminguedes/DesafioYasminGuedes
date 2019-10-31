using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Categoria.Controller;
using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Fornecedor.Controller;
using ProjetoDesafio.Feature.Fornecedor.Model;
using ProjetoDesafio.Feature.Marca.Controller;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Dao;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Produto.Controller
{
    public class ProdutoController
    {
        public bool Cadastrar(ProdutoModel produto)
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFirebird.Open();
                cmd.Connection = conexaoFirebird;
                cmd.Transaction = conexaoFirebird.BeginTransaction();

                var cadastro = new ProdutoDao().Cadastrar(produto, cmd);

                if (cadastro)
                {
                    MessageBox.Show(@"Produto cadastrado com sucesso");
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
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
            return false;
        }

        public IEnumerable<CategoriaModel>ListarCategoria() =>
                new CategoriaController().Listar();

        public IEnumerable<MarcaModel> ListarMarca() =>
            new MarcaController().Listar();

        public IEnumerable<FornecedorModel> ListarFornecedor() =>
            new FornecedorController().Listar();

        public IEnumerable<ProdutoModel> Listar(ProdutoFiltroModel filtro)
        {
            try
            {
                return new ProdutoDao().Listar(filtro);
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar produto : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar produto: {e.Message}");
            }
            return new List<ProdutoModel>();
        }
    }
}
