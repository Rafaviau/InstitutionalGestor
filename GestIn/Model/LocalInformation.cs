using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Model
{
    internal static class LocalInformation
    {
        const string connectionString = "Server=PRECEPTORIA-01\\SQLEXPRESS;Database=DbGestin;Trusted_Connection=True;";
        public static string getConnectionString() {
            return connectionString;
        }
    }
}
