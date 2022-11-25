using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Controllers
{
    internal class subjectEnrolmentController
    {
        static subjectEnrolmentController? Instance;
        private subjectEnrolmentController() { }
        public static subjectEnrolmentController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new subjectEnrolmentController();
            }
            return Instance;
        }

        public bool enrolToAprovedSubject(int studentId, object subject, int year,bool presential) {
            Subject sub = (Subject)subject;
            try {
                SubjectEnrolment enrol = new SubjectEnrolment();
                enrol.StudentId = studentId;
                enrol.SubjectId = sub.Id;
                enrol.Year = year;
                enrol.Presential = presential;
                enrol.Approved = true;
                enrol.CreatedAt = DateTime.Now;
                enrol.LastModificationBy = "Preceptor";
                using (var db = new Context())
                {
                    db.SubjectEnrolments.Add(enrol);
                    db.SaveChanges();
                    return true;
                }
            } catch { }
            return false;
        }
        public SubjectEnrolment getEnrolment(int dni, object subject)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => (x.Student.User.Dni == dni && x.Subject == subject && x.Approved == true)).First(); ;
            }
        }
        public SubjectEnrolment getEnrolment(int dni, object subject, object career)
        {
            Subject thisSubject = (Subject)subject;
            CareerEnrolment thisCareer = (CareerEnrolment)career;
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.SubjectId == thisSubject.Id && x.Approved == true && x.Subject.CareerId == thisCareer.CareerId).FirstOrDefault(); ;
            }
        }
        public List<SubjectEnrolment> getEnrolments(int dni)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni).Include(x => x.Subject).ToList(); ;
            }
        }

        public List<SubjectEnrolment> getEnrolments(int dni, object career)
        {
            CareerEnrolment thisCareer = (CareerEnrolment)career;
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni && x.Subject.CareerId == thisCareer.CareerId).Include(x => x.Subject).ToList(); ;
            }
        }

        public List<Subject> getEnrolmentsSubjects(int dni)
        {
            using (var db = new Context())
            {
                return db.SubjectEnrolments.Where(x => x.Student.User.Dni == dni).Select(x => x.Subject).ToList(); ;
            }
        }

        public SubjectEnrolment findEnrolment(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.SubjectEnrolments.Where(x => x.Id == id).First();
                }
                catch { }
                return null;

            }
        }
        public bool updateEnrolment(int enrolmentId, string Year, bool Presential)
        {
            using (var db = new Context())
            {
                SubjectEnrolment result = findEnrolment(enrolmentId);
                if (result != null)
                {
                    result.Year = Int32.Parse(Year);
                    result.Presential = Presential;
                    result.UpdatedAt = DateTime.Now;
                    db.Update(result);
                    db.SaveChanges();
                }
            }
            return true;
        }
        public bool deleteEnrolment(int enrolId)
        {
            try
            {
                using (var db = new Context())
                {
                    db.SubjectEnrolments.Remove(new SubjectEnrolment() { Id = enrolId });
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getAcreditationType(int dni,int Idsubject) {
            using (var db = new Context())
            {
                string result = "Libre";
                bool state = db.SubjectEnrolments.Where(x => (x.Student.User.Dni == dni && x.SubjectId == Idsubject)).Select(x => x.Presential).FirstOrDefault();
                if (state == true)
                    result = "Presencial";
                return result;
            }
        }
        public string getAcreditationTypeWithStudentId(int studentId, int Idsubject)
        {
            using (var db = new Context())
            {
                string result = "Libre";
                bool state = db.SubjectEnrolments.Where(x => (x.StudentId == studentId && x.SubjectId == Idsubject)).Select(x => x.Presential).FirstOrDefault();
                if (state == true)
                    result = "Presencial";
                return result;
            }
        }
    }
}
