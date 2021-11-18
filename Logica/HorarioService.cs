using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class HorarioService
    {
        ConnectionManager connectionManager;
        HorarioRepository HorarioRepository;
        public HorarioService(string connection)
        {
            connectionManager = new ConnectionManager(connection);
            HorarioRepository = new HorarioRepository(connectionManager.conn);
        }
    }
}
