using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("Career")]
    [Index("Resolution", Name = "IX_Career", IsUnique = true)]
    public partial class Career
    {
        public Career()
        {
            CareerEnrolments = new HashSet<CareerEnrolment>();
            Subjects = new HashSet<Subject>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(520)]
        public string Resolution { get; set; } = null!;
        [StringLength(200)]
        public string Name { get; set; } = null!;
        [StringLength(200)]
        public string Degree { get; set; } = null!;
        [StringLength(50)]
        public string? Turn { get; set; }
        //public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;

        [InverseProperty("Career")]
        public virtual ICollection<CareerEnrolment> CareerEnrolments { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<Subject> Subjects { get; set; }

        public int CalcularHorasSemanales(int horasTotales)
        {
            return horasTotales / 32;
        }

        public string TOSTRING()
        {
            return this.Id.ToString() + " "
                + this.Resolution.ToString() + " "
                + this.Name.ToString() + " "
                + this.Degree.ToString() + " "
                + this.Turn.ToString();
        }
        public override string ToString()
        {
            return this.Name;
        }

    }
}
