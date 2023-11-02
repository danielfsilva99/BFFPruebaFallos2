using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Servicio.ContextoConexion
{
    public class ContextoConexionDb
    {

        private string connectionString;

        public ContextoConexionDb()
        {
            connectionString = "server=localhost\\SQLEXPRESS;database=master; integrated security=True; Trusted_Connection=True; TrustServerCertificate=True;";
        }

        public IDbConnection connection
        {
            get
            {

                return new SqlConnection(connectionString);
            }

        }
    }
}