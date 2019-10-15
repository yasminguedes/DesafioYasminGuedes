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
        private static readonly Connection instanciaFireBird = new Connection();
        private Connection(){}

        public static Connection getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
