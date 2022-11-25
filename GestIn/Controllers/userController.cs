using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using GestIn.Model;
using System.Net;
using Microsoft.VisualBasic.Logging;

namespace GestIn.Controllers
{
    internal class userController
    {
        static userController? Instance;

        private userController() { }

        public static userController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new userController();
            }
            return Instance;
        }

        #region login
        public bool verifyLogin(string email, string pass) {
            using (var db = new Context())
            {
                LoginInformation log = db.LoginInformations.Where(u => u.Email == email).FirstOrDefault();
                if (log != null) {
                    if (System.Web.Helpers.Crypto.VerifyHashedPassword(log.Password, pass)) { return true; }
                }
            }
            return false;
        }
        #endregion

        #region User

        public int countUsers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Users.Count();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public int countStudents() 
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students.Count();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<Student> loadStudent()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Students.ToList();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public bool CheckSameUserDNI(int dni)
        {
            bool repetition = false;
            if (findUser(dni) != null)
            {
                repetition = true;
            }
            return repetition;
        }

        public User? findUser(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Users.Where(x => x.Dni == dni).FirstOrDefault();
                }
                catch { }
                return null;

            }
        }
        User createUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                                string phone, string emergencyphone, string gender)
        {
            try
            {
                User user = new User();
                user.Dni = Dni;
                user.Name = name;
                user.LastName = lastname;
                user.DateOfBirth = dateOfBirth;
                user.PlaceOfBirth = placeOfBirth;
                user.Gender = gender;
                user.PhoneNumbre = phone;
                user.EmergencyPhoneNumber = emergencyphone;
                user.CreatedAt = DateTime.Now;
                user.LastModificationBy = name + " " + lastname;
                using (var db = new Context())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                return user;
            }
            catch (SqlException exception) { throw exception; }
        }

        User createUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string phone)
        {
            User user = new User();
            user = findUser(Dni);
            try
            {
                if (user == null)
                {
                    user.Dni = Dni;
                    user.Name = name;
                    user.LastName = lastname;
                    user.DateOfBirth = dateOfBirth;
                    user.PhoneNumbre = phone;
                    user.CreatedAt = DateTime.Now;
                    user.LastModificationBy = "Preceptor cargando notas";
                }
                return user;
            }

            catch (SqlException exception) { throw exception; }
        }

        bool updateUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string? placeOfBirth,
                                string? phone, string? emergencyphone, string? gender, int oldDni)
        {
            var result = findUser(oldDni);
            try
            {
                result.Dni = Dni;
                result.Name = name;
                result.LastName = lastname;
                result.DateOfBirth = dateOfBirth;
                result.PlaceOfBirth = placeOfBirth;
                result.Gender = gender;
                result.PhoneNumbre = phone;
                result.EmergencyPhoneNumber = emergencyphone;
                result.CreatedAt = DateTime.Now;
                result.LastModificationBy = name + " " + lastname;

                using (var db = new Context())
                {
                    db.Update(result);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (SqlException exception) { throw exception; return false; }
        }

        LoginInformation createLoginInformation(string email, int dni)
        {
            try
            {
                LoginInformation log = new LoginInformation();
                log.Email = email;
                log.Password = System.Web.Helpers.Crypto.HashPassword(dni.ToString());
                log.CreatedAt = DateTime.Now;
                log.LastModificationBy = "Preceptor cargando notas";
                return log;
            }
            catch (SqlException exception) { throw exception; }
            return null;
        }

        bool updateLoginInformation(string? email, int dni)
        {
            LoginInformation existingLog = findTeacher(dni).LoginInformation;
            try
            {
                existingLog.Email = email;
                existingLog.Password = System.Web.Helpers.Crypto.HashPassword(dni.ToString());
                existingLog.CreatedAt = DateTime.Now;
                existingLog.LastModificationBy = "Preceptor";

                using (var db = new Context())
                {
                    db.Update(existingLog);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (SqlException exception) { throw exception; return false; }
        }

        #endregion

        #region Alumnos

        bool createStudent(int Dni, string? ocupation, string? workhours, string? healthcare,
            bool analitic, bool photodni, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative , User user, LoginInformation log)
        {
            bool status = false;
            try
            {
                User thisUser = findUser(Dni);
                Student student = new Student();
                student.WorkActivity = ocupation;
                student.WorkingHours = workhours;
                student.SocialWork = healthcare;
                student.DniPhotocopy = photodni;
                student.HighSchoolTitPhotocopy = analitic;
                student.Photo4x4 = photo;
                student.MedicalCertificate = medicalCertificate;
                student.BirthCertificate = birthCertificate;
                student.CuilConstansy = cuil;
                student.Cooperative = cooperative;
                student.CreatedAt = DateTime.Now;
                student.UserId = user.Id;
                student.LoginInformation = log;
                student.LastModificationBy = "Preceptor carando notas";
                using (var db = new Context())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }
                status = true;
            }
            catch (SqlException exception) { throw exception; }
            return status;
        }

        public bool modifyUserStudent(object student, int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string? placeBirth,
            string? phone, string? emergencyphone, string? gender, string? ocupation, string? workhours, string? healthcare,
            bool analitic, bool dniPhoto, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative)
        {
            Student existingStudent = (Student)student;
            bool state = false;
            if (findStudent(Dni) == null)
            {
                state = false;
            }
            else
            {
                try
                {
                    updateStudent(existingStudent, ocupation, workhours, healthcare, analitic, dniPhoto, birthCertificate, medicalCertificate, photo, cuil, cooperative);
                    updateUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender, existingStudent.User.Dni);
                    updateLoginInformation(mail, Dni);
                    state = true;
                }
                catch { }
            }
            return state;
        }

        bool createStudent(int Dni, string mail, string name, string lastname, LoginInformation log, User user)
        {//EXCEL
            try
            {
                Student student = new Student();
                student.UserId = user.Id;
                student.LoginInformationId = log.Id;
                student.DniPhotocopy = false;
                student.HighSchoolTitPhotocopy = false;
                student.Photo4x4 = false;
                student.MedicalCertificate = false;
                student.BirthCertificate = false;
                student.CuilConstansy = false;
                student.Cooperative = false;
                student.CreatedAt = DateTime.Now;
                student.LastModificationBy = "Preceptor carando notas";
                using (var db = new Context())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }

                return true;
            }
            catch (SqlException exception) { throw exception; }
            return false;
        }
        
        public void updateStudent(Student existingStudent, string? ocupation, string? workhours, string? healthcare,
            bool analitic, bool dniPhoto, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative)
        {
            using (var db = new Context())
            {
                existingStudent.WorkActivity = ocupation;
                existingStudent.WorkingHours = workhours;
                existingStudent.SocialWork = healthcare;
                existingStudent.HighSchoolTitPhotocopy = analitic;
                existingStudent.DniPhotocopy = dniPhoto;
                existingStudent.BirthCertificate = birthCertificate;
                existingStudent.MedicalCertificate = medicalCertificate;
                existingStudent.Photo4x4 = photo;
                existingStudent.CuilConstansy = cuil;
                existingStudent.Cooperative = cooperative;
                existingStudent.UpdatedAt = DateTime.Now;
                existingStudent.LastModificationBy = "Preceptor modifico estudiante";
                db.Update(existingStudent);
                db.SaveChanges();
            }
        }

        public bool enrolStudent(int Dni, string mail, string name, string lastname,DateTime? dateOfBirth, string? placeOfBirth, 
            string? phone, string? emergencyphone, string? gender, string? ocupation, string? workHours, string? healthcare,
            bool analitic, bool photodni, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, bool cooperative)
        {
            if (findStudent(Dni) == null)
            {
                User thisuser = createUser(Dni, name, lastname, dateOfBirth, placeOfBirth, phone, emergencyphone, gender);
                LoginInformation createdLog = createLoginInformation(mail, Dni);
                return createStudent(Dni, ocupation, workHours, healthcare, analitic, photodni, birthCertificate, medicalCertificate, photo, cuil, cooperative, thisuser, createdLog);
            }
            else
            { 
                return false;
            }
        }

        public bool enrolStudent(int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string phone) //Student
        {
            User user = createUser(Dni, name, lastname, dateOfBirth, phone);
            if (user != null)
            {
                //LoginInformation log = createLoginInformation(mail, Dni);
                LoginInformation log = new LoginInformation();
                if (log != null)
                {
                    return (createStudent(Dni, mail, name, lastname, log, user));
                }
            }
            return false;
        }

        public Student findStudent(int dni) {
            using (var db = new Context())
            {
                try { 
                    var student = db.Students.Where(x => x.User.Dni == dni).Include(x => x.User).Include(x => x.LoginInformation).FirstOrDefault();
                    return student;
                }
                catch (SqlException exception) { throw exception;}
            }
        }

        public Student getStudent(object student)
        {
            return (Student)student;
        }

        public Dictionary<string, string> loadStudentInformation(int dni) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try {
                Student student = findStudent(dni);
                if (student != null) {
                    data.Add("name", student.User.Name);
                    data.Add("lastname", student.User.LastName);
                    data.Add("email", student.LoginInformation.Email);
                    return data;
                }
                return null;
            } catch { }
            return null;
        }

        public List<Student> searchBoxStudentWithString(string search)
        {
            using (var db = new Context())
            {
                var list = db.Students.Where(x => (x.User.Name.StartsWith(search) || x.User.LastName.StartsWith(search))).Include(x => x.LoginInformation).Include(x => x.User).ToList();
                return list;
            }
        }
        public List<Student> searchBoxStudentWithInt(int search)
        {
            using (var db = new Context())
            {
                var list = db.Students.Where(x => x.User.Dni.ToString().StartsWith(search.ToString())).Include(x => x.LoginInformation).Include(x => x.User).ToList();
                return list;
            }
        }
        public void updateStudentPhone(int dni, string phone) {
            using (var db = new Context())
            {
                var result = findUser(dni);
                if (result != null)
                {
                    result.PhoneNumbre = phone;
                    result.UpdatedAt = DateTime.Now;
                    db.Update(result);
                    db.SaveChanges();
                }
            }
        }
        #endregion

        #region Docentes

        public int countTeachers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Teachers.Count();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public List<Teacher> loadTeachers()
        {
            using (var db = new Context())
            {
                try
                {
                    var result = db.Teachers.ToList();
                    return result;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Teacher findTeacher(int dni) //deprecated
        {
            using (var db = new Context())
            {
                try
                {
                    var teacher = db.Teachers.Where(x => x.User.Dni == dni).Include(x => x.User).Include(x => x.LoginInformation).FirstOrDefault();
                    return teacher;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public Teacher findTeacherByID(int? id)
        {
            using (var db = new Context())
            {
                try
                {
                    var teacher = db.Teachers.Where(x => x.Id == id).Include(x => x.User).Include(x => x.LoginInformation).FirstOrDefault();
                    return teacher;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        bool createTeacher(int dni, string? cuil, string? title, User user, LoginInformation log)
        {
            bool status = false;
            try
            {
                User thisUser = findUser(dni);
                Teacher teacher = new Teacher();
                teacher.Cuil = cuil;
                teacher.Titulo = title;
                teacher.UserId = user.Id;
                teacher.LoginInformation = log;
                teacher.CreatedAt = DateTime.Now;
                teacher.LastModificationBy = "Preceptor";
                using (var db = new Context())
                {
                    db.Teachers.Add(teacher);
                    db.SaveChanges();
                }
                status = true;
            }
            catch (SqlException exception)
            {
                throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return status;
        }

        public bool updateTeacher(Teacher existingTeacher, string? cuil, string? title)
        {
            using (var db = new Context())
            {
                try
                {
                    existingTeacher.Cuil = cuil;
                    existingTeacher.Titulo = title;
                    existingTeacher.UpdatedAt = DateTime.Now;
                    existingTeacher.LastModificationBy = "Preceptor cargando notas";
                    db.Update(existingTeacher);
                    db.SaveChanges();
                    return true;
                }
                catch (SqlException exception) { throw exception; }
            }
        }

        public bool inputTeacher(int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string? placeBirth, 
            string? phone, string? emergencyphone, string? gender, string? cuil, string? title)
        {
            if (findTeacher(Dni) == null) 
            {
                User user = createUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender);
                LoginInformation createdLog = createLoginInformation(mail, Dni);
                return createTeacher(Dni, cuil, title, user, createdLog);
                //return JoinUserTypeLoginInformation(createdTeacher, createdLog);
            }
            else
            {
                return false;
            }
        }

        public bool modifyUserTeacher(object teacher,int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string? placeBirth,
            string? phone, string? emergencyphone, string? gender, string? cuil, string? title)
        {
            Teacher existingTeacher = (Teacher)teacher;
            bool state = false;
            if(findTeacher(Dni) == null)
            {
                state = true;
            }
            else
            {
                try
                {
                    updateTeacher(existingTeacher, cuil, title);
                    updateUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender, existingTeacher.User.Dni);
                    updateLoginInformation(mail, Dni);
                    state = true;
                } catch { }
            }
            return state;
        }

        public Teacher getTeacher(object teacher)
        {
            return (Teacher)teacher;
        }

        public List<Teacher> searchBoxTeacherWithString(string search)
        {
            using (var db = new Context())
            {
                var list = db.Teachers.Where(x => x.User.Name.StartsWith(search) || x.User.LastName.StartsWith(search)).Include(x => x.LoginInformation).Include(x => x.User).ToList();
                return list;
            }
        }

        public List<Teacher> searchBoxTeacherWithInt(int search)
        {
            using (var db = new Context())
            {
                var list = db.Teachers.Where(x => x.User.Dni.ToString().StartsWith(search.ToString())).Include(x => x.LoginInformation).Include(x => x.User).ToList();
                return list;
            }
        }

        public List<Teacher> getAllTeachersFromCareer(object career) {
            var _career = (Career)career;
            using (var db = new Context())
            {
                var list = db.TeacherSubjects
                    .Where(x => (x.Subject.CareerId == _career.Id && x.Active == true))
                    .Include(x => x.Teacher.User)
                    .Select(x => x.Teacher)
                    .Distinct()
                    .ToList();
                return list;
            }
        }

        public int? getMostResentActiveTeacherId(object _Subject) {
            Subject sub = (Subject)_Subject;
            using (var db = new Context())
            {
                var teacherId = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == sub.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => x.Teacher.Id)
                    .FirstOrDefault();
                return teacherId;
            }
        }

        public User? getMostResentActiveUserTeacher(object _Subject)
        {
            Subject sub = (Subject)_Subject;
            using (var db = new Context())
            {
                var teacher = db.TeacherSubjects?
                    .Where(x => (x.Subject.Id == sub.Id && x.Active == true))
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => x.Teacher.User)
                    .FirstOrDefault();
                return teacher;
            }
        }

        #endregion

    }
}
