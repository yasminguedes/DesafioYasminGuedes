using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Categoria.Model;

namespace ProjetoDesafio.Feature.Categoria.Dao
{
    public class CategoriaDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Categoria";
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

        public bool Cadastrar(CategoriaModel categoria, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Categoria (nome_categoria) ");
            commandText.Append("Values(@Categoria)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@Categoria", FbDbType.VarChar).Value = categoria.NomeCategoria;

            cmd.ExecuteNonQuery();

            return true;
        }

        internal IEnumerable<CategoriaModel> Listar()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();

            try
            {
                cmd.CommandText = @"Select * from Categoria";
                cmd.Connection = conexaoFirebird;

                var listaCategoria = new List<CategoriaModel>();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var categoriaModel = new CategoriaModel
                    {
                        IdCategoria = int.Parse(reader["id_categoria"].ToString()),
                        NomeCategoria = reader["nome_categoria"].ToString()
                    };
                    listaCategoria.Add(categoriaModel);
                }

                return listaCategoria;
            }
            finally
            {
                cmd.Dispose();
                if(conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        } 
    }
}
