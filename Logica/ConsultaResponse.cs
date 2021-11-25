using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ConsultaResponse
    {
        public List<Medico> Medicos { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<ConsultaMedica> ConsultaMedicas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public ConsultaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public ConsultaResponse(List<Medico> medicos)
        {
            Medicos = medicos;
            Error = false;
        }
        public ConsultaResponse(List<Paciente> pacientes)
        {
            Pacientes = pacientes;
            Error = false;
        }

        public ConsultaResponse(List<ConsultaMedica> consultas)
        {
            ConsultaMedicas = consultas;
            Error = false;
        }
    }
}
