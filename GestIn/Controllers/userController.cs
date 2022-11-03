using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using GestIn.Model;

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

        public User findUser(int dni)
        {
            using (var db = new Context())
            {
                try
                {
                    return db.Students.Where(x => x.User.Dni == dni).Select(x => x.User).First();
                }
                catch { }
                return null;

            }
        }
        User createUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone)
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
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE DNI DUPLICADO
                    return null;
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return null;
        }

        User createUser(int Dni, string name, string lastname, DateTime? dateOfBirth, string phone)
        {
            Student search = findStudent(Dni);
            if (search != null) { return search.User; }
            try
            {
                User user = new User();
                user.Dni = Dni;
                user.Name = name;
                user.LastName = lastname;
                user.DateOfBirth = dateOfBirth;
                user.PhoneNumbre = phone;
                user.CreatedAt = DateTime.Now;
                user.LastModificationBy = "Preceptor cargando notas";

                using (var db = new Context())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return user;
            }
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE DNI DUPLICADO
                    return null;
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
        }
        User createUser(int Dni, string name, string lastname)
        {
            Student search = findStudent(Dni);
            if (search != null) { return search.User; }
            try
            {
                User user = new User();
                user.Dni = Dni;
                user.Name = name;
                user.LastName = lastname;
                user.CreatedAt = DateTime.Now;
                user.LastModificationBy = "Preceptor cargando notas";

                using (var db = new Context())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return user;
            }
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE DNI DUPLICADO
                    return null;
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return null;
        }
        LoginInformation createLoginInformation(string email, string password, string name, string lastname)
        {
            try
            {
                LoginInformation log = new LoginInformation();
                log.Email = email;
                log.Password = System.Web.Helpers.Crypto.HashPassword(password);
                log.CreatedAt = DateTime.Now;
                log.LastModificationBy = name + " " + lastname;

                using (var db = new Context())
                {
                    db.LoginInformations.Add(log);
                    db.SaveChanges();
                }

                return log;
            }
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE EMAIL DUPLICADO
                    return null;
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return null;
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

                using (var db = new Context())
                {
                    db.LoginInformations.Add(log);
                    db.SaveChanges();
                }

                return log;
            }
            catch (SqlException exception)
            {
                if (exception.Number == 2601)
                {
                    // MANEJAR ERROR DE EMAIL DUPLICADO
                    return null;
                }
                else
                    throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return null;
        }

        #endregion

        #region Alumnos

        bool createStudent(int Dni, string mail, string password, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone, string socialWork, string workActivity, string workingHours,LoginInformation log, User user) {
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
                student.SocialWork = socialWork;
                student.WorkActivity = workActivity;
                student.WorkingHours = workingHours;
                student.CreatedAt = DateTime.Now;
                student.LastModificationBy = name + " " + lastname;
                using (var db = new Context())
                {
                    db.Students.Add(student);
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
        bool createStudent(int Dni, string mail, string name, string lastname, LoginInformation log, User user)
        {
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
            catch (SqlException exception)
            {
                throw; // MANEAJAR EXCEPEPTION INDEFINIDA
            }
            return false;

        }
        public bool enrolStudent(int Dni, string mail, string password, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone, string socialWork, string workActivity, string workingHours)
        {
            User user = createUser(Dni, name, lastname, dateOfBirth, placeOfBirth, gender, phone, emergencyphone);
            if (user != null) 
            {
                LoginInformation log = createLoginInformation(mail, password, name, lastname);
                if (log != null)
                {
                    return (createStudent(Dni, mail, password, name, lastname, dateOfBirth, placeOfBirth,
                            gender, phone, emergencyphone, socialWork, workActivity, workingHours, log, user));
                }
            }


            //borrar todo
            return false;
        }
        public bool enrolStudent(int Dni, string mail, string name, string lastname,DateTime? dateOfBirth, string phone)
        {
            User user = createUser(Dni, name, lastname,dateOfBirth,phone);
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
        public bool enrolStudent(int Dni, string mail, string name, string lastname)
        {
                User user = createUser(Dni, name, lastname);
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
                    var student = db.Students.Where(x => x.User.Dni == dni).Include(x => x.User).Include(x => x.LoginInformation).First();
                    return student;
                } catch { }return null;
                
            }
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
                    var teacher = db.Teachers.Where(x => x.User.Dni == dni).Include(x => x.User).Include(x => x.LoginInformation).First();
                    return teacher;
                }
                catch (SqlException exception) { throw exception; }

            }
        }

        bool createTeacher(int Dni, string mail, string password, string name, string lastname, DateTime? dateOfBirth, string? placeOfBirth,
                                string? gender, string? phone, string? emergencyphone, string cuil, string? title, LoginInformation log, User user)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.UserId = user.Id;
                teacher.LoginInformationId = log.Id;
                teacher.Cuil = cuil;
                teacher.Titulo = title;
                teacher.CreatedAt = DateTime.Now;
                teacher.LastModificationBy = name + " " + lastname;
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

        bool createTeacher(int Dni, string mail, string name, string lastname, string cuil, string? title, LoginInformation log, User user)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.UserId = user.Id;
                teacher.LoginInformationId = log.Id;
                teacher.Cuil = cuil;
                teacher.Titulo = title;
                teacher.CreatedAt = DateTime.Now;
                teacher.LastModificationBy = name + " " + lastname;
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

        public void updateTeacher(int dni, string email, string name, string lastname)
        {
            using (var db = new Context())
            {
                var result = findTeacher(dni);
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

        public bool inputTeacher(int Dni, string mail, string password, string name, string lastname, DateTime? dateOfBirth, string placeOfBirth,
                        string gender, string phone, string emergencyphone, string cuil, string title)
        {
            User user = createUser(Dni, name, lastname, dateOfBirth, placeOfBirth, gender, phone, emergencyphone);
            if (user != null)
            {
                LoginInformation log = createLoginInformation(mail, password, name, lastname);
                if (log != null)
                {
                    return (createTeacher(Dni, mail, password, name, lastname, dateOfBirth, placeOfBirth,
                            gender, phone, emergencyphone, cuil, title, log, user));
                }
            }
            return false;
        }

        public bool inputTeacher(int Dni, string mail, string name, string lastname, DateTime? dateOfBirth, string? placeBirth, 
            string? phone, string? emergencyphone, string? gender, string cuil, string title)
        {
            User user = createUser(Dni, name, lastname, dateOfBirth, placeBirth, phone, emergencyphone, gender);
            if (user != null)
            {
                LoginInformation log = createLoginInformation(mail, Dni);
                if (log != null)
                {
                    return (createTeacher(Dni, mail, name, lastname, cuil, title, log, user));
                }
            }
            return false;
        }

        public Teacher getTeacher(object teacher) //deprecated
        {
            return (Teacher)teacher;
        }

        public List<Teacher> searchBoxTeacherWithString(string search)
        {
            using (var db = new Context())
            {
                var list = db.Teachers.Where(x => x.User.Name.StartsWith(search)).Include(x => x.LoginInformation).Include(x => x.User).ToList();
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
                var list = db.TeacherSubjects.Where(x => x.Subject.CareerId == _career.Id).Select(x => x.Teacher).ToList();
                return list;
            }
        }

        #endregion
    }
}
