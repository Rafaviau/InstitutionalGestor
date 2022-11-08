using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Model
{
    internal static class LocalInformation
    {
        const string connectionString = "Server=127.0.0.1,1433;Database=DbGestin;User id =SA;Password=G@ldaf0*+;";
        public static string getConnectionString() {
            return connectionString;
        }
    }
}
