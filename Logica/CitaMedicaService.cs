using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class CitaMedicaService
    {
        ConnectionManager _connectionManager;
        CitaMedicaRepository _citaMedicaRepository;
        public CitaMedicaService(string conn)
        {
            _connectionManager = new ConnectionManager(conn);
            _citaMedicaRepository = new CitaMedicaRepository(_connectionManager.conn);
        }
    }
}
