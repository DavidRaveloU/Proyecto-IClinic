using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Entidad;
using System.Data.SqlClient;

namespace Datos

{
   public class PacienteRepository
    {
        DbConnection _connection;
        public PacienteRepository(DbConnection connection)
        {
                _connection = connection;
        }
        public void Guardar(Paciente paciente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into paciente (cedula_paciente, primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,telefono,correo_electronico,direccion,sexo,ciudad) values (@cedula_paciente, @primer_nombre,@segundo_nombre,@primer_apellido,@segundo_apellido,@telefono,@correo_electronico,@direccion,@sexo,@ciudad)";
                command.Parameters.Add(new SqlParameter("@cedula_paciente", paciente.NumeroDeCedula));
                command.Parameters.Add(new SqlParameter("@primer_nombre", paciente.PrimerNombre));
                command.Parameters.Add(new SqlParameter("@segundo_nombre", paciente.SegundoNombre));
                command.Parameters.Add(new SqlParameter("@primer_apellido", paciente.PrimerApellido));
                command.Parameters.Add(new SqlParameter("@segundo_apellido", paciente.SegundoApellido));
                command.Parameters.Add(new SqlParameter("@telefono", paciente.NumeroTelefono));
                command.Parameters.Add(new SqlParameter("@correo_electronico", paciente.CorreoElectronico));
                command.Parameters.Add(new SqlParameter("@direccion", paciente.Direccion));
                command.Parameters.Add(new SqlParameter("@sexo", paciente.Sexo));
                command.Parameters.Add(new SqlParameter("@ciudad", paciente.Ciudad));
                int fila = command.ExecuteNonQuery();
            }
        }

        public List<Paciente> Consultar()
        {
            List<Paciente> pacientes = new List<Paciente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from paciente";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.NumeroDeCedula = reader.GetString(0);
                    paciente.PrimerNombre = reader.GetString(1);
                    paciente.SegundoNombre = reader.GetString(2);
                    paciente.PrimerApellido = reader.GetString(3);
                    paciente.SegundoApellido = reader.GetString(4);
                    paciente.NumeroTelefono = reader.GetString(5);
                    paciente.CorreoElectronico = reader.GetString(6);
                    paciente.Direccion = reader.GetString(7);
                    paciente.Sexo = reader.GetString(8);
                    paciente.Ciudad = reader.GetString(9);
                    pacientes.Add(paciente);
                }
                reader.Close();
            }
            return pacientes;
        }
        public Paciente BuscarPorIdentificacion(string cedula)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from paciente where cedula_paciente=@cedula_paciente";
                command.Parameters.Add(new SqlParameter("@cedula_paciente", cedula));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Paciente paciente = new Paciente();
                        paciente.NumeroDeCedula = reader.GetString(0);
                        paciente.PrimerNombre = reader.GetString(1);
                        paciente.SegundoNombre = reader.GetString(2);
                        paciente.PrimerApellido = reader.GetString(3);
                        paciente.SegundoApellido = reader.GetString(4);
                        paciente.NumeroTelefono = reader.GetString(5);
                        paciente.CorreoElectronico = reader.GetString(6);
                        paciente.Direccion = reader.GetString(7);
                        paciente.Sexo = reader.GetString(8);
                        paciente.Ciudad = reader.GetString(9);
                        return paciente;
                    }
                }
                reader.Close();
            }
            return null;
        }
    }
}
