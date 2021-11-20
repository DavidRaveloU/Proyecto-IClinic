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
    public  class MedicoRepository
    {
        DbConnection _connection;
        public MedicoRepository(DbConnection conn)
        {
            _connection = conn;
        }
        public void Guardar(Medico medico)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into medico (cedula_medico, primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,telefono,correo_electronico,direccion,sexo,ciudad) values (@cedula_medico, @primer_nombre,@segundo_nombre,@primer_apellido,@segundo_apellido,@telefono,@correo_electronico,@direccion,@sexo,@ciudad)";
                command.Parameters.Add(new SqlParameter("@cedula_medico", medico.NumeroDeCedula));
                command.Parameters.Add(new SqlParameter("@primer_nombre", medico.PrimerNombre));
                command.Parameters.Add(new SqlParameter("@segundo_nombre", medico.SegundoNombre));
                command.Parameters.Add(new SqlParameter("@primer_apellido", medico.PrimerApellido));
                command.Parameters.Add(new SqlParameter("@segundo_apellido", medico.SegundoApellido));
                command.Parameters.Add(new SqlParameter("@telefono", medico.NumeroTelefono));
                command.Parameters.Add(new SqlParameter("@correo_electronico", medico.CorreoElectronico));
                command.Parameters.Add(new SqlParameter("@direccion", medico.Direccion));
                command.Parameters.Add(new SqlParameter("@sexo", medico.Sexo));
                command.Parameters.Add(new SqlParameter("@ciudad", medico.Ciudad));
                int fila = command.ExecuteNonQuery();
            }
        }

        public List<Medico> Consultar()
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
        public Medico BuscarPorIdentificacion(string cedula)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from medico where cedula_medico=@cedula_medico";
                command.Parameters.Add(new SqlParameter("@cedula_medico", cedula));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
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
                        return medico;
                    }
                }
                reader.Close();
            }
            return null;
        }
    }
}
