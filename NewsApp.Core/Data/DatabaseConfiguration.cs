using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Core.Data
{
    public class DatabaseConfiguration
    {
        public static string GetConnectionString()
        {
            return "Server=.;Database=NewsDB;Trusted_Connection=True;TrustServerCertificate=True";
        }
    }
}
