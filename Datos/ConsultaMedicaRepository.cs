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
        public void Guardar(Tratamiento tratamiento, RecetaMedica recetaMedica, Diagnostico diagnostico)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into tratamiento (id_tratamiento,nombre_tratamiento,descripcion) values (@id_tratamiento, @nombre_tratamiento,@descripcion)";
                command.Parameters.Add(new SqlParameter("@id_tratamiento", tratamiento.IdTratamiento));
                command.Parameters.Add(new SqlParameter("@nombre_tratamiento", tratamiento.NombreTratamiento));
                command.Parameters.Add(new SqlParameter("@descripcion", tratamiento.Descripcion));
                int fila = command.ExecuteNonQuery();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into recetamedica (id_recetamedica,nombre_medicamento,indicaciones) values (@id_recetamedica, @nombre_medicamento,@indicaciones)";
                command.Parameters.Add(new SqlParameter("@id_recetamedica", recetaMedica.IdReceta));
                command.Parameters.Add(new SqlParameter("@nombre_medicamento", recetaMedica.NombreMedicamento));
                command.Parameters.Add(new SqlParameter("@indicaciones", recetaMedica.Indicaciones));
                int fila = command.ExecuteNonQuery();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into diagnostico (id_diagnostico,descripcion) values (NEXT VALUE FOR id_consultamedica, @descripcion)";
                command.Parameters.Add(new SqlParameter("@descripcion", diagnostico.Descripcion));
                int fila = command.ExecuteNonQuery();
            }
            
        }
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
            return ConsultarPaciente().Where(p => p.NumeroDeCedula.Contains(cedula)).ToList();
        }

        public List<Medico> FiltraPorCedulaMedico(string cedula)
        {
            return ConsultarMedico().Where(p => p.NumeroDeCedula.Contains(cedula)).ToList();
        }
    }
}
