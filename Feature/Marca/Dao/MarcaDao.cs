using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Marca.Model;

namespace ProjetoDesafio.Feature.Marca.Dao
{
    public class MarcaDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Marca";
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
        public bool Cadastrar(MarcaModel marca, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Marca (nome_marca) ");
            commandText.Append("Values(@Marca)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@Marca", FbDbType.VarChar).Value = marca.NomeMarca;

            cmd.ExecuteNonQuery();

            return true;
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
                {
                    var marcaModel = new MarcaModel
                    {
                        IdMarca = int.Parse(reader["id_marca"].ToString()),
                        NomeMarca = reader["nome_marca"].ToString()
                    };
                    listaMarca.Add(marcaModel);
                }
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
