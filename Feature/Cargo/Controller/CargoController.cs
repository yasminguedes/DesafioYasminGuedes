using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Dao;
using ProjetoDesafio.Feature.Cargo.Model;

namespace ProjetoDesafio.Feature.Cargo.Controller
{
    public class CargoController
    {
        public bool Cadastrar(CargoModel cargo)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;

                var cadastro = new CargoDao().Cadastrar(cargo, cmd);

                if (cadastro)
                {
                    MessageBox.Show(@"Cargo cadastrado com sucesso.");
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
                MessageBox.Show($@"Erro ao cadastrar cargo: {e.Message}");
            }
            finally
            {
                cmd.Dispose();
                conexaoFireBird.Close();
            }
            return false;

        }

        public IEnumerable<CargoModel> Listar()
        {
            try
            {
                return  new CargoDao().Listar();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar cargo : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar cargo : {e.Message}");
            }
            return new List<CargoModel>();
        }
    }
}
