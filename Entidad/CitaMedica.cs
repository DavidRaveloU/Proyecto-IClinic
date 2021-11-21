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

        public CitaMedica(string idCita, string horaCitaMedica, DateTime fechaCitaMedica, string cedulaPaciente, Medico medico)
        {
            IdCita = idCita;
            HoraCitaMedica = horaCitaMedica;
            FechaCitaMedica = fechaCitaMedica;
            CedulaPaciente = cedulaPaciente;
            Medico = medico;
        }

        public string IdCita { get; set; }
        public string HoraCitaMedica { get; set; }
        public DateTime FechaCitaMedica { get; set; }
        public string CedulaPaciente { get; set; }
        public Medico Medico { get; set; }
    }
}
