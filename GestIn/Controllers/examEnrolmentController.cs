using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string enrolStudentToExam(int studentId, int examId)
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
                return "Cargado correctamente";
            }
            catch { return ("Error, intentelo mas tarde"); }
        }
    }
}
