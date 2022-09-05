/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestIn.Model;

namespace GestIn.Controllers
{
	internal class oldcareerController
	{
		#region Atributos
		private List<Career> ListCareers = new List<Career>();
		private static oldcareerController? Instance;
		#endregion

		#region Singletone
		private oldcareerController()
		{
			//ListCareers = new List<Career>();
			ListCareers = loadCareers();
		}

		public static oldcareerController GetInstance()
		{
			if (Instance == null)
			{
				Instance = new oldcareerController();
			}
			return Instance;
		}
		#endregion

		#region ReturnList
		public List<Career> ReturnListCarreras()
		{
			return ListCareers;
		}

		public List<Subject> ReturnListMateriasDeCarrera(Career carreraExistente)
		{
			Career aux = ReadCarrera(carreraExistente.ID);
			return aux.LIST_SUBJECTS;

		}
		#endregion

		#region CRUD Carrera 

		/*********************************************************************************************************************/

/*CARRERAS*/

/********************************************************************************************************************

public Career createCareer(string nroResolucion, string nombre, string degree, string turno)
{
    Career nuevacarrera = new Career(nroResolucion, nombre, degree, turno);

    try
    {
        nuevacarrera.CreatedAt = DateTime.Now;
        nuevacarrera.LastModificationBy = "Preceptor cargando materias";
        using (var db = new Context())
        {
            db.Careers.Add(nuevacarrera);
            db.SaveChanges();
        }
        ListCareers.Add(nuevacarrera); //ID NOT NECESSARY
        return nuevacarrera;
    }
    catch (SqlException exception)
    {
        if (exception.Number == 2601)
        {
            // MANEJAR ERROR DE DNI DUPLICADO
            return null;
        }
        else
            throw; // MANEAJAR EXCEPEPTION INDEFINIDA
    }


}

public Career ReadCarrera(int id)
{
    Career carrera = null;

    foreach (Career aux in ListCareers)
    {
        if (aux.ID == id)
        {
            carrera = aux;
        }
    }
    return carrera;
}

public List<Career> loadCareers()
{
    using (var db = new Context())
    {
        return db.Careers.ToList();
    }
}

public Dictionary<string, string> loadCareerInformation(string reso) //POR RESOLUCION
{
    Dictionary<string, string> data = new Dictionary<string, string>();
    try
    {
        Career career = findCareer(reso);
        if (career != null)
        {
            data.Add("id", career.Id.ToString());
            data.Add("name", career.Name);
            data.Add("degree", career.Degree);
            return data;
        }
        return null;
    }
    catch(Exception ex)
    {
        throw new Exception(ex.Message);
    }
}

public Career findCareer(string reso)
{
    using (var db = new Context())
    {
        try
        {
            var career = db.Careers.Where(x => x.Resolution == reso).First();
            return career;
        }
        catch { }
        return null;
    }
}
public Career findCareer(int id)
{
    using (var db = new Context())
    {
        try
        {
            var career = db.Careers.Where(x => x.Id == id).First();
            return career;
        }
        catch { }
        return null;
    }
}

internal bool updateCareer(int id, string reso, string name, string degree)
{
    try
    {
        using (var db = new Context())
        {
            var result = findCareer(id);
            if (result != null)
            {
                result.Resolution = reso;
                result.Name = name;
                result.Degree = degree;
                result.LastModificationBy = "Preceptor cargando notas";
                result.UpdatedAt = DateTime.Now;
                db.Update(result);
                db.SaveChanges();
                return true;
            }
        }
    }
    catch { }
    return false;
}


public void deleteCarrera(int id)
{
    ListCareers.Remove(ReadCarrera(id));
}

public List<Subject> MateriasDeUnaCarrera(object carreraSelectorObject)
{
    List<Subject> subjectList = new List<Subject>();

    Career carreraSelector = (Career)carreraSelectorObject;

    foreach (Career carrera in ReturnListCarreras())
    {
        if (carrera.ID == carreraSelector.ID)
        {
            foreach (Subject item in carrera.LIST_SUBJECTS)
            {
                subjectList.Add(item);
            }
            carrera.LIST_SUBJECTS = subjectList;
        }
        return subjectList;
    }
    return null;
}

public List<Subject> MateriasDeUnaCarrera(object carreraSelectorObject, object materiaSelectorObject) //no muestra la misma materia
{
    Career carreraSelector = (Career)carreraSelectorObject;
    Subject materiaSelector = (Subject)materiaSelectorObject;
    List<Subject> ListaMaterias = carreraSelector.LIST_SUBJECTS; //Correlativas
    List<Subject> ListCorrelativas = new List<Subject>();

    foreach (Subject materiaExistente in ListaMaterias)
    {
        ListCorrelativas.Add(materiaExistente);
    }

    if (ListCorrelativas.Contains(materiaSelector))
    {
        ListCorrelativas.Remove(materiaSelector);
    }
    else
    {
        MessageBox.Show("Algo Salio Mal <- Correlativas");
    }

    return ListCorrelativas;
}

public void TestCarrera()
{
    Career nuevacarrera = new Career(1, "numreso232", "Analisis Gastronomico", "AnaCom", "Tarde");
    ListCareers.Add(nuevacarrera);
    Career nuevacarrera1 = new Career(2, "numreso434", "Programacion Terapeutica", "ProTera", "Vespertino");
    ListCareers.Add(nuevacarrera1);
}

public string TOSTRINGCARRERA(Career c) //Prueba
{
    return ("ID = " + c.RESOLUTION + " " + "Nombre" + " " + c.NAME);
}

#endregion

#region CRUD Materia

/*********************************************************************************************************************/

/*MATERIAS*/

/********************************************************************************************************************

public void createSubject(int careerID, string nombre, int anioEnCarrera, int cargaHorariaTotal, object carreraObject)
{
    Career carrera = (Career)carreraObject;
    Subject nuevaMateria = new Subject(careerID, nombre, anioEnCarrera, cargaHorariaTotal);
    carrera.LIST_SUBJECTS.Add(nuevaMateria);
    MessageBox.Show("CREATED SUCCESSFULLY"); //ID NOT NECESSARY
}

public Subject ReadMateria(object materiaObject, object carreraObject) //Original
{
    Career carreraExistente = (Career)carreraObject;
    Subject materia = (Subject)materiaObject;
    Subject _materia_TOREAD = null;
    foreach (Subject aux in carreraExistente.LIST_SUBJECTS)
    {
        if (aux.YearInCareer == materia.YearInCareer)
        {
            _materia_TOREAD = aux;
        }
    }
    return _materia_TOREAD;
}

public IEnumerable<Subject> loadSubject(object career)
{
    Career car = (Career)career;
    using (var db = new Context())
    {
        return db.Subjects.Where(x => x.CareerId == car.Id).ToList();
    }
}

public void updateSubject(object carreraExistenteObject, object materiaObject, string nombre, int anioEnCarrera, int cargaHorariaTotal)
{
    Career carreraExistente = (Career)carreraExistenteObject;
    Subject nuevaMateria = (Subject)materiaObject;
    nuevaMateria.NAME = nombre;
    nuevaMateria.YEARINCAREER = anioEnCarrera;
    nuevaMateria.ANNUALHOURLYLOAD = cargaHorariaTotal;

    foreach (Career carrera in ListCareers)
    {
        if (carreraExistente.ID == carrera.ID) //ID CARRERA
        {
            foreach (Subject materia in carrera.LIST_SUBJECTS)
            {
                if (materia.ID == nuevaMateria.ID) //ID MATERIA
                {
                    carrera.LIST_SUBJECTS.Remove(materia);
                    carrera.LIST_SUBJECTS.Add(nuevaMateria);
                    MessageBox.Show("UPDATE SUCCESSFULL");
                }
            }
        }
    }
}

public void updateSubject(object carreraExistenteObject, object materiaObject, object correlativeSubject)
{
    Career carreraExistente = (Career)carreraExistenteObject; //Solamente para correlativas
    Subject thisSubject = (Subject)materiaObject;
    Correlative correlativesubject = (Correlative)correlativeSubject;

    foreach (Career carrera in ListCareers)
    {
        if (carreraExistente.ID == carrera.ID) //ID CARRERA
        {
            foreach (Subject materia in carrera.LIST_SUBJECTS)
            {
                if (materia.ID == thisSubject.ID) //ID MATERIA
                {
                    thisSubject.CORRELATIVES.Add(correlativesubject);
                    MessageBox.Show("CORRELATIVE ADDED SUCCESSFULLY");
                }
            }
        }
    }
}

public void deleteSubject(object materiaObject, object carreraObject)
{
    Subject materiaBorrar = (Subject)materiaObject;
    Career carreraExistente = (Career)carreraObject;

    foreach (Career carrera in ListCareers)
    {
        if (carrera.ID == carreraExistente.ID)
        {
            foreach (Subject materia in carreraExistente.LIST_SUBJECTS)
            {
                if (materiaBorrar.ID == materia.ID) //ID
                {
                    carrera.LIST_SUBJECTS.Remove(materiaBorrar);
                }
            }
        }
    }
}

public Subject GetMateria(object materiaSelector) //Checklist casteando
{
    Subject objMateria = (Subject)materiaSelector;
    return objMateria;
}

public Subject GetMateria(object carreraSelected, object materiaObject) //Pedir -> Docentes/Cronograma/Correlativas
{
    Subject objMateria = null;
    Subject materiaSelector = (Subject)materiaObject;
    foreach (Subject materia in MateriasDeUnaCarrera((Career)carreraSelected))
    {
        if (materiaSelector.ID == materia.ID)
        {
            objMateria = materia;
        }
    }
    return objMateria;
}

public Subject GetMateria(object carreraSelected, int materiaID) //Pedir -> Docentes/Cronograma/Correlativas
{
    Subject objMateria = null;
    foreach (Subject materia in MateriasDeUnaCarrera((Career)carreraSelected))
    {
        if (materiaID == materia.ID)
        {
            objMateria = materia;
        }
    }
    return objMateria;
}


/*public void TestMateria()//DEPRECATED
{
    List<Subject> testCorrelativasA = new List<Subject>();
    List<Subject> testCorrelativasB = new List<Subject>();

    foreach (Career carrera in ListCareers)
    {
        if (carrera.ID == 1)
        {
            Subject nuevamateria = new Subject(1, 1, "Cocina Orientada a Objetos", 3451, 1);
            carrera.LIST_SUBJECTS.Add(nuevamateria);
            Subject nuevamateria1 = new Subject(2, 1, "Gestion de Reposteria", 143, 1);
            carrera.LIST_SUBJECTS.Add(nuevamateria1);

            testCorrelativasA.Add(nuevamateria);
            testCorrelativasA.Add(nuevamateria1);

            Subject nuevamateria2 = new Subject(3, 1, "Investigacion Culinaria", 2, 24, testCorrelativasA);
            carrera.LIST_SUBJECTS.Add(nuevamateria2);

            testCorrelativasB.Add(nuevamateria2);

            Subject nuevamateria3 = new Subject(4, 1, "Practica Profesionalizante", 3, 24, testCorrelativasB);
            carrera.LIST_SUBJECTS.Add(nuevamateria3);
        }
        else if (carrera.ID == 2)
        {
            Subject nuevamateria = new Subject(5, 2, "Terapia Intensiva por sobreutilización de GIT", 1, 24);
            carrera.LIST_SUBJECTS.Add(nuevamateria);
            Subject nuevamateria1 = new Subject(6, 2, "Psicologia de Programadores", 2, 24);
            carrera.LIST_SUBJECTS.Add(nuevamateria1);
        }
    }
}

public List<Subject> GetCheckedCorrelativas(List<object> checkedItems) 
{
    List<Subject> correlativasList = new List<Subject>();
    foreach (Subject checkedMateria in checkedItems)
    {
        correlativasList.Add(checkedMateria);
    }
    return correlativasList;
}



public int CalcularHorasSemanales(int horasTotales) //EN MODELO
{
    return horasTotales / 32;
}
#endregion
}
}

*/

/*		
using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestIn.Controllers
{
    internal class careerController
    {
        static careerController? Instance;

        private careerController()
        {
        }
        public static careerController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new careerController();
            }
            return Instance;
        }

        #region career
        public List<Career> loadCareers() {
            using (var db = new Context())
            {
                return db.Careers.ToList();
            }
        }
        public Career createCareer(string resolution, string name, string degree) {
                    try
                    {
                        Career career = new Career();
                        career.Resolution = resolution;
                        career.Name = name;
                        career.Degree = degree;
                        career.CreatedAt = DateTime.Now;
                        career.LastModificationBy = "Preceptor cargando materias";
                        using (var db = new Context())
                        {
                            db.Careers.Add(career);
                            db.SaveChanges();
                        }

                        return career;
                    }
                    catch (SqlException exception)
                    {
                        if (exception.Number == 2601)
                        {
                            // MANEJAR ERROR DE DNI DUPLICADO
                            return null;
                        }
                        else
                            throw; // MANEAJAR EXCEPEPTION INDEFINIDA
                    }
                    return null;
                }

        public Career findCareer(string reso) {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Resolution == reso).First();
                    return career;
                }
                catch { }
                return null;
            }
        }
        public Career findCareer(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Id == id).First();
                    return career;
                }
                catch { }
                return null;
            }
        }
        public Dictionary<string, string> loadCareerInformation(string reso) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                Career career = findCareer(reso);
                if (career != null)
                {
                    data.Add("id", career.Id.ToString());
                    data.Add("name", career.Name);
                    data.Add("degree",career.Degree );
                    return data;
                }
                return null;
            }
            catch { }
            return null;
        }
        internal bool updateCareer(int id, string reso ,string name, string degree)
        {
            try { 
                using (var db = new Context())
                {
                    var result = findCareer(id);
                    if (result != null)
                    {
                        result.Resolution = reso;
                        result.Name = name;
                        result.Degree = degree;
                        result.LastModificationBy = "Preceptor cargando notas";
                        result.UpdatedAt = DateTime.Now;
                        db.Update(result);
                        db.SaveChanges();
                        return true;
                    }
                }
            } catch { }
            return false;
        }

        #endregion
        #region subject
        public IEnumerable<Subject> loadSubject(object career)
        {
            Career car = (Career)career;
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.CareerId == car.Id).ToList();
            }
        }
        public Subject createSubject(string name,int yearincareer,int hourlyLoad,object career) {
                    try
                    {
                        Career car = (Career)career;
                        Subject subject = new Subject();
                        subject.CareerId = car.Id;
                        subject.Name = name;
                        subject.YearInCareer = yearincareer;
                        subject.AnnualHourlyLoad = hourlyLoad;
                        subject.CreatedAt = DateTime.Now;
                        subject.LastModificationBy = "Preceptor cargando materias";
                        using (var db = new Context())
                        {
                            db.Subjects.Add(subject);
                            db.SaveChanges();
                        }

                        return subject;
                    }
                    catch (SqlException exception)
                    {
                        if (exception.Number == 2601)
                        {
                            // MANEJAR ERROR DE DNI DUPLICADO
                            return null;
                        }
                        else
                            throw; // MANEAJAR EXCEPEPTION INDEFINIDA
                    }
                    return null;
                }


        #endregion
    }
}
*/
