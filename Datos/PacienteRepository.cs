using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
   public class PacienteRepository
    {
        DbConnection _connection;
        public PacienteRepository(DbConnection connection)
        {
                _connection = connection;
        }
    }
}
