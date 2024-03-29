﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("Teacher")]
    public partial class Teacher
    {
        public Teacher()
        {
            ExamTitularNavigations = new HashSet<Exam>();
            ExamFirstVowelNavigations = new HashSet<Exam>();
            ExamSecondVowelNavigations = new HashSet<Exam>();
            ExamThirdVowelNavigations = new HashSet<Exam>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Cuil { get; set; }
        public int UserId { get; set; }
        public string? Titulo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;
        public int LoginInformationId { get; set; }

        [ForeignKey("LoginInformationId")]
        [InverseProperty("Teachers")]
        public virtual LoginInformation LoginInformation { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Teachers")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("TitularNavigation")]
        public virtual ICollection<Exam> ExamTitularNavigations { get; set; }
        [InverseProperty("FirstVowelNavigation")]
        public virtual ICollection<Exam> ExamFirstVowelNavigations { get; set; }
        [InverseProperty("SecondVowelNavigation")]
        public virtual ICollection<Exam> ExamSecondVowelNavigations { get; set; }
        [InverseProperty("ThirdVowelNavigation")]
        public virtual ICollection<Exam> ExamThirdVowelNavigations { get; set; }
        [InverseProperty("Teacher")]
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }

        public override string ToString()
        {
            return this.User.LastName + " " + this.User.Name;
        }

    }
}
