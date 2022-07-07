using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.Clases
{
    public class Materia
    {
        int Id;
        String Nombre;
        List<Materia> Correlativas;
        List<Docente> Docentes;
        Dictionary<string, TimeSpan>? Cronograma = new();
        int AnioEnCarrera;
        int CargaHorariaSemanal;
        int CargaHorariaTotal;

        public Materia(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, Dictionary<string, TimeSpan> cronograma, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
        {
            ID = id;
            NOMBRE = nombre;
            CORRELATIVAS = correlativas;
            DOCENTES = docentes;
            CRONOGRAMA = cronograma;
            ANIOENCARRERA = anioEnCarrera;
            CARGAHORARIASEMANAL = cargaHorariaSemanal;
            CARGAHORARIATOTAL = cargaHorariaTotal;
        }

        public Materia(int id, string nombre, List<Materia> correlativas, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
        {
            ID = id;
            NOMBRE = nombre;
            CORRELATIVAS = correlativas;
            ANIOENCARRERA = anioEnCarrera;
            CARGAHORARIASEMANAL = cargaHorariaSemanal;
            CARGAHORARIATOTAL = cargaHorariaTotal;
        }

        public Materia(int id, List<Materia> correlativas, List<Docente> docentes, Dictionary<string, TimeSpan> cronograma) : this(id)
        {
            Correlativas = correlativas;
            Docentes = docentes;
            Cronograma = cronograma;
        }

        public Materia(int id, string nombre, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
        {
            ID = id;
            Nombre = nombre;
            AnioEnCarrera = anioEnCarrera;
            CargaHorariaSemanal = cargaHorariaSemanal;
            CargaHorariaTotal = cargaHorariaTotal;
        }

        public Materia(int id)
        {
            ID = id;
        }

        public int ID
        {
            set { Id = value; }
            get { return Id; }
        }
        public string NOMBRE
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public List<Materia> CORRELATIVAS
        {
            set { Correlativas = value; }
            get { return Correlativas; }
        }
        public List<Docente> DOCENTES
        {
            set { Docentes = value; }
            get { return Docentes; }
        }
        public Dictionary<string, TimeSpan> CRONOGRAMA
        {
            set { Cronograma = value; }
            get { return Cronograma; }
        }
        public int ANIOENCARRERA
        {
            set { AnioEnCarrera = value; }
            get { return AnioEnCarrera; }
        }
        public int CARGAHORARIASEMANAL
        {
            set { CargaHorariaSemanal = value; }
            get { return CargaHorariaSemanal; }
        }
        public int CARGAHORARIATOTAL
        {
            set { CargaHorariaTotal = value; }
            get { return CargaHorariaTotal; }
        }

        public override string ToString()
        {
            return "MATERIA {" + "_ID=" + ID + ", Nombre=" + NOMBRE + ", Correlativas" + CORRELATIVAS + ", Docente=" + DOCENTES + ", ANIOENCARRERA=" + ANIOENCARRERA + ", Correlativas" + CORRELATIVAS + ", CARGAHORARIASEMANAL=" + CARGAHORARIASEMANAL + ", CARGAHORARIATOTAL=" + CARGAHORARIATOTAL + '}';
        }

        /*
        public override string ToString()
        {
            return (ID + " " + NOMBRE);
        }
        */

        public string CronogramaToString()
        {
            return string.Join("CRONOGRAMA",CRONOGRAMA.Select(x => x.Key + " " + x.Value).ToArray());
        }
    }
}
