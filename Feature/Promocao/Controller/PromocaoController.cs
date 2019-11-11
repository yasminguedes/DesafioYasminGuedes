using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using ProjetoDesafio.Feature.Promocao.Dao;
using ProjetoDesafio.Feature.Promocao.Model;

namespace ProjetoDesafio.Feature.Promocao.Controller
{
    public class PromocaoController
    {
        public bool Cadastrar(PromocaoModel promocao)
        {
            try
            {
                if (new PromocaoDao().Cadastrar(promocao))
                {
                    MessageBox.Show(@"Promoção cadastrada com sucesso");
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
                MessageBox.Show($@"Erro ao cadastrar promoção {e.Message}");
            }
            return false;
        }
    }
}
