﻿using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}