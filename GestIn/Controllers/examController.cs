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
                if (tit != null) exam.Titular = tit.Id;
                if (firstVow != null) exam.FirstVowel = firstVow.Id;
                if (secondVow != null) exam.SecondVowel = secondVow.Id;
                if (thirdVow != null) exam.ThirdVowel = thirdVow.Id;
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
                        if (tit != null) exam.Titular = tit.Id;
                        if (firstVow != null) exam.FirstVowel = firstVow.Id;
                        if (secondVow != null) exam.SecondVowel = secondVow.Id;
                        if (thirdVow != null) exam.ThirdVowel = thirdVow.Id;
                        if (place != null) exam.Place = place;

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
    }
}
