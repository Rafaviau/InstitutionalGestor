using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("TeacherSubject")]
    public partial class TeacherSubject
    {
        [Key]
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int SubjectId { get; set; }
        public int Year { get; set; }
        public bool Tenured { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [ForeignKey("SubjectId")]
        [InverseProperty("TeacherSubjects")]
        public virtual Subject Subject { get; set; } = null!;
        [ForeignKey("TeacherId")]
        [InverseProperty("TeacherSubjects")]
        public virtual Teacher? Teacher { get; set; }
    }
}
