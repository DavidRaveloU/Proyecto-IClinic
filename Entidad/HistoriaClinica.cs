using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HistoriaClinica
    {
        public string IdHistoriaClinica { get; set; }
        public string CedulaPaciente { get; set; }
        public List<ConsultaMedica> ListaDeHistoriaClinica { get; set; }

        public void AgregarConsultaMedica(ConsultaMedica consultaMedica)
        {
            if (!ListaDeHistoriaClinica.Contains(consultaMedica))
                ListaDeHistoriaClinica.Add(consultaMedica);
        }
    }
}