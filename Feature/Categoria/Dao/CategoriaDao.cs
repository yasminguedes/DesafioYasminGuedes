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
        public bool Cadastrar(CategoriaModel categoria)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                var commandText = new StringBuilder();
                commandText.Append(@"INSERT into Categoria (nome_categoria) ");
                commandText.Append("Values(@Categoria)");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@Categoria", FbDbType.VarChar).Value = categoria.NomeCategoria;

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
                    listaCategoria.Add(new CategoriaModel
                    {
                        IdCategoria = int.Parse(reader["id_categoria"].ToString()),
                        NomeCategoria = reader["nome_categoria"].ToString()
                    });
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
