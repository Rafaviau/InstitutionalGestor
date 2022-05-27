using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    internal class Carrera
    {
        int NroResolucion { get; set; }
        string Nombre { get; set; }
        string NombreCorto { get; set; }
        string Turno { get; set; }
        List<Materia> Materias { get; set; }


        public Carrera(int nroResolucion, string nombre, string nombreCorto, string turno, List<Materia> materias)
        {
            NroResolucion = nroResolucion;
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Turno = turno;
            Materias = materias;
        }

        public Carrera(int nroResolucion, string nombre, string nombreCorto, string turno)
        {
            NroResolucion = nroResolucion;
            Nombre = nombre;
            NombreCorto = nombreCorto;
            Turno = turno;
        }
    }
}
