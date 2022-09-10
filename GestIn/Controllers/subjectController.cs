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
        //private List<TeacherSubject> ListTeachers = new List<TeacherSubject>();
        //private List<Schedule> ListSchedules = new List<Schedule>();
        private static subjectController? Instance;
        //ControladoraPersona personaController; // para Testear
        #endregion

        #region Singletone
        private subjectController()
        {
            //ListTeachers = new List<TeacherSubject>();
            //ListSchedules = new List<Schedule>();
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

        /*
        public List<TeacherSubject> ReturnListTeachers()
        {
            return ListTeachers;
        }
        public List<Schedule> ReturnListSchedules()
        {
            return ListSchedules;
        }
        */
        

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

                return nuevaMateria;
            }
            catch (SqlException exception)
            {
                throw exception;
            }
        }

        public bool updateSubject(object materiaObject, string nombre, int anioEnCarrera, int cargaHorariaTotal)
        {
            Subject existingSubject = (Subject)materiaObject;
            try
            {
                using (var db = new Context())
                {
                    var resultSubject = findSubject(existingSubject);
                    if (resultSubject != null)
                    {
                        resultSubject.Name = nombre;
                        resultSubject.YearInCareer = anioEnCarrera;
                        resultSubject.AnnualHourlyLoad = cargaHorariaTotal;
                        //resultSubject.CareerId = carreraExistente.Id; //Check Later
                        resultSubject.LastModificationBy = "Alguien actualizo esta materia";
                        resultSubject.UpdatedAt = DateTime.Now;
                        db.Update(resultSubject);
                        db.SaveChanges();
                        return true;
                    }
                }
                MessageBox.Show("MATERIA ACTUALIZADA");
            }

            catch { }
            return false;
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

        public Subject findSubject(int subjectID)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.Where(x => x.Id == subjectID).First();
                    return result;
                }
                catch { }
                return null;
            }
        }

        public Correlative findCorrelative(object objectCorrelative)
        {
            Correlative correlative = (Correlative)objectCorrelative;
            using (var db = new Context())
            {
                try
                {
                    var result = db.Correlatives.Where(x => x.Id == correlative.Id).First();
                    return result;
                }
                catch { }
                return null;
            }
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

            using (var db = new Context())
            {
                try
                {
                    foreach (var item in db.Subjects.Where(x => x.CareerId == carreraSelector.Id).ToList())
                    {
                        specifiedListSubjects.Add(item);
                    }
                    return specifiedListSubjects;
                }
                catch (SqlException exception) { throw exception; }
                return null;
            }
            return specifiedListSubjects;
        }

        public List<Subject> getSubjectsFromCareer(object objcareer, object objsubject) // pido las materias menos la misma para correlativas
        {
            List<Subject> specifiedListSubjects = new List<Subject>();
            Career carreraSelector = (Career)objcareer;
            Subject subjectSelector = (Subject)objsubject;

            foreach (Subject subject in getSubjectsFromCareer(carreraSelector))
            {
                foreach (Correlative correlative in getCorrelativesFromSubject(subjectSelector))
                {
                    if (subject.CareerId == carreraSelector.Id && subject.Id != subjectSelector.Id && subjectSelector.YearInCareer > subject.YearInCareer && correlative.CorrelativeSubjectId != subject.Id) //que la id de la materia que estoy pasando no sea la misma que en la que esta en la lista
                    {
                        specifiedListSubjects.Add(subject);
                        //MessageBox.Show(subject.TOSTRING());
                    }
                }

            }
            return specifiedListSubjects;
        }

        public Subject getSpecificSubjectFromCareer(object careerMatter, int subjectID) //Pedir una materia especifica por int
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


        public Subject getSpecificSubjectFromCareer(object careerMatter, object subjectMatter) //Pedir una materia especifica por obj
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
            List<Correlative> specifiedListCorrelatives = new List<Correlative>();
            Subject existingsubject = getSubject((Subject)subjectMatter);

            using (var db = new Context())
            {
                try
                {
                    foreach (var correlative in db.Correlatives.Where(x => x.SubjectId == existingsubject.Id).ToList())
                    {
                        if(correlative.SubjectId == existingsubject.Id)
                        {
                            correlative.Subject = findSubject(correlative.CorrelativeSubjectId);
                            //MessageBox.Show(correlative.Id + " " + correlative.Subject.Name + " || " + existingsubject.Id + " " + existingsubject.Name);
                            specifiedListCorrelatives.Add(correlative);
                        }
                    }
                    return specifiedListCorrelatives;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Correlative createCorrelative(object subject, object cmbsubject, bool state)
        {
            Correlative newCorrelative = new Correlative();
            Subject selectedSubject = (Subject)subject;
            Subject correlativeSubject = (Subject)cmbsubject;
            try
            {
                newCorrelative.SubjectId = selectedSubject.Id;
                newCorrelative.CorrelativeSubjectId = correlativeSubject.Id;
                newCorrelative.CorrelativeFinal = state;
                newCorrelative.CreatedAt = DateTime.Now;
                newCorrelative.LastModificationBy = "Preceptor cargando materias";
                using (var db = new Context())
                {
                    db.Correlatives.Add(newCorrelative);
                    db.SaveChanges();
                }
                MessageBox.Show("CORRELATIVE ADDED");

                return newCorrelative;
            }
            catch (SqlException exception) { throw exception; }
        }

        public bool removeCorrelative(object cmbcorrelative)
        {
            Correlative existingCorrelative = (Correlative)cmbcorrelative;
            try
            {
                using (var db = new Context())
                {
                    var resultCorrelative = findCorrelative(existingCorrelative);
                    if (resultCorrelative != null)
                    {
                        db.Remove(resultCorrelative);
                        db.SaveChanges();
                        return true;
                    }
                    MessageBox.Show("CORRELATIVE REMOVED");
                }
            }
            catch (SqlException exception) { throw exception; }
            return false;

        }

        public Correlative getCorrelative(int IDcorrelative)
        {
            Correlative correlative = null;
            using (var db = new Context())
            {
                try
                {
                    foreach (Correlative cor in db.Correlatives.Where(x => x.Id == IDcorrelative).ToList())
                    {
                        if (cor.Id == IDcorrelative)
                        {
                            correlative = cor;
                        }
                    }
                    return correlative;
                }
                catch (SqlException exception) { throw exception; }
                return null;
            }

            
        }

          /*
         * 
         * DEPRECATED 
        public List<Correlative> getCorrelativesFromSubject(object subjectMatter) //pido las correlativas de una determinada materia
        {
            List <Correlative> specifiedListCorrelatives = new List<Correlative>();
            Subject existingsubject = (Subject)subjectMatter;
            
            foreach (Correlative cor in ListCorrelatives)
            {
                //MessageBox.Show("Amount Correlatives " + " " + specifiedListCorrelatives.Count + " " + existingsubject.Id + " VS " + cor.CorrelativeSubjectId);
                if (existingsubject.Id == cor.CorrelativeSubjectId)
                {
                    specifiedListCorrelatives.Add(cor);
                    
                }
            }
            return specifiedListCorrelatives;
        }
        */
    }
}
