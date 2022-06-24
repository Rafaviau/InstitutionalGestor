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
    class daoAlumnos : ConexionDb, Idao<Alumno>
    {
        private readonly String SQL_CREATEUSER = "INSERT INTO USUARIOS VALUES (@Dni,@Email,@Password,@rol,@Nombre,@Apellido,@FechaDeNacimiento,@LugarDeNacimiento,@Celular,@CelularDeEmergencia,@Sexo)";
        private readonly String SQL_CREATEALUMNO = "INSERT INTO ESTUDIANTES VALUES (@dniFk,@FotocopiaDni,@FotocopiaTitSecundario,@Fotos4x4,@CertificadoMedico,@CertificadoDeNacimiento," +
                                                     "@ConstCUIL,@Cooperadora,@ObraSocial,@ActividadLaboral,@HorarioLaboral)";
        private readonly String SQL_SELECTUSUARIO = "SELECT * FROM USUARIOS WHERE Dni = @Dni";
        private readonly String SQL_READALUMNO = "SELECT * FROM USUARIOS INNER JOIN ESTUDIANTES ON USUARIOS.Dni = ESTUDIANTES.Dni WHERE ESTUDIANTES.Dni = @dni";
        public bool create(Alumno c) //Crea un usuario
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
                    command.Parameters.AddWithValue("@rol", "Alumnos");
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
                    catch (SqlException ex) { }
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
                    command.CommandText = SQL_CREATEALUMNO;

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
                        if (command.ExecuteNonQuery() != -1) { return true; }
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

        public Alumno read(object dni)
        {
            using (var connection = GetConnection())
            {
                Alumno alumno = null;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SQL_READALUMNO;
                    command.Parameters.AddWithValue("@Dni", dni);
                    try { 
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            alumno = new Alumno(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(4),
                                reader.GetString(5),
                                DateOnly.Parse(reader.GetDateTime(6).ToString("dd-MM-yyy")),
                                reader.GetString(7),
                                reader.GetString(8),
                                reader.GetString(9),
                                reader.GetString(10),
                                reader.GetBoolean(12),
                                reader.GetBoolean(13),
                                reader.GetBoolean(14),
                                reader.GetBoolean(15),
                                reader.GetBoolean(16),
                                reader.GetBoolean(17),
                                reader.GetBoolean(18),
                                reader.GetString(19),
                                reader.GetString(20),
                                reader.GetString(21)
                                );
                        }
                    }
                    catch (SqlException ex) { }
                    return alumno;
                }
            }
        }

        public List<Alumno> readALL()
        {
            throw new NotImplementedException();
        }

        public bool update(Alumno c)
        {
            throw new NotImplementedException();
        }
        public bool ReadUsuario(int dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = SQL_SELECTUSUARIO;
                    command.Parameters.AddWithValue("@Dni", dni);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        if (command.ExecuteNonQuery() != -1) {return true; }
                    }
                    catch (SqlException ex) { }
                }
                return false;
            }
        }
    }
}
