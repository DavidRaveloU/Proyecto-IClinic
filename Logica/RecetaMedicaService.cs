using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class RecetaMedicaService
    {
        ConnectionManager connectionManager;
        RecetaMedicaRepository recetaMedicaRepository;
        public RecetaMedicaService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            recetaMedicaRepository = new RecetaMedicaRepository(connectionManager.conn);
        }
    }
}
