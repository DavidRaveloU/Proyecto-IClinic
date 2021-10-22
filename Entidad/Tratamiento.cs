using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tratamiento
    {
        public Tratamiento(string idTratamiento, string nombreTratamiento, string descripcion)
        {
            IdTratamiento = idTratamiento;
            NombreTratamiento = nombreTratamiento;
            Descripcion = descripcion;
        }

        public string IdTratamiento { get; set; }
        public string NombreTratamiento { get; set; }
        public string Descripcion { get; set; }
    }
}
