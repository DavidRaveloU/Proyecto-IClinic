using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CitaMedica
    {
        public string IdCita { get; set; }
        public DateTime HoraCitaMedica { get; set; }
        public DateTime FechaCitaMedica { get; set; }
        public string CedulaPaciente { get; set; }
        public Agenda Agenda { get; set; }
    }
}
