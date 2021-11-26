using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

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
        public string Guardar(Paciente paciente)
        {
            CorreoService correoService = new CorreoService();
            string MensageEmail = string.Empty;
            try
            {
                connectionManager.Open();

                if (pacienteRepository.BuscarPorIdentificacion(paciente.NumeroDeCedula) == null)
                {
                    pacienteRepository.Guardar(paciente);
                    MensageEmail = correoService.EnviarEmail(paciente);
                    return "Datos Guardados Satisfactoriamente" +" "+MensageEmail;
                }
                return $"El paciente con la Identificacion {paciente.NumeroDeCedula} ya se encuentra registrado";
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
                return new ConsultaResponse(pacienteRepository.Consultar());
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

        public ConsultaResponse FiltrarPaciente(string cedula)
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(pacienteRepository.FiltrarPaciente(cedula));
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
