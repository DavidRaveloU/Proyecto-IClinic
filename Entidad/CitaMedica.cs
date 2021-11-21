using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CitaMedica
    {
        public CitaMedica()
        {

        }
        public CitaMedica(string idCita,  string cedulaPaciente, DetalleAgenda detalleAgenda)
        {
            IdCita = idCita;
            HoraCitaMedica = detalleAgenda.Horario.HoraInicial;
            FechaCitaMedica = detalleAgenda.FechaDisponible;
            CedulaPaciente = cedulaPaciente;
            Medico = detalleAgenda.Medico;
        }

        public string IdCita { get; set; }
        public DateTime HoraCitaMedica { get; set; }
        public DateTime FechaCitaMedica { get; set; }
        public string CedulaPaciente { get; set; }
        public Medico Medico { get; set; }
    }
}
