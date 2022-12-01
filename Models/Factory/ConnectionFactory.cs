using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.Models.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetDbConnection()
        {
            IDbConnection conection = new SqlConnection();
            conection.ConnectionString = "";
            conection.Open();
            return conection;
        }
    }
}
