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
        List<DateTime> Cronograma;
        int AnioEnCarrera;
        int CargaHorariaSemanal;
        int CargaHorariaTotal;
        

        public Materia(int id, string nombre, List<Materia> correlativas, List<Docente> docentes, List<DateTime> cronograma, int anioEnCarrera, int cargaHorariaSemanal, int cargaHorariaTotal)
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

        public Materia(int id, List<Materia> correlativas, List<Docente> docentes, List<DateTime> cronograma) : this(id)
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
            set { this.Id = value; }
            get { return this.Id; }
        }
        public String NOMBRE
        {
            set { this.Nombre = value; }
            get { return this.Nombre; }
        }
        public List<Materia> CORRELATIVAS
        {
            set { this.Correlativas = value; }
            get { return this.Correlativas; }
        }
        public List<Docente> DOCENTES
        {
            set { this.Docentes = value; }
            get { return this.Docentes; }
        }
        public List<DateTime> CRONOGRAMA
        {
            set { this.Cronograma = value; }
            get { return this.Cronograma; }
        }
        public int ANIOENCARRERA
        {
            set { this.AnioEnCarrera = value; }
            get { return this.AnioEnCarrera; }
        }
        public int CARGAHORARIASEMANAL
        {
            set { this.CargaHorariaSemanal = value; }
            get { return this.CargaHorariaSemanal; }
        }
        public int CARGAHORARIATOTAL
        {
            set { this.CargaHorariaTotal = value; }
            get { return this.CargaHorariaTotal; }
        }
    }



}
