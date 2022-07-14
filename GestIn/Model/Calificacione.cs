using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    public partial class Calificacione
    {
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdMateria { get; set; }
        public int Nota { get; set; }

        [ForeignKey("IdAlumno")]
        [InverseProperty("Calificaciones")]
        public virtual Alumno IdAlumnoNavigation { get; set; } = null!;
        [ForeignKey("IdMateria")]
        [InverseProperty("Calificaciones")]
        public virtual Materia IdMateriaNavigation { get; set; } = null!;
    }
}
