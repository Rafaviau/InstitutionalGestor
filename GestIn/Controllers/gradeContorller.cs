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
        public List<Grade> getStudentGrades(int dni) {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Student.User.Dni == dni).Include(x => x.Subject).ToList();
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        public Grade findGrade(int id) {
            using (var db = new Context())
            {
                try
                {
                    return db.Grades.Where(x => x.Id == id).First();
                }
                catch { }
                return null;

            }
        }
        public bool updateGrade(int gradeId,string grade,string bookrecord,string accDate, string accType)
        {
            using (var db = new Context())
            {
                var result = findGrade(gradeId);
                if (result != null)
                {
                    result.Grade1 = Int32.Parse(grade);
                    result.BookRecord = bookrecord;
                    result.AccreditationDate = DateTime.Parse(accDate);
                    result.AccreditationType = accType;
                    result.UpdatedAt = DateTime.Now;
                    db.Update(result);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
