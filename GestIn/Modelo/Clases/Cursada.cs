using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    internal class Cursada
    {
        public int cicloLectivo { get; set; }
        public Alumno alumno { get; set; } 
        public Materia materia { get; set; }
        public bool aprobada { get; set; }

        public Cursada(int _cicloLectivo,Alumno _alumno,Materia _materia,bool _aprobada)
        {
            cicloLectivo = _cicloLectivo;
            alumno = _alumno;
            materia = _materia;
            aprobada = _aprobada;
        }

        public Cursada(int _cicloLectivo,Alumno _alumno,Materia _materia)
        {
            cicloLectivo = _cicloLectivo;
            alumno = _alumno;
            materia = _materia;
        }

    }
}
