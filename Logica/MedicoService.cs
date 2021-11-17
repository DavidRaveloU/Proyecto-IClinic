using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Datos;
using Entidad;

namespace Logica
{
    public class MedicoService
    {
        ConnectionManager connectionManager;
        MedicoRepository medicoRepository;
        public MedicoService( string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            medicoRepository = new MedicoRepository(connectionManager.conn);
        }
    }
}
