using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestIn.Model;

namespace GestIn.Controllers
{
    internal class userController
    {
        List<Student> ListAlumnos;
        static userController? Instance;

        private userController()
        {
            ListAlumnos = new List<Student>();
        }
        public static userController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new userController();
            }
            return Instance;
        }


        #region Alumnos
        int createUser(int Dni, string mail, string password, string name, string lastname, DateTime dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone)
        {
            try {
                User user = new User();
                user.Dni = Dni;
                user.Email = mail;
                user.Password = password;
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

                return user.Id;
            }
            catch {}
            return -1;
        }

        public Student createStudent(int Dni, string mail, string password, string name, string lastname, DateTime dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone, string socialWork, string workActivity, string workingHours)
        {
            try
            {
                int id = createUser(Dni, mail, password, name, lastname, dateOfBirth, placeOfBirth,
                                gender, phone, emergencyphone);
                Student student = new Student();
                student.UserId = id;
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

                return student;
            }
            catch { }
            return null;
        }
        #endregion
    }
}
