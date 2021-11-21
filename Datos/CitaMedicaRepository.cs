using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using Entidad;
namespace Datos
{
    public class CitaMedicaRepository
    {
        DbConnection _connection;
        public CitaMedicaRepository(DbConnection conn)
        {
            _connection = conn;
        }
        public DataTable ExtraerNumeroSecuencia()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT current_value FROM sys.sequences WHERE name = 'id_cita'"; //consulta
            SqlCommand comando = new SqlCommand(consulta, (SqlConnection)_connection);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        public void Guardar(CitaMedica citaMedica)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into cita_medica (id_cita, hora_cita,fecha_cita,medico_cedula_medico,paciente_cedula_paciente) values " +
                    "(@id_cita, @hora_cita,@fecha_cita,@medico_cedula_medico,@paciente_cedula_paciente)";
                command.Parameters.Add(new SqlParameter("@id_cita", citaMedica.IdCita));
                command.Parameters.Add(new SqlParameter("@hora_cita", citaMedica.HoraCitaMedica));
                command.Parameters.Add(new SqlParameter("@fecha_cita", citaMedica.FechaCitaMedica));
                command.Parameters.Add(new SqlParameter("@medico_cedula_medico", citaMedica.Medico.NumeroDeCedula));
                command.Parameters.Add(new SqlParameter("@paciente_cedula_paciente", citaMedica.CedulaPaciente));
                int fila = command.ExecuteNonQuery();
            }
        }
    }
}
