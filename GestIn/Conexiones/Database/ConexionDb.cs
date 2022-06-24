using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Conexiones.Database
{
    public abstract class ConexionDb
    {
        private readonly string connectionString;
        protected ConexionDb()
        {
            connectionString = "" +
                "Server=DESKTOP-CKP73PI\\SQLEXPRESS;" +
                "DataBase = DbGestin; " +
                "integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
