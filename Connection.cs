using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDesafio
{
    public class Connection
    {
        private static readonly Connection InstanciaFireBird = new Connection();
        private Connection(){}
        public static Connection PegarInstancia() => InstanciaFireBird;
        public FbConnection PegarConexao()
        {
            var conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
