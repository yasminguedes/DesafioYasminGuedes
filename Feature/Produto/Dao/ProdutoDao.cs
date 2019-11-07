using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Categoria.Model;
using ProjetoDesafio.Feature.Fornecedor.Model;
using ProjetoDesafio.Feature.Marca.Model;
using ProjetoDesafio.Feature.Produto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoDesafio.Feature.Produto.Dao
{
    public class ProdutoDao
    {
        public bool Cadastrar(ProdutoModel produto)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                var commandText = new StringBuilder();

                commandText.Append(
                    @"INSERT into Produto (nome_produto, preco_compra, preco_venda, qtde_estoque, ativo, data_cadastro, 
                                tipo_produto, codigo, data_validade, id_fornecedor, id_marca, id_categoria) Values ");
                commandText.Append(@"(@NomeProduto, @PrecoCompra, @PrecoVenda, @QtdeEstoque, @Ativo, @DataCadastro, 
                                    @TipoProduto, @Codigo,@DataValidade, @Fornecedor, @Marca, @Categoria)");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@NomeProduto", FbDbType.VarChar).Value = produto.NomeProduto;
                cmd.Parameters.Add("@PrecoCompra", FbDbType.Numeric).Value = produto.PrecoCompra;
                cmd.Parameters.Add("@PrecoVenda", FbDbType.Numeric).Value = produto.PrecoVenda;
                cmd.Parameters.Add("@QtdeEstoque", FbDbType.Integer).Value = produto.Qtde;
                cmd.Parameters.Add("@Ativo", FbDbType.VarChar).Value = produto.Ativo;
                cmd.Parameters.Add("@DataCadastro", FbDbType.Date).Value = produto.DataCadastro;
                cmd.Parameters.Add("@TipoProduto", FbDbType.VarChar).Value = produto.Tipo;
                cmd.Parameters.Add("@Codigo", FbDbType.Integer).Value = produto.Codigo;
                cmd.Parameters.Add("@DataValidade", FbDbType.Date).Value = produto.DataValidade;
                cmd.Parameters.Add("@Fornecedor", FbDbType.Integer).Value = produto.Fornecedor.IdFornecedor;
                cmd.Parameters.Add("@Marca", FbDbType.Integer).Value = produto.Marca.IdMarca;
                cmd.Parameters.Add("@Categoria", FbDbType.Integer).Value = produto.Categoria.IdCategoria;

                cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                cmd.Dispose();
                if (conexaoFireBird.State != ConnectionState.Closed)
                    conexaoFireBird.Close();
            }
        }

        internal IEnumerable<ProdutoModel> Listar(ProdutoFiltroModel filtro)
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();
            try
            {
                cmd.Connection = conexaoFirebird;

                var sql = new StringBuilder();
                sql.Append(@"Select * from Produto p inner join categoria as c on p.id_categoria = c.id_categoria 
                            inner join marca as m on p.id_marca = m.id_marca 
                            inner join fornecedor as f on p.id_fornecedor = f.id_fornecedor
                            inner join pessoa as pe on f.id_pessoa = pe.id_pessoa");

                if (filtro.PesquisarPorNomeProduto)
                {
                    sql.Append(" WHERE Upper(p.Nome_Produto) LIKE Upper(@NomeProduto)");
                    cmd.Parameters.Add("@NomeProduto", FbDbType.VarChar).Value = $"{filtro.NomeProduto}%";
                }
                else if (filtro.PesquisarPorMarca)
                {
                    sql.Append(" WHERE Upper(m.Nome_Marca) LIKE Upper(@NomeMarca)");
                    cmd.Parameters.Add("@NomeMarca", FbDbType.VarChar).Value = $"{filtro.Marca.NomeMarca}%";
                }
                else if (filtro.PesquisarPorCodigo)
                {
                    sql.Append(" WHERE p.Codigo = @Codigo");
                    cmd.Parameters.Add("@Codigo", FbDbType.Integer).Value = filtro.Codigo;
                }
                else if (filtro.PesquisarPorValidade)
                {
                    sql.Append(" WHERE p.Data_Validade = @DataValidade");
                    cmd.Parameters.Add("@DataValidade", FbDbType.Date).Value = filtro.DataValidade;
                }
                else
                {
                    sql.Append(" WHERE Upper(c.Nome_Categoria) LIKE Upper(@NomeCategoria)");
                    cmd.Parameters.Add("@NomeCategoria", FbDbType.VarChar).Value = $"{filtro.Categoria.NomeCategoria}%";
                }

                cmd.CommandText = sql.ToString();

                var dr = cmd.ExecuteReader();

                var listaProduto = new List<ProdutoModel>();
                while (dr.Read())
                    listaProduto.Add(new ProdutoModel
                    {
                        IdProduto = int.Parse(dr["id_produto"].ToString()),
                        NomeProduto = dr["nome_produto"].ToString(),
                        PrecoCompra = double.Parse(dr["preco_compra"].ToString()),
                        PrecoVenda = double.Parse(dr["preco_venda"].ToString()),
                        Qtde = int.Parse(dr["qtde_estoque"].ToString()),
                        Ativo = dr["ativo"].ToString(),
                        DataCadastro = DateTime.Parse(dr["data_cadastro"].ToString()),
                        DataValidade = DateTime.Parse(dr["data_validade"].ToString()),
                        Codigo = int.Parse(dr["codigo"].ToString()),
                        Tipo = dr["tipo_produto"].ToString(),
                        Marca = new MarcaModel()
                        {
                            IdMarca = int.Parse(dr["id_marca"].ToString()),
                            NomeMarca = dr["nome_marca"].ToString()
                        },
                        Categoria = new CategoriaModel()
                        {
                            IdCategoria = int.Parse(dr["id_categoria"].ToString()),
                            NomeCategoria = dr["nome_categoria"].ToString()
                        },
                        Fornecedor = new FornecedorModel()
                        {
                            IdFornecedor = int.Parse(dr["id_fornecedor"].ToString()),
                            NomePessoa = dr["nome_pessoa"].ToString()
                        }
                    });

                return listaProduto;
            }
            finally
            {
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        }
    }
}

