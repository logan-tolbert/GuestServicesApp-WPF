using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestServicesLibrary.DataAccess
{
    public static class  MySqlDataAccess
    {
        public static string GetServerConfiguration()
        {
            var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            string? connString = config.GetConnectionString("DefaultConnection");
            return connString;
        }
       
    }
}
