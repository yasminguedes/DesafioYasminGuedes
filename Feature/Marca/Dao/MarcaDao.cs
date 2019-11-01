using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Marca.Model;

namespace ProjetoDesafio.Feature.Marca.Dao
{
    public class MarcaDao
    {
        public bool Cadastrar(MarcaModel marca)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                var commandText = new StringBuilder();

                commandText.Append(@"INSERT into Marca (nome_marca) ");
                commandText.Append("Values(@Marca)");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@Marca", FbDbType.VarChar).Value = marca.NomeMarca;

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

        internal IEnumerable<MarcaModel> Listar()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();
            try
            {
                cmd.CommandText = @"Select * from Marca";
                cmd.Connection = conexaoFirebird;

                var listaMarca = new List<MarcaModel>();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    listaMarca.Add(new MarcaModel
                    {
                        IdMarca = int.Parse(reader["id_marca"].ToString()),
                        NomeMarca = reader["nome_marca"].ToString()
                    });

                return listaMarca;
            }
            finally
            {
                cmd.Dispose();
                if (conexaoFirebird.State != ConnectionState.Closed)
                    conexaoFirebird.Close();
            }
        }
    }
}
