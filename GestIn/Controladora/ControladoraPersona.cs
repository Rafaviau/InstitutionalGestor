using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.DAO;
using GestIn.Model;

namespace GestIn.Controladora
{
    internal class ControladoraPersona
    {
        #region Atributos
        daoAlumnos daoAlumnos = new daoAlumnos();
        List<Alumno> ListAlumnos;
        static ControladoraPersona? Instance;
        #endregion

        #region Singletone
        private ControladoraPersona()
        {
            ListAlumnos = new List<Alumno>();
        }
        public static ControladoraPersona GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControladoraPersona();
            }
            return Instance;
        }
        #endregion

        #region Alumnos
        public Alumno createAlumno(int dNI,string mail,string password,string nombre,string apellido,DateOnly fechaDeNacimiento,string lugarDeNacimiento,
                                string sexo, string celular, string celularDeEmergencia,string obraSocial, string actividadLaboral, string horarioLaboral)
        { /*
            Alumno alumno = new Alumno(dNI, mail, password, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, celularDeEmergencia, obraSocial, actividadLaboral,horarioLaboral);
            if(alumno != null) { return alumno; }
            */
            return null;
        }
        public Boolean AddToDatabase(Alumno alumno)
        {
            /*
            if (verifyUsuarioExist(alumno.DNI) == false) {
                
                daoAlumnos.create(alumno);
            }
            */
            if (daoAlumnos.createAlumno(alumno)) { return true; }
            return false;
        }
        public void AddToListAlumno(Alumno alumno) {
            ListAlumnos.Add(alumno);
        }
        public Boolean addAlumno(int dNI, string mail, string password, string nombre, string apellido, DateOnly fechaDeNacimiento, string lugarDeNacimiento,
                                string sexo, string celular, string celularDeEmergencia, string obraSocial, string actividadLaboral, string horarioLaboral)
        {
            Alumno alumno = createAlumno(dNI, mail, password, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, celularDeEmergencia, obraSocial, actividadLaboral, horarioLaboral);
            if (alumno != null) {
                if (AddToDatabase(alumno)) {
                    AddToListAlumno(alumno);
                    return true;
                }
            }
            return false;
        }
        public List<Alumno> ReadAll() {
            return daoAlumnos.readALL();
        }
        public void loadListAlumnos() {
            ListAlumnos = ReadAll();
        }
        public List<Alumno> getListAlumnos()
        {
            return ListAlumnos;
        }
        public Alumno readAlumno(int dni)
        {
            return daoAlumnos.read(dni);
        }
        bool verifyUsuarioExist(int dni) {
            if (daoAlumnos.ReadUsuario(dni)) 
            {
                return true; 
            }
            return false;
        }
        #endregion
    }
}
