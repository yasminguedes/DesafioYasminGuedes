using System;
using System.Collections.Generic;
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
            try
            {
                if (new ProdutoDao().Cadastrar(produto))
                {
                    MessageBox.Show(@"Produto cadastrado com sucesso");
                    return true;
                }

                MessageBox.Show(@"Erro ao cadastrar");
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao salvar cadastro: {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao cadastrar produto: {e.Message}");
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
