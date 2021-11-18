using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Datos
{
    public class DiagnosticoRepository
    {
        DbConnection _conn;  
        public DiagnosticoRepository(DbConnection connection)
        {
            _conn = connection; 
        }
    }
}
