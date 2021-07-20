using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class ConnectionSql
    {
           private readonly string connectionString;

            public ConnectionSql()
            {
                connectionString = "Server =.;Database = MetalurgiaDB ; Trusted_Connection = True;";
            }

            /// <summary>
            /// Da la conexion a la base de datos
            /// </summary>
            /// <returns></returns>
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        

    }
}
