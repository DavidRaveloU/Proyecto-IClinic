using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Diagnostico
    {
        public Diagnostico(string idDiagnostico, string descripcion)
        {
            IdDiagnostico = idDiagnostico;
            Descripcion = descripcion;
        }

        public string IdDiagnostico { get; set; }
        public string Descripcion { get; set; }

    }
}
