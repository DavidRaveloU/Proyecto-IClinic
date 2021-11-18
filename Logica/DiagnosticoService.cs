using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Datos;
namespace Logica
{
   public class DiagnosticoService
    {
        ConnectionManager _connectionManager;
        DiagnosticoRepository  diagnosticoRepository;
        public DiagnosticoService(string connexion)
        {
            _connectionManager = new ConnectionManager(connexion);
            diagnosticoRepository = new DiagnosticoRepository(_connectionManager.conn);
        }
    }
}
