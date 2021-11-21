using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Diagnostico
    {
        public Diagnostico()
        {

        }
        public Diagnostico(int idDiagnostico, string descripcion, HistoriaClinica historiaClinica)
        {
            IdDiagnostico = idDiagnostico;
            Descripcion = descripcion;
            HistoriaClinica = historiaClinica;
        }

        public int IdDiagnostico { get; set; }
        public string Descripcion { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }

    }
}
