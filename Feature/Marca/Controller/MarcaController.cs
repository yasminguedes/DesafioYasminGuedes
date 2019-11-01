using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Marca.Dao;
using ProjetoDesafio.Feature.Marca.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature.Marca.Controller
{
    public class MarcaController
    {
        public bool Cadastrar(MarcaModel marca)
        {
            try
            {
                if (new MarcaDao().Cadastrar(marca))
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
