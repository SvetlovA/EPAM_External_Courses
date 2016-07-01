using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlServerCe;

namespace Department.DAL
{
    public static class DataBaseConfig
    {
        public static string GetConnectionString()
        {
            string databaseName = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            SqlCeConnectionStringBuilder builder = new SqlCeConnectionStringBuilder();
            builder.DataSource = databaseName;

            return builder.ToString();
        }
    }
}
