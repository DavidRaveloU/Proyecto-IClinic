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
        public string Guardar(Medico medico)
        {
            try
            {
                connectionManager.Open();
                if (medicoRepository.BuscarPorIdentificacion(medico.NumeroDeCedula) == null)
                {
                    medicoRepository.Guardar(medico);
                    return "Datos Guardados Satisfactoriamente";
                }
                return $"El medico con la Identificacion {medico.NumeroDeCedula} ya se encuentra registrada";
            }
            catch (Exception exception)
            {
                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaResponse Consultar()
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(medicoRepository.Consultar());
            }
            catch (Exception e)
            {
                return new ConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
            finally
            {
                connectionManager.Close();
            }
        }


        public ConsultaResponse FiltrarMedico(string cedula)
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(medicoRepository.FiltrarMedico(cedula));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

    }
}
