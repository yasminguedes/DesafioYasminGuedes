using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Categoria.Dao;
using ProjetoDesafio.Feature.Categoria.Model;

namespace ProjetoDesafio.Feature.Categoria.Controller
{
    public class CategoriaController
    {
        public bool Cadastrar(CategoriaModel categoria)
        {
            var conexaoFireBird = Connection.PegarInstancia().PegarConexao();
            var cmd = new FbCommand();

            try
            {
                conexaoFireBird.Open();
                cmd.Connection = conexaoFireBird;

                var cadastro = new CategoriaDao().Cadastrar(categoria, cmd);

                if (cadastro)
                {
                    MessageBox.Show(@"Categoria cadastrado com sucesso.");
                    return true;
                }

                MessageBox.Show(@"Erro ao cadastrar categoria");
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao salvar cadastro: {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao cadastrar categoria: {e.Message}");
            }
            finally
            {
                cmd.Dispose();
                conexaoFireBird.Close();
            }

            return false;
        }

        public IEnumerable<CategoriaModel> Listar()
        {
            try
            {
                return new CategoriaDao().Listar();
            }
            catch (FbException fbex)
            {
                MessageBox.Show($@"Erro no banco ao listar categoria : {fbex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Erro ao listar categoria: {e.Message}");
            }
            return  new List<CategoriaModel>();
        }
    }
}
