using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Agenda
    {
        public string IdAgenda { get; set; }
        public List<DetalleAgenda> DetalleAgenda { get; set; }

        public void AgregarDetalleAgenda(DetalleAgenda detalleAgenda)
        {
            if (!DetalleAgenda.Contains(detalleAgenda))
                DetalleAgenda.Add(detalleAgenda);
        }
    }
}
