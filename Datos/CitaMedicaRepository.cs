using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
    public class CitaMedicaRepository
    {
        DbConnection _conn;
        public CitaMedicaRepository(DbConnection conn)
        {
            _conn = conn;
        }
    }
}
