using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    internal class Alumno : Persona
    {
        public bool FotocopiaDNI { get; set; }
		public bool FotocopiaTitSecundario { get; set; }
		public bool Fotos4x4 { get; set; }
		public bool CertificadoMedico { get; set; }
		public bool CerificadoDeNacimiento { get; set; }
		public bool ConstCUIL { get; set; }
		public bool Cooperadora { get; set; }
		public string ObraSocial { get; set; }
		public string ActividadLaboral { get; set; }
		public string HorarioLaboral { get; set; }

        public Alumno(int dNI,string mail, string password, string nombre, string apellido, DateOnly fechaDeNacimiento, string lugarDeNacimiento, string sexo, string celular, string CelularDeEmergencia , bool fotocopiaDNI, bool fotocopiaTitSecundario, bool fotos4x4, bool certificadoMedico, bool cerificadoDeNacimiento, bool constCUIL, bool cooperadora, string obraSocial, string actividadLaboral, string horarioLaboral) 
            : base (dNI, mail, password, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, CelularDeEmergencia)
        {
            FotocopiaDNI = fotocopiaDNI;
            FotocopiaTitSecundario = fotocopiaTitSecundario;
            Fotos4x4 = fotos4x4;
            CertificadoMedico = certificadoMedico;
            CerificadoDeNacimiento = cerificadoDeNacimiento;
            ConstCUIL = constCUIL;
            Cooperadora = cooperadora;
            ObraSocial = obraSocial;
            ActividadLaboral = actividadLaboral;
            HorarioLaboral = horarioLaboral;
        }

        public Alumno(int dNI, string mail, string contraseña, string nombre, string apellido, DateOnly fechaDeNacimiento,string lugarDeNacimiento ,string sexo, string celular,string CelularDeEmergencia) : base(dNI, mail, contraseña, nombre, apellido, fechaDeNacimiento,lugarDeNacimiento, sexo, celular, CelularDeEmergencia)
        {
            FotocopiaDNI = false;
            FotocopiaTitSecundario = false;
            Fotos4x4 = false;
            CertificadoMedico = false;
            CerificadoDeNacimiento = false;
            ConstCUIL = false;
            Cooperadora = false;
            ObraSocial = "";
            ActividadLaboral = "";
            HorarioLaboral = "";
        }

        public Alumno(int dNI, string mail, string contraseña, string nombre, string apellido, DateOnly fechaDeNacimiento, string lugarDeNacimiento, string sexo, string celular, string CelularDeEmergencia,string obraSocial, string actividadLaboral, string horarioLaboral) : base(dNI, mail, contraseña, nombre, apellido, fechaDeNacimiento, lugarDeNacimiento, sexo, celular, CelularDeEmergencia)
        {
            ObraSocial = obraSocial;
            ActividadLaboral = actividadLaboral;
            HorarioLaboral = horarioLaboral;
        }
    }

}
