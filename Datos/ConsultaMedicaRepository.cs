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
        public void Guardar(Tratamiento tratamiento, RecetaMedica recetaMedica, Diagnostico diagnostico, ConsultaMedica consultaMedica)
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
                command.CommandText = "insert into diagnostico (id_diagnostico,descripcion) values (@id, @descripcion)";
                command.Parameters.Add(new SqlParameter("@id", diagnostico.IdDiagnostico));
                command.Parameters.Add(new SqlParameter("@descripcion", diagnostico.Descripcion));
                int fila = command.ExecuteNonQuery();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into consulta (id_consultamedica,peso,estatura,presion_arterial,ritmo_cardiaco,antecedentes_quirurjicos,tratamiento_id_tratamiento," +
                    "diagnostico_id_diagnostico,recetamedica_id_recetamedica,medico_cedula_medico, paciente_cedula_paciente) values (@id, @peso, @estatura,@presion_arterial,@ritmo_cardiaco,@antecedentes_quirurjicos," +
                    "@tratamiento_id_tratamiento, @diagnostico_id_diagnostico,@recetamedica_id_recetamedica,@medico_cedula_medico, @paciente_cedula_paciente)";
                command.Parameters.Add(new SqlParameter("@id", consultaMedica.IdConsulta));
                command.Parameters.Add(new SqlParameter("@peso", consultaMedica.Peso));
                command.Parameters.Add(new SqlParameter("@estatura", consultaMedica.Estatura));
                command.Parameters.Add(new SqlParameter("@presion_arterial", consultaMedica.PresionArterial));
                command.Parameters.Add(new SqlParameter("@ritmo_cardiaco", consultaMedica.RitmoCardiaco));
                command.Parameters.Add(new SqlParameter("@antecedentes_quirurjicos", consultaMedica.AntecedentesQuirurjicos));
                command.Parameters.Add(new SqlParameter("@tratamiento_id_tratamiento", consultaMedica.IdTratamiento));
                command.Parameters.Add(new SqlParameter("@diagnostico_id_diagnostico", consultaMedica.IdDiagnostico));
                command.Parameters.Add(new SqlParameter("@recetamedica_id_recetamedica", consultaMedica.IdRecetaMedica));
                command.Parameters.Add(new SqlParameter("@medico_cedula_medico", consultaMedica.CedulaMedico));
                command.Parameters.Add(new SqlParameter("@paciente_cedula_paciente", consultaMedica.CedulaPaciente));
                int fila = command.ExecuteNonQuery();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT NEXT VALUE FOR id_consultamedica";
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

        public List<ConsultaMedica> ConsultarConsultaMedica()
        {
            List<ConsultaMedica> consultaMedicas = new List<ConsultaMedica>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from consulta";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ConsultaMedica consultaMedica = new ConsultaMedica();
                    consultaMedica.IdConsulta = reader.GetInt32(0);
                    consultaMedica.Peso = reader.GetString(1);  
                    consultaMedica.Estatura = reader.GetString(2);
                    consultaMedica.PresionArterial = reader.GetString(3);
                    consultaMedica.RitmoCardiaco = reader.GetString(4);
                    consultaMedica.AntecedentesQuirurjicos = reader.GetString(5);
                    consultaMedica.IdTratamiento = reader.GetInt32(6);
                    consultaMedica.IdDiagnostico = reader.GetInt32(7);
                    consultaMedica.IdRecetaMedica = reader.GetInt32(8);
                    consultaMedica.CedulaMedico = reader.GetString(9);
                    consultaMedica.CedulaPaciente = reader.GetString(10);
                    consultaMedicas.Add(consultaMedica);
                }
                reader.Close();
            }
            return consultaMedicas;
        }


        public List<ConsultaMedica> FiltrarConsulta(string IdConsulta)
        {
            return ConsultarConsultaMedica().Where(p => p.IdConsulta.ToString().Contains(IdConsulta) || p.CedulaPaciente.Contains(IdConsulta)).ToList();
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
