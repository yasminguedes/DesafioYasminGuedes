using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Model;

namespace ProjetoDesafio.Feature.Cargo.Dao
{
    public class CargoDao
    {
        public static DataTable GetDados()
        {
            var conexaoFirebird = Connection.PegarInstancia().PegarConexao();
            {
                try
                {
                    conexaoFirebird.Open();
                    const string mSql = @"Select * from Cargo";
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

        public bool Cadastrar(CargoModel cargo, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Cargo (nome_cargo) ");
            commandText.Append("Values(@Cargo)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = cargo.NomeCargo;
           
            cmd.ExecuteNonQuery();

            return true;
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

                //cmd.Parameters.Add(@"@id", FbDbType.Integer).Value = cargo.IdCargo;

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