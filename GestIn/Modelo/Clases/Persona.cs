using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestIn.Modelo.Clases
{
    abstract internal class Persona
    {
        public int DNI { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaDeNacimiento { get; set; }
        public string LugarDeNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Celular { get; set; }
        public string CelularDeEmergencia { get; set; }

        protected Persona(int dNI, string mail, string password, string nombre, string apellido, DateOnly fechaDeNacimiento, string lugarDeNacimiento, string sexo, string celular, string celularDeEmergencia)
        {
            DNI = dNI;
            Mail = mail ;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            LugarDeNacimiento = lugarDeNacimiento ;
            Sexo = sexo;
            Celular = celular;
            CelularDeEmergencia = celularDeEmergencia ;
        }

        protected Persona(int dNI, string mail, string contraseña, string nombre, string apellido, DateOnly fechaDeNacimiento,string lugarDeNacimiento, string sexo)
        {
            DNI = dNI;
            Mail = mail;
            Password = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            LugarDeNacimiento= lugarDeNacimiento ;
            Sexo = sexo;
        }
    }
}
