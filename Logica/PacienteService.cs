using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class PacienteService
    {
        PacienteRepository pacienteRepository;
        ConnectionManager connectionManager;
        public PacienteService(string _conn)
        {
            connectionManager = new ConnectionManager(_conn);
            pacienteRepository = new PacienteRepository(connectionManager.conn);
            
        }
    }
}
