using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio
{
    public class Connection
    {
        private static readonly Connection InstanciaFireBird = new Connection();
        private Connection(){}

        public static Connection GetInstancia()
        {
            return InstanciaFireBird;
        }

        public FbConnection GetConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
