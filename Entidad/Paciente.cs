using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Paciente
    {
        public string NumeroDeCedula { get; set; }
        public string PrimerNombre{ get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido{ get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroTelefono{ get; set; }
        public string CorreoElectronico{ get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Ciudad { get; set; }
        public CitaMedica CitaMedica { get; set; }

    }
}
