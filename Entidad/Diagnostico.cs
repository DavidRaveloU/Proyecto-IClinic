using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Diagnostico
    {
        public Diagnostico(string idDiagnostico, string descripcion, HistoriaClinica historiaClinica)
        {
            IdDiagnostico = idDiagnostico;
            Descripcion = descripcion;
            HistoriaClinica = historiaClinica;
        }

        public string IdDiagnostico { get; set; }
        public string Descripcion { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }

    }
}
