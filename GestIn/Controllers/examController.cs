using GestIn.Model;
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
        public bool createExam(object subject,object? tituar, object? firstVowel, object? secondVowel, object? thirdVowel, DateTime datetime, string place)
        {
            Subject sub = (Subject)subject;
            Teacher tit = (Teacher)tituar;
            Teacher firstVow = (Teacher)firstVowel;
            Teacher secondVow = (Teacher)secondVowel;
            Teacher thirdVow = (Teacher)thirdVowel;
            try
            {
                Exam exam = new Exam();
                exam.Subject = sub.Id;
                exam.Date = datetime;
                if(tit != null)exam.Titular = tit.Id;
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
    }
}
