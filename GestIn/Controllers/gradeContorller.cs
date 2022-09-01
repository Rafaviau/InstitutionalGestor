using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Controllers
{
    internal class gradeContorller
    {
        static gradeContorller? Instance;
        private gradeContorller() { }
        public static gradeContorller GetInstance()
        {
            if (Instance == null)
            {
                Instance = new gradeContorller();
            }
            return Instance;
        }

        public bool addGrade(int studentid, object subject, int grade, string bookRecord, DateTime accreditation,string accreditationType) {
            try
            {
                Subject subId = (Subject)subject;
                Grade grade_ = new Grade();
                grade_.StudentId = studentid;
                grade_.SubjectId = subId.Id;
                grade_.Grade1 = grade;
                grade_.BookRecord = bookRecord;
                grade_.AccreditationDate = accreditation;
                grade_.AccreditationType = accreditationType;
                grade_.CreatedAt = DateTime.Now;
                grade_.LastModificationBy = "Preceptor cargando notas";
                using (var db = new Context())
                {
                    db.Grades.Add(grade_);
                    db.SaveChanges();
                }
                return true;
            }
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE DNI DUPLICADO
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return false;
        }
    }
}
