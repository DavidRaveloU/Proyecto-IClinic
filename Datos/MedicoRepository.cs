using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Datos
{
    public  class MedicoRepository
    {
        DbConnection _connection;
        public MedicoRepository(DbConnection conn)
        {
            _connection = conn;
        }
    }
}
