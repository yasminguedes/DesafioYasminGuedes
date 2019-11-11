using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Model;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoDesafio.Feature.Cargo.Dao
{
    public class CargoDao
    {
        public bool Cadastrar(CargoModel cargo)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;
                var commandText = new StringBuilder();
                
                commandText.Append(@"INSERT into Cargo (nome_cargo) ");
                commandText.Append("Values(@Cargo)");

                cmd.CommandText = commandText.ToString();

                cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = cargo.NomeCargo;

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

            internal IEnumerable<CargoModel> Listar()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            conexaoFirebird.Open();
            var cmd = new FbCommand();

            try
            {
                cmd.CommandText = @"Select * from Cargo";
                cmd.Connection = conexaoFirebird;

                var listaCargo = new List<CargoModel>();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var cargoModel = new CargoModel
                    {
                        IdCargo = int.Parse(reader["id_cargo"].ToString()),
                        NomeCargo = reader["nome_cargo"].ToString()
                    };
                    listaCargo.Add(cargoModel);
                }
                return listaCargo;
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