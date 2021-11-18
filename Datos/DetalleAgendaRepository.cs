using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace Datos
{
    public class DetalleAgendaRepository
    {
        DbConnection _conn;
        public DetalleAgendaRepository(DbConnection conn)
        {
            _conn = conn;
        }
    }
}
