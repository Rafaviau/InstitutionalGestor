using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("DOCENTESMATERIA")]
    public partial class Docentesmaterium
    {
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdMateria { get; set; }
        public int Anio { get; set; }
        public bool EsTitular { get; set; }

        [ForeignKey("IdAlumno")]
        [InverseProperty("Docentesmateria")]
        public virtual Docente IdAlumnoNavigation { get; set; } = null!;
        [ForeignKey("IdMateria")]
        [InverseProperty("Docentesmateria")]
        public virtual Materia IdMateriaNavigation { get; set; } = null!;
    }
}
