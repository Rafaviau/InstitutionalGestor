using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Modelo.Clases;
using GestIn.Conexiones.Database;
using System.Data.SqlClient;
using System.Data;

namespace GestIn.Modelo.DAO
{
    class daoEstudiante : ConexionDb, Idao<Alumno>
    {
        private readonly String SQL_CREATEUSER = "INSERT INTO USUARIOS VALUES (@Dni,@Email,@Password,@rol,@Nombre,@Apellido,@FechaDeNacimiento,@LugarDeNacimiento,@Celular,@CelularDeEmergencia,@Sexo)";
        private readonly String SQL_CREATEESTUDIANTE = "INSERT INTO ESTUDIANTES VALUES (@dniFk,@FotocopiaDni,@FotocopiaTitSecundario,@Fotos4x4,@CertificadoMedico,@CertificadoDeNacimiento," +
                                                     "@ConstCUIL,@Cooperadora,@ObraSocial,@ActividadLaboral,@HorarioLaboral)";
        private readonly String SQL_SELECTALLESTUDIANTES = "SELECT * FROM USUARIOS";
        public bool create(Alumno c)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SQL_CREATEUSER;
                    command.Parameters.AddWithValue("@Dni", c.DNI);
                    command.Parameters.AddWithValue("@Email", c.Mail);
                    command.Parameters.AddWithValue("@Password", c.Password);
                    command.Parameters.AddWithValue("@rol", "Estudiante");
                    command.Parameters.AddWithValue("@Nombre", c.Nombre);
                    command.Parameters.AddWithValue("@Apellido", c.Apellido);
                    command.Parameters.AddWithValue("@FechaDeNacimiento", c.FechaDeNacimiento.ToString());
                    command.Parameters.AddWithValue("@LugarDeNacimiento", c.LugarDeNacimiento);
                    command.Parameters.AddWithValue("@Celular", c.Celular);
                    command.Parameters.AddWithValue("@CelularDeEmergencia", c.CelularDeEmergencia);
                    command.Parameters.AddWithValue("@Sexo", c.Sexo);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        if (command.ExecuteNonQuery() != 0) { return true; }
                    }
                    catch (SqlException ex){}
                    return false;
                }
            }
        }
        public bool createAlumno(Alumno c)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SQL_CREATEESTUDIANTE;

                    command.Parameters.AddWithValue("@dniFk", c.DNI);
                    command.Parameters.AddWithValue("@FotocopiaDni", c.FotocopiaDNI);
                    command.Parameters.AddWithValue("@FotocopiaTitSecundario", c.FotocopiaTitSecundario);
                    command.Parameters.AddWithValue("@Fotos4x4", c.Fotos4x4);
                    command.Parameters.AddWithValue("@CertificadoMedico", c.CertificadoMedico);
                    command.Parameters.AddWithValue("@CertificadoDeNacimiento", c.CerificadoDeNacimiento);
                    command.Parameters.AddWithValue("@ConstCUIL", c.ConstCUIL);
                    command.Parameters.AddWithValue("@Cooperadora", c.Cooperadora);
                    command.Parameters.AddWithValue("@ObraSocial", c.ObraSocial);
                    command.Parameters.AddWithValue("@ActividadLaboral", c.ActividadLaboral);
                    command.Parameters.AddWithValue("@HorarioLaboral", c.HorarioLaboral);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        if (command.ExecuteNonQuery() != 0) { return true; }
                    }
                    catch (SqlException ex) { }
                    return false;
                }
            }
        }
        public bool delete(object key)
        {
            throw new NotImplementedException();
        }

        public Alumno read(object key)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> readALL()
        {
            using (var connection = GetConnection())
            {
                List<Alumno> listAlumnos = new List<Alumno>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SQL_SELECTALLESTUDIANTES;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listAlumnos.Add(new Alumno(reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(4),
                            reader.GetString(5),
                            DateOnly.Parse(reader.GetDateTime(6).ToString("dd-MM-yyy")),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9),
                            reader.GetString(10)));
                    }
                    return listAlumnos;
                }
            }
        }

        public bool update(Alumno c)
        {
            throw new NotImplementedException();
        }
    }
}
