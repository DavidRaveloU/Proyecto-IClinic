using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
    public class HorarioRepository
    {
        DbConnection _conn;
        public HorarioRepository(DbConnection connection)
        {
            _conn = connection; 
        }
    }
}
