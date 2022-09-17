﻿using GestIn.Model;
using System;
using System.Collections.Generic;
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
    }
}
