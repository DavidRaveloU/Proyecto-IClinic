using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Common;
namespace Logica
{
    public class DetalleAgendaService
    {
        DetalleAgendaRepository DetalleAgendaRepository;
        ConnectionManager ConnectionManager;
        public DetalleAgendaService(string _connection)
        {
            ConnectionManager = new ConnectionManager(_connection);
            DetalleAgendaRepository = new DetalleAgendaRepository(ConnectionManager.conn);
        }
    }
}
