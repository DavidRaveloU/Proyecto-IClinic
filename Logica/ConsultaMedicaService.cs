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
    public class ConsultaMedicaService
    {
        ConnectionManager _connectionManager;
        ConsultaMedicaRepository consultaMedicaRepository;
        public ConsultaMedicaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            consultaMedicaRepository = new ConsultaMedicaRepository(_connectionManager.conn);
        }
        public DataTable ExtraerNumeroSecuencia()
        {
            try
            {
                _connectionManager.Open();
               return consultaMedicaRepository.ExtraerNumeroSecuencia();
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
        public ConsultaResponse FiltrarPorCedulaPaciente(string cedula)
        {
            try
            {
                _connectionManager.Open();
                return new ConsultaResponse(consultaMedicaRepository.FiltrarPorCedulaPaciente(cedula));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                _connectionManager.Close();
            }
        }

        public ConsultaResponse FiltrarPorCedulaMedico(string cedula)
        {
            try
            {
                _connectionManager.Open();
                return new ConsultaResponse(consultaMedicaRepository.FiltraPorCedulaMedico(cedula));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                _connectionManager.Close();
            }
        }
        public string Guardar(Tratamiento tratamiento, RecetaMedica recetaMedica, Diagnostico diagnostico, ConsultaMedica consultaMedica)
        {
            try
            {
                _connectionManager.Open();
           
                {
                    consultaMedicaRepository.Guardar(tratamiento,recetaMedica,diagnostico, consultaMedica);
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
