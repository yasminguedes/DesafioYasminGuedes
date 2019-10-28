using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.CargoModel;

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
        public bool Cadastrar(CargoModel.CargoModel cargo, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append(@"INSERT into Cargo (nome_cargo) ");
            commandText.Append("Values(@Cargo)");

            cmd.CommandText = commandText.ToString();

            cmd.Parameters.Add("@Cargo", FbDbType.VarChar).Value = cargo.NomeCargo;
           
            cmd.ExecuteNonQuery();

            return true;
        }
       
        public IEnumerable<CargoModel.CargoModel> Listar(CargoModel.CargoModel cargo, FbCommand cmd)
        {
            var commandText = new StringBuilder();

            commandText.Append((@"Select * from Cargo Where id_cargo = @id"));

           yield return cargo;
        }

        internal IEnumerable<CargoModel.CargoModel> Listar()
        {
            throw new NotImplementedException();
        }
    }
}