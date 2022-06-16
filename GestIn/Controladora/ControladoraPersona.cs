using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Modelo.Clases;
using GestIn.Modelo.DAO;

namespace GestIn.Controladora
{
    internal class ControladoraPersona
    {
        #region Atributos
        daoEstudiante daoEstudiante = new daoEstudiante();
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
        { 
            Alumno alumno = new Alumno(dNI, mail, password, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, celularDeEmergencia, obraSocial, actividadLaboral,horarioLaboral);
            if(alumno != null) { return alumno; }
            return null;
        }


        //Falta verificar si el alumno ya tiene una cuenta
        public Boolean AddToDatabase(Alumno a)
        {
            if (readAlumno(a.DNI) == null) {
                daoEstudiante.create(a);
            }
            if (daoEstudiante.createAlumno(a)) { return true; }
            return false;
        }
        public Boolean AddToListAlumno(Alumno a) {
            ListAlumnos.Add(a);
            return true;
        }
        public Boolean addAlumno(int dNI, string mail, string password, string nombre, string apellido, DateOnly fechaDeNacimiento, string lugarDeNacimiento,
                                string sexo, string celular, string celularDeEmergencia, string obraSocial, string actividadLaboral, string horarioLaboral)
        {
            Alumno a = createAlumno(dNI, mail, password, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, celularDeEmergencia, obraSocial, actividadLaboral, horarioLaboral);
            if (a != null) {
                if (AddToDatabase(a) && AddToListAlumno(a)) {return true;}
            }
            return false;
        }
        public List<Alumno> ReadAll() {
            return daoEstudiante.readALL();
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
            Alumno alumno = null;
            foreach(Alumno alumno1 in ListAlumnos)
            {
                if(alumno1.DNI == dni)
                {
                    alumno = alumno1;
                }
            }
            return alumno;
        }
        #endregion

    }
}
