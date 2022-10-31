﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    
    [Table("ExamEnrolment")]
    [Index("Id", Name = "IX_EXAMENESENROLMENT", IsUnique = true)]
    public partial class ExamEnrolment
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; } = null!;
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; } = null!;
    }
}
