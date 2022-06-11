using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestIn.Conexiones.Database
{
    public abstract class ConexionDb
    {
        private readonly string connectionString;
        protected ConexionDb()
        {
            connectionString = "" +
                "Server=LAPTOP-E6PCVT2U\\SQLEXPRESS;" +
                "DataBase = DbGestin; " +
                "integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
