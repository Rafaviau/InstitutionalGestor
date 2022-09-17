using GestIn.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestIn.Controllers
{
    internal class careerController
    {
        #region Atributos
        private static careerController? Instance;
        #endregion


        #region Singletone
        private careerController() { }

        public static careerController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new careerController();
            }
            return Instance;
        }
        #endregion


        #region Loaders

        public List<Career> loadCareers()
        {
            using (var db = new Context())
            {
                return db.Careers.ToList();
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
                catch (SqlException exception) { throw exception; }
            }
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
                catch (SqlException exception) { throw exception; }
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
                catch (SqlException exception) { throw exception; }
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
                catch (SqlException exception) { throw exception; }
            }
        }

        #endregion


        #region Career

        public Career createCareer(string ResolutionNum, string name, string degree, string turn)
        {
            Career nuevacarrera = new Career();

            try
            {
                nuevacarrera.Resolution = ResolutionNum;
                nuevacarrera.Name = name;
                nuevacarrera.Degree = degree;
                nuevacarrera.Turn = turn;
                nuevacarrera.CreatedAt = DateTime.Now;
                nuevacarrera.LastModificationBy = "Preceptor cargando materias";
                MessageBox.Show(nuevacarrera.TOSTRING());
                using (var db = new Context())
                {
                    db.Careers.Add(nuevacarrera);
                    db.SaveChanges();
                }

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

        public bool updateCareer(int idcareer, string ResolutionNum, string name, string degree, string turn)
        {
            try
            {
                using (var db = new Context())
                {
                    var updatedCareer = findCareer(idcareer);
                    if (updatedCareer != null)
                    {
                        updatedCareer.Resolution = ResolutionNum;
                        updatedCareer.Name = name;
                        updatedCareer.Degree = degree;
                        updatedCareer.Turn = turn;
                        updatedCareer.LastModificationBy = "Alguien actualizo la carrera";
                        updatedCareer.UpdatedAt = DateTime.Now;
                        db.Update(updatedCareer);
                        db.SaveChanges();
                    }
                }
            }
            catch (SqlException exception) { throw exception; }
            return false;
        }

        internal bool updateCareer(int id, string reso, string name, string degree) //Rafa
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
            catch (SqlException exception) { throw exception; }
            return false;
        }

        public Dictionary<string, string> loadCareerInformation(string ResolutionNum)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                Career career = findCareer(ResolutionNum);
                if (career != null)
                {
                    data.Add("id", career.Id.ToString());
                    data.Add("name", career.Name);
                    data.Add("degree", career.Degree);
                }
                return data;
            }
            catch (SqlException exception) { throw exception; }
        } //Rafa

        public Career findCareer(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Id == id).First();
                    return career;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Career findCareer(string ResolutionNum)
        {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Resolution == ResolutionNum).First();
                    return career;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Career getCareer(object cmbcareer)
        {
            Career thiscareer = (Career)cmbcareer;
            foreach (Career car in loadCareers())
            {
                if (thiscareer.Id == car.Id)
                {
                    thiscareer = car;
                }
            }
            return thiscareer;
        }

        public Career getCareer(int idcareer)
        {
            Career thisCareer = null;
            foreach (Career car in loadCareers())
            {
                if (idcareer == car.Id)
                {
                    thisCareer = car;
                }
            }
            return thisCareer;
        }
        #endregion


        #region Subject

        public List<Subject> getSubjectsFromCareer(object career) //pido las materias de una determinada carrera
        {
            List<Subject> specifiedListSubjects = new List<Subject>();
            Career carreraSelector = (Career)career;

            using (var db = new Context())
            {
                try
                {
                    specifiedListSubjects = db.Subjects.Where(x => x.CareerId == carreraSelector.Id).Include(x => x.Career).ToList();
                    return specifiedListSubjects;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public IEnumerable<Subject> loadSubject(object objectCareer) //Rafa
        {
            Career car = (Career)objectCareer;
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.CareerId == car.Id).ToList();
            }
        }

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

        public Subject createSubject(int careerID, string name, int yearInCareer, int annualTotalhours, object career) //Rafa
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
                catch (SqlException exception) { throw exception; }
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
                catch (SqlException exception) { throw exception; }
            }
        }

        public Subject getSubject(object materiaSelector)
        {
            Subject objMateria = (Subject)materiaSelector;
            return objMateria;
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
        #endregion


        #region Correlatives

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
                catch (SqlException exception) { throw exception; }
            }
        }

        public Correlative findCorrelative(int IDcorrelative)
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
            }
        }

        public IEnumerable<Subject> getEnabledCorrelatives(object objcareer, object objsubject)
        {
            Career carreraSelector = (Career)objcareer;
            Subject subjectSelector = (Subject)objsubject;

            List<Subject> correlativeSubjects = new List<Subject>();
            List<Subject> allSubjects = new List<Subject>();


            foreach (Subject sub in getSubjectsFromCareer(carreraSelector))
            {
                if (carreraSelector.Id != sub.Id)
                {
                    allSubjects.Add(sub);
                    MessageBox.Show(sub.TOSTRING());
                }
                else if (carreraSelector.Id == sub.Id)
                {
                    //MessageBox.Show(subjectSelector.Name + " == " + sub.Name); //algo raro esta pasando aca
                }
            }

            foreach (Correlative cor in getCorrelativesFromSubject(subjectSelector))
            {
                correlativeSubjects.Add(cor.CorrelativeSubject);
                //MessageBox.Show(cor.CorrelativeSubject.TOSTRING());
            }

            IEnumerable<Subject> enabledCorrelativesListSubjects = allSubjects.Except(correlativeSubjects);
            //allSubjects.RemoveAll(i => EnabledCorrelativesListSubjects.Contains(i));
            return enabledCorrelativesListSubjects;
        }

        public List<Correlative> getCorrelativesFromSubject(object subjectMatter) //pido las correlativas de una determinada materia
        {
            List<Correlative> specifiedListCorrelatives = new List<Correlative>();
            Subject existingsubject = getSubject((Subject)subjectMatter);

            using (var db = new Context())
            {
                try
                {
                    specifiedListCorrelatives = db.Correlatives.Where(x => x.SubjectId == existingsubject.Id).Include(x => x.Subject).Include(x => x.CorrelativeSubject).ToList();
                    return specifiedListCorrelatives;
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        #endregion

    }
}

