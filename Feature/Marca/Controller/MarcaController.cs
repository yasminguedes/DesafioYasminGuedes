using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Cargo.Dao;
using ProjetoDesafio.Feature.Marca.Dao;
using ProjetoDesafio.Feature.Marca.Model;

namespace ProjetoDesafio.Feature.Marca.Controller
{
    public class MarcaController
    {
        public bool Cadastrar(MarcaModel marca)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;

                var cadastro = new MarcaDao().Cadastrar(marca, cmd);

                if (cadastro)
                {
                    MessageBox.Show(@"Marca cadastrado com sucesso.");
                    return true;
                }

                MessageBox.Show(@"Erro ao cadastrar marca");
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao salvar cadastro: {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao cadastrar marca: {e.Message}");
            }
            finally
            {
                cmd.Dispose();
                conexaoFireBird.Close();
            }

            return false;
        }

        public IEnumerable<MarcaModel> Listar()
        {
            try
            {
                return new MarcaDao().Listar();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar marca : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar marca : {e.Message}");
            }
            return new List<MarcaModel>();
        }
    }
}
