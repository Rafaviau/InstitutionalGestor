using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    public class Carrera
    {
        int NroResolucion;
        string Nombre;
        string NombreCorto;
        string Turno;
        List<Materia> Materias = new();

        public Carrera(int nroResolucion)
        {
            NroResolucion = nroResolucion;
        }

        public Carrera(int nroResolucion, string nombre, string nombreCorto, string turno, List<Materia> materias)
        {
            NRORESOLUCION = nroResolucion;
            NOMBRE = nombre;
            NOMBRECORTO = nombreCorto;
            TURNO = turno;
            LIST_MATERIAS = materias;
        }

        public Carrera(int nroResolucion, string nombre, string nombreCorto, string turno)
        {
            NRORESOLUCION = nroResolucion;
            NOMBRE = nombre;
            NOMBRECORTO = nombreCorto;
            TURNO = turno;
        }

        public int NRORESOLUCION
        {
            set { NroResolucion = value; }
            get { return NroResolucion; }
        }
        public string NOMBRE
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public string NOMBRECORTO
        {
            set { NombreCorto = value; }
            get { return NombreCorto; }
        }

        public string TURNO
        {
            set { Turno = value; }
            get { return Turno; }
        }

        public List<Materia>? LIST_MATERIAS
        {
            set { Materias = value; }
            get { return Materias; }
        }

        public String toString()
        {
            return "Carrera{" + "_NRORESOLUCION=" + NRORESOLUCION + ", Nombre=" + NOMBRE + ", NombreCorto" + NOMBRECORTO + ", Turno=" + TURNO + ", ListaMaterias=" + LIST_MATERIAS + '}';
        }
    }
}
