using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ConsultaMedica
    {
        public ConsultaMedica()
        {

        }

        public ConsultaMedica(int idConsulta, string peso, string estatura, string presionArterial, string ritmoCardiaco, string antecedentesQuirurjicos, int idTratamiento, int idDiagnostico, int idRecetaMedica, string cedulaMedico, string cedulaPaciente)
        {
            IdConsulta = idConsulta;
            Peso = peso;
            Estatura = estatura;
            PresionArterial = presionArterial;
            RitmoCardiaco = ritmoCardiaco;
            AntecedentesQuirurjicos = antecedentesQuirurjicos;
            IdTratamiento = idTratamiento;
            IdDiagnostico = idDiagnostico;
            IdRecetaMedica = idRecetaMedica;
            CedulaMedico = cedulaMedico;
            CedulaPaciente = cedulaPaciente;
        }

        public int IdConsulta { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string PresionArterial { get; set; }
        public string RitmoCardiaco { get; set; }
        public string  AntecedentesQuirurjicos { get; set; }
        public int IdTratamiento { get; set; }
        public int IdDiagnostico { get; set; }
        public int IdRecetaMedica { get; set; }
        public string CedulaMedico { get; set; }
        public string CedulaPaciente { get; set; }
    }
}
