using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    internal class Examen
    {
        public int ID { get; set; }
        public DateOnly Fecha { get; set; }
        public Materia Materia { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Docente PrimerVocal { get; set; }
        public Docente SegundoVocal { get; set; }
        public Docente TercerVocal { get; set; }
        public Docente TitularExtraordinario { get; set; }

        public Examen(int iD, DateOnly fecha, Materia materia, List<Alumno> alumnos, Docente primerVocal, Docente segundoVocal, Docente tercerVocal, Docente titularExtraordinario)
        {
            ID = iD;
            Fecha = fecha;
            Materia = materia;
            Alumnos = alumnos;
            PrimerVocal = primerVocal;
            SegundoVocal = segundoVocal;
            TercerVocal = tercerVocal;
            TitularExtraordinario = titularExtraordinario;
        }

        public Examen(int iD, DateOnly fecha, Materia materia)
        {
            ID = iD;
            Fecha = fecha;
            Materia = materia ?? throw new ArgumentNullException(nameof(materia));
        }
    }
}
