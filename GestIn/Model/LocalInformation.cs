using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Model
{
    internal static class LocalInformation
    {
        const string connectionString = "Server=DESKTOP-CKP73PI\\SQLEXPRESS;Database=DbGestin;Trusted_Connection=True;";
        public static string getConnectionString() {
            return connectionString;
        }
    }
}
