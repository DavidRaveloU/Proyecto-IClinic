using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
    public class ConsultaMedicaRepository
    {
        DbConnection _conn;
        public ConsultaMedicaRepository(DbConnection conn)
        {
            _conn = conn;
        }
    }
}
