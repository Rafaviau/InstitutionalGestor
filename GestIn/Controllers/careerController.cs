using DocumentFormat.OpenXml.Wordprocessing;
using GestIn.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

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
        public List<Subject> loadSubjectsFromCareer(int careerId)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.Where(x => x.Career.Id == careerId).ToList();
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

        public List<TeacherSubject> loadTeachersSubjects() //Todos los cargos sin filtrar
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
        public int countCareers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Careers.Count();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

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
        public Career createCareer(string resolution, string name, string degree)
        {
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


        public bool updateCareer(int idcareer, string ResolutionNum, string name, string degree, string turn, bool careerState)
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
                        updatedCareer.Active = careerState;
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

        public int countSubjects()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.Count();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
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
                    specifiedListSubjects = db.Subjects.Where(x => x.CareerId == carreraSelector.Id).Include(x => x.Career).OrderByDescending(x => x.YearInCareer).ToList();
                    return specifiedListSubjects;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<Subject> loadSubject(object objectCareer) //Rafa
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
        public Subject findSubject(string subjectName, int careerId)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Subjects.Where(x => (x.Name == subjectName && x.CareerId == careerId)).First();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Subject getSubject(object materiaSelector) //??????????????????????????????????
        {
            Subject objMateria = (Subject)materiaSelector;
            return objMateria;
        }

        public int getSubjectID(object materiaSelector) //??????????????????????????????????
        {
            int id = ((Subject)materiaSelector).Id;
            return id;
        }

        public List<Subject> getSubjectsExceptSame(object objcareer, object objsubject)
        {
            List<Subject> Subjects = new List<Subject>();
            Career carreraSelector = (Career)objcareer;
            Subject subjectSelector = (Subject)objsubject;

            foreach (Subject sub in getSubjectsFromCareer(carreraSelector))
            {
                if (subjectSelector.Id != sub.Id)
                {
                    Subjects.Add(sub);
                }
            }
            return Subjects;
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

                return newCorrelative;
            }
            catch (SqlException exception) { throw exception; }
        }

        public void removeCorrelative(int id)
        {
            Correlative existingCorrelative = findCorrelative(id);
            try
            {
                using (var db = new Context())
                {
                    db.Remove(existingCorrelative);
                    db.SaveChanges();
                }
            }
            catch (SqlException exception) { throw exception; }

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
            using (var db = new Context())
            {
                try
                {
                    var result = db.Correlatives.Where(x => x.Id == IDcorrelative).First();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<Subject> getObjectSubjectsFromCorrelatives(object objsubject)
        {
            List<Subject> correlativeSubjects = new List<Subject>();
            Subject subjectSelector = (Subject)objsubject;
            foreach (Correlative cor in getCorrelativesFromSubject(subjectSelector)) //Metodo
            {
                correlativeSubjects.Add(cor.CorrelativeSubject);
            }
            return correlativeSubjects;
        }

        public List<Subject> getEnabledCorrelatives(object objcareer, object objsubject, bool especial)
        {
            Career carreraSelector = (Career)objcareer;
            Subject subjectSelector = (Subject)objsubject;

            List<Subject> allSubjects = getSubjectsExceptSame(carreraSelector, subjectSelector);
            List<Subject> correlativeSubjects = getObjectSubjectsFromCorrelatives(subjectSelector);

            if(especial)
            {
                allSubjects.RemoveAll(x => x.YearInCareer > subjectSelector.YearInCareer);
            }
            else
            {
                allSubjects.RemoveAll(x => x.YearInCareer >= subjectSelector.YearInCareer);
            }

            if (correlativeSubjects.Any())
            {
                allSubjects.RemoveAll(x => correlativeSubjects.Any(y => y.Id == x.Id));
            }
            return allSubjects;

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
        public List<Correlative> getCorrelativesFromSubject(int IdSubject) //pido las correlativas de una determinada materia
        {
            List<Correlative> specifiedListCorrelatives = new List<Correlative>();
            using (var db = new Context())
            {
                try
                {
                    specifiedListCorrelatives = db.Correlatives.Where(x => x.SubjectId == IdSubject).Include(x => x.Subject).Include(x => x.CorrelativeSubject).ToList();
                    return specifiedListCorrelatives;
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        #endregion


        #region Teachers

        public void assignTeacherCharge(object teacher, object subject, string condition)
        {
            TeacherSubject newCharge = new TeacherSubject();
            Teacher selectedTeacher = (Teacher)teacher;
            Subject selectedSubject = (Subject)subject;
            newCharge.TeacherId = selectedTeacher.Id;
            newCharge.SubjectId = selectedSubject.Id;
            newCharge.DateSince = null;
            newCharge.DateUntil = null;
            newCharge.Active = true;
            newCharge.Condition = condition;
            newCharge.CreatedAt = DateTime.Now;
            newCharge.LastModificationBy = "Preceptor cargando docente";

            if (!getAllActiveCharges(selectedSubject).Any() && !newCharge.Condition.Equals("Suplente"))
            {
                try
                {
                    using (var db = new Context())
                    {
                        db.TeacherSubjects.Add(newCharge);
                        db.SaveChanges();
                    }
                } catch (SqlException exception) { throw exception; }
            }
            else if(newCharge.Condition.Equals("Suplente") 
                && getAllNonSubstituteActiveCharges(selectedSubject).Any())
            {
                try
                {
                    using (var db = new Context())
                    {
                        db.TeacherSubjects.Add(newCharge);
                        db.SaveChanges();
                    }
                } catch (SqlException exception) { throw exception; }
            }
            else if(!newCharge.Condition.Equals("Suplente") 
                && !checkIfSameTeacherInSameCharge(newCharge, selectedSubject))
            {
                TeacherSubject activeteacher = getActiveNonSubstitute(selectedSubject);
                try
                {
                    using (var db = new Context())
                    {
                        db.TeacherSubjects.Add(newCharge);
                        db.SaveChanges();
                        deactivateCharge(activeteacher);
                    }
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public bool checkIfSameTeacherInSameCharge(TeacherSubject thisCharge,Subject subject)
        {
            TeacherSubject activeteacher = getActiveNonSubstitute(subject);
            if(thisCharge.TeacherId == activeteacher.TeacherId)
            {
                MessageBox.Show("Error, mismo docente en el cargo: " + " " + activeteacher.Condition);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changeChargeDates(int teacherID, DateTime datesince, DateTime dateuntil)
        {
            TeacherSubject existingCharge = findTeacherCharge(teacherID);
            if(verifyDateValidity(datesince, dateuntil))
            {
                existingCharge.DateSince = datesince;
                existingCharge.DateUntil = dateuntil;
                try
                {
                    using (var db = new Context())
                    {
                        db.Update(existingCharge);
                        db.SaveChanges();
                    }
                }
                catch (SqlException exception) { throw exception; }
            }
            else { MessageBox.Show("La fecha de Cese debe ser posterior a la fecha de Inicio");  }
        }

        public bool verifyDateValidity(DateTime datesince, DateTime dateuntil)
        {
            bool state = true;
            if (dateuntil <= datesince)
            {
                state = false;
            }
            return state;
        }

        public void deactivateCharge(int teacherID)
        {
            TeacherSubject existingCharge = findTeacherCharge(teacherID);
            if(existingCharge.Condition.Equals("Suplente"))
            {
                try
                {
                    using (var db = new Context())
                    {
                        existingCharge.Active = false;
                        db.Update(existingCharge);
                        db.SaveChanges();
                    }
                }
                catch (SqlException exception) { throw exception; }
            }
            else
            {
                MessageBox.Show("Error, solamente se puede desactivar a suplentes");
            }
            
        }

        public void deactivateCharge(TeacherSubject currentActive)
        {
            using (var db = new Context())
            {
                try
                {
                    currentActive.Active = false;
                    db.Update(currentActive);
                    db.SaveChanges();
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<TeacherSubject> ActiveTeachers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.TeacherSubjects.Where(x => x.Active == true).ToList();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public TeacherSubject findTeacherCharge(object teacherCharge)
        {
            TeacherSubject charge = (TeacherSubject)teacherCharge;
            using (var db = new Context())
            {
                try
                {
                    var result = db.TeacherSubjects.Where(x => x.Id == charge.Id).First();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public TeacherSubject findTeacherCharge(int IDcharge)
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.TeacherSubjects.Where(x => x.Id == IDcharge).First();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public TeacherSubject findTeacherCharge(object teacherCharge, object subjectMatter)
        {
            TeacherSubject charge = (TeacherSubject)teacherCharge;
            Subject subject = (Subject)subjectMatter;
            TeacherSubject existingCharge = null;
            using (var db = new Context())
            {
                try
                {
                    foreach(var item in db.TeacherSubjects)
                    {
                        if (subject.Id == item.SubjectId && charge.TeacherId == item.TeacherId)
                        {
                            existingCharge = item;
                        }
                    }
                    return existingCharge;
                    //var result = db.TeacherSubjects.Where(x => x.SubjectId == subject.Id).First();
                    //return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<TeacherSubject> getTeachersFromSubject(object subjectMatter) //docentes que tienen algun cargo en la materia
        {
            List<TeacherSubject> specifiedListCharges = new List<TeacherSubject>();
            Subject existingsubject = getSubject((Subject)subjectMatter);
            using (var db = new Context())
            {
                try
                {
                    specifiedListCharges = db.TeacherSubjects.Where(x => x.SubjectId == existingsubject.Id && x.Active == true).Include(x => x.Subject).Include(x => x.Teacher.User).ToList();
                    return specifiedListCharges;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public TeacherSubject getActiveNonSubstitute(Subject existingsubject)
        {
            TeacherSubject teacherSubject = null;

            using (var db = new Context())
            {
                try
                {
                    teacherSubject = db.TeacherSubjects.Where(x => x.SubjectId == existingsubject.Id && !x.Condition.Equals("Suplente") && x.Active == true).Include(x => x.Subject).Include(x => x.Teacher.User).First();
                    return teacherSubject;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<TeacherSubject> getAllActiveCharges(Subject subjectMatter)
        {
            List<TeacherSubject> listActiveCharges = new List<TeacherSubject>();  
            using (var db = new Context())
            {
                try
                {
                    listActiveCharges = db.TeacherSubjects.Where(x => x.SubjectId == subjectMatter.Id && x.Active == true).Include(x => x.Subject).Include(x => x.Teacher.User).ToList();
                    return listActiveCharges;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<TeacherSubject> getAllNonSubstituteActiveCharges(Subject subjectMatter)
        {
            List<TeacherSubject> listActiveCharges = new List<TeacherSubject>();
            using (var db = new Context())
            {
                try
                {
                    listActiveCharges = db.TeacherSubjects.Where(x => x.SubjectId == subjectMatter.Id && !x.Condition.Equals("Suplente") && x.Active == true).Include(x => x.Subject).Include(x => x.Teacher.User).ToList();
                    return listActiveCharges;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        /* DEPRECATED METHODS
        
        public void deactivateCharge(int teacherID, object subject, string dateuntil)
        {
            TeacherSubject existingCharge = findTeacherCharge(teacherID);
            Subject existingSubject = (Subject)subject;
            existingCharge.DateUntil = DateTime.Parse(dateuntil);
            try
            {
                using (var db = new Context())
                {
                    existingCharge.Active = false;
                    db.Update(existingCharge);
                    db.SaveChanges();
                }
            }
            catch (SqlException exception) { throw exception; }
        }


        public bool removeTeacherCharge(int teacherID, object subject) //preguntar sobre activo
        {
            TeacherSubject existingCharge = findTeacherCharge(teacherID);
            Subject existingSubject = (Subject)subject;
            try
            {
                using (var db = new Context())
                {
                    var resultTeacher = findTeacherCharge(existingCharge,existingSubject);
                    if (resultTeacher != null)
                    {
                        changeActiveCharge(resultTeacher);
                        //db.Remove(resultTeacher);
                        //db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (SqlException exception) { throw exception; } //deprecated
            return false;
        }

        public void assignActiveCharge() //else
        {
            else 
            {
                List<TeacherSubject> activeteachers = new List<TeacherSubject>();
                activeteachers = ActiveTeachers();
                foreach(TeacherSubject activeteacher in activeteachers)
                {
                    if(activeteacher.TeacherId != newCharge.TeacherId)
                    {
                        try
                        {
                            using (var db = new Context())
                            {
                                db.TeacherSubjects.Add(newCharge);
                                db.SaveChanges();
                                deactivateCharge(newCharge);
                            }
                        }
                        catch (SqlException exception) { throw exception; }
                    }
                }
            }
        }

        public void assignActiveCharge(int teacherID, object subject)
        {
            Subject existingSubject = (Subject)subject;
            TeacherSubject existingCharge = findTeacherCharge(teacherID);
            if(existingCharge.Condition.Equals("Suplente"))
            {
                try
                {
                    using (var db = new Context())
                    {
                        existingCharge.Active = true;
                        db.Update(existingCharge);
                        db.SaveChanges();
                    }
                }
                catch (SqlException exception) { throw exception; }
            }
            else
            {
                List<TeacherSubject> activeteachers = new List<TeacherSubject>();
                activeteachers = getAllActiveCharges(existingSubject);
                if (activeteachers.Any())
                {
                    foreach (TeacherSubject activeteacher in activeteachers)
                    {
                        if (activeteacher.Condition == existingCharge.Condition)
                        {
                            try
                            {
                                using (var db = new Context())
                                {
                                    existingCharge.Active = true;
                                    db.Update(existingCharge);
                                    db.SaveChanges();
                                    removeActiveCharge(activeteacher);
                                }
                            }
                            catch (SqlException exception) { throw exception; }
                        }
                        else if(activeteacher.Condition != existingCharge.Condition)
                        {

                        }
                    }
                }
                else
                {
                    try
                    {
                        using (var db = new Context())
                        {
                            existingCharge.Active = true;
                            db.Update(existingCharge);
                            db.SaveChanges();
                        }
                    }
                    catch (SqlException exception) { throw exception; }
                }
            }
        }
        */




        #endregion
    }
}

