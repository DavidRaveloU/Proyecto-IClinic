using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class ConsultaMedicaService
    {
        ConnectionManager _connectionManager;
        ConsultaMedicaRepository consultaMedicaRepository;
        public ConsultaMedicaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            consultaMedicaRepository = new ConsultaMedicaRepository(_connectionManager.conn);
        }
    }
}
