using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ConsultaMedica
    {
        public CitaMedica CitaMedica { get; set; }
        public string Peso { get; set; }
        public string Temperatura { get; set; }
        public string Estatura { get; set; }
        public string PresionArterial { get; set; }
        public string RitmoCardiaco { get; set; }
        public string Alergia { get; set; }
        public string  AntecedentesQuirurjicos { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public RecetaMedica RecetaMedica { get; set; }
        public Medico Medico { get; set; }
    }
}
