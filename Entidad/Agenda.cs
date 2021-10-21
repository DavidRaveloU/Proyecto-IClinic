using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Agenda
    {
        public int Id { get; set; }
        public bool Disponibilidad { get; set; }
        public Medico Medico { get; set; }
        
    }
}
