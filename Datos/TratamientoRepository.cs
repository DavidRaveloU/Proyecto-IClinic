using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
    public class TratamientoRepository
    {
        DbConnection _conexion;
        public TratamientoRepository(DbConnection conn)
        {
            _conexion = conn;
        }
    }
}
