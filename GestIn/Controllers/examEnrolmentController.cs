using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Controllers
{
    internal class examEnrolmentController
    {
        careerController cntCareer = careerController.GetInstance();
        gradeContorller cntGrade = gradeContorller.GetInstance();
        #region Singletone
        private static examEnrolmentController? Instance;
        private examEnrolmentController() { }

        public static examEnrolmentController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new examEnrolmentController();
            }
            return Instance;
        }
        #endregion
        public (bool, Dictionary<Subject, int>?) verifyCorrelatives(int subject, int studentId)
        {
            Dictionary<Subject,int> GradesDict = new Dictionary<Subject,int>();
            bool enabled = true;
            List<Correlative>ListCorrelatives = cntCareer.getCorrelativesFromSubject(subject);
            using (var db = new Context())
            {
                try
                {
                    foreach (Correlative item in ListCorrelatives)
                    {
                        int grade = cntGrade.getLastGrade(item.CorrelativeSubject, studentId);
                        if(grade < 4) enabled = false;
                        GradesDict.Add(item.CorrelativeSubject, grade);
                    }
                    return (enabled, GradesDict);
                }
                catch { return (false,null); }
            }
        }
        public bool enrolStudentToExam(int studentId, int examId)
        {
            try {
                ExamEnrolment exEnrol = new ExamEnrolment();
                exEnrol.StudentId = studentId;
                exEnrol.ExamId = examId;
                exEnrol.CreatedAt = DateTime.Now;
                exEnrol.LastModificationBy = "Preceptor cargando notas";
                using (var db = new Context())
                {
                    db.ExamEnrolments.Add(exEnrol);
                    db.SaveChanges();
                }
                return true;
            }
            catch { return (false); }
        }
        public List<Student> getEnroledStudent(int IdExam)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.ExamId == IdExam && x.DeletedAt == null)).Include(x => x.Student.User).Select(x => x.Student).ToList();
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        public int countEnroledStudent(int IdExam)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Count(x => (x.DeletedAt == null && x.ExamId == IdExam));
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        public ExamEnrolment findExamEnrolment(int studentId, Exam exam)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.ExamEnrolments.Where(x => (x.StudentId == studentId && x.ExamId == exam.Id)).FirstOrDefault();
                }
                catch { }
                return null;

            }
        }
        public (bool,string) unrolStudent(object student, Exam exam) {
                try
                {
                Student stu = (Student)student;
                    var _exam = findExamEnrolment(stu.Id, exam);
                    _exam.DeletedAt = DateTime.Now;
                    using (var db = new Context())
                    {
                        db.Update(_exam);
                        db.SaveChanges();
                        return (true,"Estudiante dado de baja correctamente");
                    }
                }
                catch (Exception exception) { return (false, exception.Message); }
            }
        public (bool, string) unrolStudent(int Idstudent, Exam exam)
        {
            try
            {
                var _exam = findExamEnrolment(Idstudent, exam);
                using (var db = new Context())
                {
                    db.ExamEnrolments.Remove(_exam);
                    db.SaveChanges();
                    return (true, "Estudiante dado de baja correctamente");
                }
            }
            catch (Exception exception) { return (false, exception.Message); }
        }
    }
}
