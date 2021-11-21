using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
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
        public DataTable ExtraerNumeroSecuencia()
        {
            try
            {
                _connectionManager.Open();
                return _citaMedicaRepository.ExtraerNumeroSecuencia();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _connectionManager.Close();
            }
        }
        public string Guardar(CitaMedica citaMedica)
        {
            try
            {
                _connectionManager.Open();

                {
                    _citaMedicaRepository.Guardar(citaMedica);
                    return "Datos Guardados Satisfactoriamente";
                }
            }
            catch (Exception exception)
            {
                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                _connectionManager.Close();
            }
        }
    }
}
