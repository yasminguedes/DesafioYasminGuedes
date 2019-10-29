using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Produto.Model;

namespace ProjetoDesafio.Feature.Produto.Dao
{
    public class ProdutoDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Produto";
                    var cmd = new FbCommand(mSql, conexaoFirebird);
                    var da = new FbDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                finally
                {
                    conexaoFirebird.Close();
                }
            }
        }

        public bool Cadastrar(ProdutoModel produto, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Produto (nome_produto, preco_compra, preco_venda, qtde_estoque, ativo, data_cadastro, 
                                tipo_produto, id_fornecedor, id_marca, id_categoria)");
            commandText.Append(@"NomeProduto, PrecoCompra, PrecoVenda, QtdeEstoque, Ativo, DataCadastro, TipoProduto, Fornecedor, Marca, Categoria");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@NomeProduto", FbDbType.VarChar).Value = produto.NomeProduto;
            cmd.Parameters.Add("@PrecoCompra", FbDbType.Double).Value = produto.PrecoCompra;
            cmd.Parameters.Add("@PrecoVenda", FbDbType.Double).Value = produto.PrecoVenda;
            cmd.Parameters.Add("@QtdeEstoque", FbDbType.Integer).Value = produto.Qtde;
            cmd.Parameters.Add("@Ativo", FbDbType.VarChar).Value = produto.Ativo;
            cmd.Parameters.Add("@DataCadastro", FbDbType.Date).Value = produto.DataCadastro;
            cmd.Parameters.Add("@TipoProduto", FbDbType.VarChar).Value = produto.Tipo;
            cmd.Parameters.Add("@Fornecedor", FbDbType.Integer).Value = produto.Fornecedor.IdFornecedor;
            cmd.Parameters.Add("@Marca", FbDbType.Integer).Value = produto.Marca.IdMarca;
            cmd.Parameters.Add("@Categoria", FbDbType.Integer).Value = produto.Categoria.IdCategoria;

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}

