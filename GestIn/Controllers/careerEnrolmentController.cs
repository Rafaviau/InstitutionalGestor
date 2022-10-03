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
    internal class careerEnrolmentController
    {
        #region Atributos
        private static careerEnrolmentController? Instance;
        #endregion


        #region Singletone
        private careerEnrolmentController() { }

        public static careerEnrolmentController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new careerEnrolmentController();
            }
            return Instance;
        }
        #endregion
        public bool enrolStudent(int studentId, int careerId, int year)
        {
            try
            {
                CareerEnrolment enrol = new CareerEnrolment();
                enrol.StudentId = studentId;
                enrol.CareerId = careerId;
                enrol.YearOfRegistration = year;
                enrol.CreatedAt = DateTime.Now;
                enrol.LastModificationBy = "Preceptor";
                using (var db = new Context())
                {
                    db.CareerEnrolments.Add(enrol);
                    db.SaveChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        public List<CareerEnrolment> searchCareerEnrolment(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.CareerEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Career).ToList();
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        
        public List<Career> searchCareerEnrolmentReturnCareer(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.CareerEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Career).Select(x => x.Career).ToList();
                }
                catch (SqlException exception) { throw exception; }
            }
        }
        
    }
}
