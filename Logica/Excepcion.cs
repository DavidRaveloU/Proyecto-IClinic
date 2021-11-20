using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Excepcion : Exception
    {
        public Excepcion()
        {

        }
        public Excepcion(string mensaje):base(mensaje)
        {

        }
    }
}
