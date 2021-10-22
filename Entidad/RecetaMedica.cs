using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RecetaMedica
    {
        public RecetaMedica(string idReceta, string nombreMedicamento, string indicaciones)
        {
            IdReceta = idReceta;
            NombreMedicamento = nombreMedicamento;
            Indicaciones = indicaciones;
        }

        public string IdReceta { get; set; }
        public string NombreMedicamento { get; set; }
        public string Indicaciones { get; set; }
    }
}
