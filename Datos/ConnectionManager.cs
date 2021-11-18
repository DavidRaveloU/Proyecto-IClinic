using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class ConnectionManager
    {
       public  DbConnection conn;
        public ConnectionManager(string _connection)
        {
            conn = new OracleConnection(_connection);
        }

        public void Open()
        { 
          conn.Open();
        }

        public void Close()
        { 
         conn.Close(); 
        }
    }
}
