using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Datos
{
    public class RecetaMedicaRepository
    {
        DbConnection connection;
        public RecetaMedicaRepository(DbConnection connection)
        {
            this.connection = connection;
        }
    }
}
