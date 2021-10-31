using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetalleAgenda
    {
        public Medico Medico { get; set; }
        public DateTime FechaDisponible { get; set; }
        public DateTime FechaFinalAtencion { get; set; }
        public Horario Horario { get; set; }
        public bool Estado { get; set; }
    }
}
