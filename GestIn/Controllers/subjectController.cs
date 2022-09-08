using GestIn.Model;
using GestIn.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestIn.Controllers
{
    internal class subjectController
    {
        #region Atributos
        private List<Subject> ListSubjects = new List<Subject>();
        private List<Correlative> ListCorrelatives = new List<Correlative>();
        private List<TeacherSubject> ListTeachers = new List<TeacherSubject>();
        private List<Schedule> ListSchedules = new List<Schedule>();
        private static subjectController? Instance;
        //ControladoraPersona personaController; // para Testear
        #endregion

        #region Singletone
        private subjectController()
        {
            /*
            ListSubjects = new List<Subject>();
            ListCorrelatives = new List<Correlative>();
            ListTeachers = new List<TeacherSubject>();
            ListSchedules = new List<Schedule>();
            */

            ListSubjects = loadSubjects();
            ListCorrelatives = loadCorrelatives();
            ListTeachers = loadTeachers();
            ListSchedules = loadSchedules();
            
        }

        public static subjectController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new subjectController();
            }
            return Instance;
        }
        #endregion

        #region ReturnList
        public List<Subject> ReturnListSubjects()
        {
            return ListSubjects;
        }
        public List<Correlative> ReturnListCorrelatives()
        {
            return ListCorrelatives;
        }
        public List<TeacherSubject> ReturnListTeachers()
        {
            return ListTeachers;
        }
        public List<Schedule> ReturnListSchedules()
        {
            return ListSchedules;
        }
        

        #endregion

        public Subject createSubject(int careerID, string name, int yearInCareer, int annualTotalhours)
        {
            Subject nuevaMateria = new Subject();
            try
            {
                nuevaMateria.CareerId = careerID;
                nuevaMateria.Name = name;
                nuevaMateria.YearInCareer = yearInCareer;
                nuevaMateria.AnnualHourlyLoad = annualTotalhours;
                nuevaMateria.CreatedAt = DateTime.Now;
                nuevaMateria.LastModificationBy = "Preceptor cargando materias";
                using (var db = new Context())
                {
                    db.Subjects.Add(nuevaMateria);
                    db.SaveChanges();
                }
                MessageBox.Show("CREATED SUCCESSFULLY");

                ListSubjects.Add(nuevaMateria);
                return nuevaMateria;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        public Subject createSubject(int careerID, string name, int yearInCareer, int annualTotalhours,object career) //Rafa
        {
            Subject nuevaMateria = new Subject();
            try
            {
                nuevaMateria.CareerId = careerID;
                nuevaMateria.Name = name;
                nuevaMateria.YearInCareer = yearInCareer;
                nuevaMateria.AnnualHourlyLoad = annualTotalhours;
                nuevaMateria.CreatedAt = DateTime.Now;
                nuevaMateria.LastModificationBy = "Preceptor cargando materias";
                using (var db = new Context())
                {
                    db.Subjects.Add(nuevaMateria);
                    db.SaveChanges();
                }
                MessageBox.Show("CREATED SUCCESSFULLY");

                ListSubjects.Add(nuevaMateria);
                return nuevaMateria;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        public IEnumerable<Subject> loadSubject(object objectCareer)
        {
            Career car = (Career)objectCareer;
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.CareerId == car.Id).ToList();
            }
        }

        public Subject findSubject(object objectSubject)
        {
            Subject subject = (Subject)objectSubject;
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.Where(x => x.Id == subject.Id).First();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public bool updateSubject(object carreraExistenteObject, object materiaObject, string nombre, int anioEnCarrera, int cargaHorariaTotal)
        {
            Career carreraExistente = (Career)carreraExistenteObject;
            Subject existingSubject = (Subject)materiaObject;
            try
            {
                using (var db = new Context())
                {
                    var resultSubject = findSubject(existingSubject.Id);
                    if (resultSubject != null)
                    {
                        resultSubject.Name = nombre;
                        resultSubject.YearInCareer = anioEnCarrera;
                        resultSubject.AnnualHourlyLoad = cargaHorariaTotal;
                        resultSubject.CareerId = carreraExistente.Id; //Check Later
                        resultSubject.LastModificationBy = "Alguien actualizo esta materia";
                        resultSubject.UpdatedAt = DateTime.Now;
                        db.Update(resultSubject);
                        db.SaveChanges();
                        return true;
                    }
                }
            }

            catch { }
            return false;
        }


        public Subject getSubject(object materiaSelector) //Checklist casteando
        {
            Subject objMateria = (Subject)materiaSelector;
            return objMateria;
        }

        public List<Correlative> loadCorrelatives()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Correlatives.ToList();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public List<Subject> loadSubjects()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.ToList();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public List<TeacherSubject> loadTeachers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.TeacherSubjects.ToList();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public List<Schedule> loadSchedules()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Schedules.ToList();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public List<Subject> getSubjectsFromCareer(object career) //pido las materias de una determinada carrera
        {
            List<Subject> specifiedListSubjects = new List<Subject>(); 
            Career carreraSelector = (Career)career;

            foreach (Subject subject in ListSubjects)
            {
                if (subject.CareerId == carreraSelector.Id)
                {
                    specifiedListSubjects.Add(subject);
                    //MessageBox.Show(subject.TOSTRING());
                }
            } 
            return specifiedListSubjects;
        }
        public Subject getSpecificSubjectFromCareer(object careerMatter, int subjectID) //Pedir -> Docentes/Cronograma/Correlativas
        {
            Subject subject = null;
            foreach (Subject materia in getSubjectsFromCareer(careerMatter))
            {
                if (subjectID == materia.Id)
                {
                    subject = materia;
                }
            }
            return subject;
        }

        public Subject getSpecificSubjectFromCareer(object careerMatter, object subjectMatter) //Pedir -> Docentes/Cronograma/Correlativas
        {
            Subject subject = (Subject)subjectMatter;
            Career career = (Career)careerMatter;
            foreach (Subject materia in getSubjectsFromCareer(careerMatter))
            {
                if (subject.Id == career.Id)
                {
                    subject = materia;
                }
            }
            return subject;
        }

        public List<Correlative> getCorrelativesFromSubject(object subjectMatter) //pido las correlativas de una determinada materia
        {
            List <Correlative> specifiedListCorrelatives = new List<Correlative>();
            Subject subject = (Subject)subjectMatter;

            foreach (Correlative cor in ListCorrelatives)
            {
                if (subject.Id == cor.SubjectId)
                {
                    specifiedListCorrelatives.Add(cor);
                }
            }
            return specifiedListCorrelatives;
        }

        /*

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
        */
    }
}
