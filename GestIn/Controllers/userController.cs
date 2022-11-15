using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using GestIn.Model;
using System.Net;

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
            user = findUser(Dni);
                if (user == null) {
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
                }
                return user;
            }
            catch (SqlException exception) { throw exception; }
            return null;
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

        #endregion

        #region Alumnos

        bool createStudent(bool analitic, bool dni, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil, LoginInformation log, User user)
        {
            try
            {
                Student student = new Student();
                student.User = user;
                student.LoginInformation = log;
                student.DniPhotocopy = dni;
                student.HighSchoolTitPhotocopy = analitic;
                student.Photo4x4 = photo;
                student.MedicalCertificate = medicalCertificate;
                student.BirthCertificate = birthCertificate;
                student.CuilConstansy = cuil;
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

        public bool ExistStudentAsExistingUser(User user, int dni)
        {
            bool status = false;
            if (findStudent(dni).UserId == user.Id)
            {
                status = true;
            }
            return status;
        }

        public bool enrolStudent(int Dni, string mail, string name, string lastname,DateTime? dateOfBirth, string? placeOfBirth, 
            string? phone, string? emergencyphone, string? gender, bool analitic, bool dni, bool birthCertificate, bool medicalCertificate, bool photo, bool cuil)
        {
            if (findStudent(Dni) == null)
            {
                User user = createUser(Dni, name, lastname, dateOfBirth, placeOfBirth, phone, emergencyphone, gender);
                LoginInformation log = createLoginInformation(mail, Dni);
                return createStudent(analitic, dni, birthCertificate, medicalCertificate, photo, cuil, log, user);
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
                LoginInformation log = createLoginInformation(mail, Dni);
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

        public void updateStudent(int dni,string email, string name, string lastname) {
            using (var db = new Context())
            {
                var result = findStudent(dni);
                if (result != null)
                {
                    result.User.Name = name;
                    result.User.LastName = lastname;
                    result.LoginInformation.Email = email;
                    result.UpdatedAt = DateTime.Now;
                    result.LastModificationBy = "Preceptor cargando notas";
                    result.User.UpdatedAt = DateTime.Now;
                    result.User.LastModificationBy = "Preceptor cargando notas";
                    result.LoginInformation.UpdatedAt = DateTime.Now;
                    result.LoginInformation.LastModificationBy = "Preceptor cargando notas";
                    db.Update(result);
                    db.SaveChanges();
                }
            }
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

        bool createTeacher(string? cuil, string? title, LoginInformation log, User user)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.UserId = user.Id;
                teacher.LoginInformationId = log.Id;
                teacher.Cuil = cuil;
                teacher.Titulo = title;
                teacher.CreatedAt = DateTime.Now;
                teacher.LastModificationBy = "Preceptor";
                using (var db = new Context())
                {
                    db.Teachers.Add(teacher);
                    db.SaveChanges();
                }

                return true;
            }
            catch (SqlException exception)
            {
                throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return false;
        }

        public bool updateTeacher(int dni,string? cuil, string? title)
        {
            using (var db = new Context())
            {
                var result = findTeacher(dni);
                
                if (result != null)
                {
                    try
                    {
                        result.Cuil = cuil;
                        result.Titulo = title;
                        result.UpdatedAt = DateTime.Now;
                        result.LastModificationBy = "Preceptor cargando notas";
                        db.Update(result);
                        db.SaveChanges();
                        return true;
                    }
                    catch(SqlException exception) { throw exception; }
                }
                else
                {
                    return false;
                }
            }
        }

        public bool inputTeacher(int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string? placeBirth, 
            string? phone, string? emergencyphone, string? gender, string? cuil, string? title)
        {
            if (findTeacher(Dni) == null) 
            {
                User user = createUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender);
                LoginInformation log = createLoginInformation(mail, Dni);
                return createTeacher(cuil, title, log, user);
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
            if(
                findTeacher(Dni) == null &&
                updateTeacher(existingTeacher.User.Dni, cuil, title) &&
                updateUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender, existingTeacher.User.Dni) &&
                updateLoginInformation(mail, Dni))
            {
                return true;
            }else
            {
                return false;
            }
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

        #endregion
    }
}
