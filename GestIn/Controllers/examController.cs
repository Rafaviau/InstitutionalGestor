using GestIn.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Controllers
{
    internal class examController
    {
        #region Singletone
        careerController cntCareer = careerController.GetInstance();
        private static examController? Instance;
        private examController() { }

        public static examController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new examController();
            }
            return Instance;
        }

        #endregion
        public bool createExam(object subject, object? tituar, object? firstVowel, object? secondVowel, object? thirdVowel, DateTime datetime, string place)
        {
            Subject sub = (Subject)subject;
            Teacher tit = (Teacher)tituar;
            Teacher firstVow = (Teacher)firstVowel;
            Teacher secondVow = (Teacher)secondVowel;
            Teacher thirdVow = (Teacher)thirdVowel;
            try
            {
                Exam exam = new Exam();
                exam.IdSubject = sub.Id;
                exam.Date = datetime;
                exam.Titular = tit?.Id;
                exam.FirstVowel = firstVow?.Id;
                exam.SecondVowel = secondVow?.Id;
                exam.ThirdVowel = thirdVow?.Id;
                if (place != null) exam.Place = place;

                exam.CreatedAt = DateTime.Now;
                exam.LastModificationBy = "Preceptor cargando notas";
                using (var db = new Context())
                {
                    db.Exams.Add(exam);
                    db.SaveChanges();
                }
                return true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            return false;
        }
        public List<Exam> loadExams()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Exams.Where(x => x.Date >= DateTime.Today).Include(x => x.IdSubjectNavigation).Include(x => x.IdSubjectNavigation.Career).ToList();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        public Exam findExam(int code)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Exams.Where(x => x.Id == code)
                        .Include(x => x.IdSubjectNavigation)
                        .Include(x => x.IdSubjectNavigation.Career)
                        .Include(x => x.TitularNavigation.User)
                        .Include(x => x.FirstVowelNavigation.User)
                        .Include(x => x.SecondVowelNavigation.User)
                        .Include(x => x.ThirdVowelNavigation.User)

                        .First();
                }
                catch { }
                return null;

            }
        }
        internal bool updateExam(int Examcode, object subject, object? tituar, object? firstVowel, object? secondVowel, object? thirdVowel, DateTime datetime, string place)
        {
            try
            {
                Subject sub = (Subject)subject;
                Teacher tit = (Teacher)tituar;
                Teacher firstVow = (Teacher)firstVowel;
                Teacher secondVow = (Teacher)secondVowel;
                Teacher thirdVow = (Teacher)thirdVowel;
                using (var db = new Context())
                {
                    var exam = findExam(Examcode);
                    if (exam != null)
                    {
                        exam.IdSubjectNavigation = sub;
                        exam.Date = datetime;
                        exam.Titular = tit?.Id;
                        exam.FirstVowel = firstVow?.Id;
                        exam.SecondVowel = secondVow?.Id;
                        exam.ThirdVowel = thirdVow?.Id;
                        exam.Place = place;

                        exam.LastModificationBy = "Preceptor cargando notas";
                        exam.UpdatedAt = DateTime.Now;
                        db.Update(exam);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (SqlException exception) { throw exception; }
            return false;
        }
        public bool deleteExam(int ExamCode)
        {
            try
            {
                using (var db = new Context())
                {
                    db.Exams.Remove(new Exam() { Id = ExamCode });
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool generateAllExamsFromCareer(object career,DateTime datetime)
        {
            try {
                Career car = (Career)career;
                List<Subject> subjects = cntCareer.loadSubjectsFromCareer(car.Id);
                foreach (Subject s in subjects) {
                    createExam(s, null, null, null, null, datetime, "");
                }
                return true;
            } catch {
                return false;
            }

        }
        public (List<Exam>?, string) loadEnableEnrolmentExams(int studentDni)
        {
            using (var db = new Context())
            {
                try
                {
                    //Trae unicamente las materias que tenga cursada aprobada
                    var enrolment = db.SubjectEnrolments.Where(x => (x.Student.User.Dni == studentDni && x.Approved == true)).Select(x => x.SubjectId).ToList();

                    //Trae las materia en las que ya aprobo el examen
                    var aprovedExams = db.Grades.Where(x => x.Student.User.Dni == studentDni).Select(x => x.SubjectId).ToList();

                    // trae las materia en las que ya se inscribio al examen y la fecha es mayor a la actual
                    var alreadyEnroledExams = db.ExamEnrolments.Where(x => (x.Student.User.Dni == studentDni && x.Exam.Date > DateTime.Now && x.DeletedAt == null))
                        .Select(x => x.Exam.IdSubject)
                        .ToList();

                    if (enrolment != null) { 
                        var result = db.Exams.Where(
                            x => (x.Date >= DateTime.Today 
                                && enrolment.Contains(x.IdSubject) 
                                && !aprovedExams.Contains(x.IdSubject) 
                                && !alreadyEnroledExams.Contains(x.IdSubject)))
                            .Include(x => x.IdSubjectNavigation)
                            .Include(x => x.IdSubjectNavigation.Career)
                         .ToList();
                        return (result,null);
                    }
                    return (null, "El estudiante no esta en condiciones en ninguna cursada");
                }
                catch (SqlException exception) {
                    return (null, exception.Message);
                }
            }
            
        }
    }
}
