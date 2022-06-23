using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Modelo.Clases;

namespace GestIn.Modelo.Clases
{
    internal class Cursada
    {
        int cicloLectivo;
        Alumno alumno;
        Materia materia;
        bool aprobada;

        public Cursada(int anio, Alumno alumno, Materia materia, bool aprobada)
        {
            CICLOLECTIVO = cicloLectivo;
            ALUMNO = alumno;
            MATERIA = materia;
            APROBADA = aprobada;
        }
        public int CICLOLECTIVO
        {
            set { cicloLectivo = value; }
            get { return this.cicloLectivo; }
        }

        public Materia MATERIA
        {
            set { materia = value; }
            get { return materia; }
        }

        public bool APROBADA
        {
            set { aprobada = value; }
            get { return aprobada; }
        }

        public Alumno ALUMNO
        {
            set { alumno = value; }
            get { return alumno;  }
        }
    }
}
