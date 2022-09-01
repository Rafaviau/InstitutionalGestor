﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        #region Alumnos
        User createUser(int Dni, string name, string lastname, DateTime dateOfBirth, string placeOfBirth,
                                string gender, string phone, string emergencyphone)
        {
            try {
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
        LoginInformation createLoginInformation(string email, string password, string name, string lastname) {
            try
            {
                LoginInformation log = new LoginInformation();
                log.Email = email;
                log.Password = password;
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
        bool createStudent(int Dni, string mail, string password, string name, string lastname, DateTime dateOfBirth, string placeOfBirth,
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
        public bool enrolStudent(int Dni, string mail, string password, string name, string lastname, DateTime dateOfBirth, string placeOfBirth,
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
        #endregion
    }
}