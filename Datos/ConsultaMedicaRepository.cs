using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConsultaMedicaRepository
    {
        DbConnection _connection;
        public ConsultaMedicaRepository(DbConnection conn)
        {
            _connection = conn;
        }

        public DataTable ExtraerNumeroSecuencia()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT current_value FROM sys.sequences WHERE name = 'id_consultamedica'"; //consulta
            SqlCommand comando = new SqlCommand(consulta, (SqlConnection)_connection);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        /*public void Guardar(Tratamiento tratamiento, RecetaMedica recetaMedica, Diagnostico diagnostico)
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
        }*/
        public List<Paciente> ConsultarPaciente()
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



        public List<Medico> ConsultarMedico()
        {
            List<Medico> medicos = new List<Medico>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from medico";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Medico medico = new Medico();
                    medico.NumeroDeCedula = reader.GetString(0);
                    medico.PrimerNombre = reader.GetString(1);
                    medico.SegundoNombre = reader.GetString(2);
                    medico.PrimerApellido = reader.GetString(3);
                    medico.SegundoApellido = reader.GetString(4);
                    medico.NumeroTelefono = reader.GetString(5);
                    medico.CorreoElectronico = reader.GetString(6);
                    medico.Direccion = reader.GetString(7);
                    medico.Sexo = reader.GetString(8);
                    medico.Ciudad = reader.GetString(9);
                    medicos.Add(medico);
                }
                reader.Close();
            }
            return medicos;
        }

        public List<Paciente> FiltrarPorCedulaPaciente(string cedula)
        {
            return ConsultarPaciente().Where(p => p.NumeroDeCedula.ToLower().Contains(cedula.ToLower())).ToList();
        }

        public List<Medico> FiltraPorCedulaMedico(string cedula)
        {
            return ConsultarMedico().Where(p => p.NumeroDeCedula.Contains(cedula)).ToList();
        }
    }
}
