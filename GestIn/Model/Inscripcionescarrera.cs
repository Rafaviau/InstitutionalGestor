using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("INSCRIPCIONESCARRERA")]
    public partial class Inscripcionescarrera
    {
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdCarrera { get; set; }
        public int AnioDeInscripcion { get; set; }

        [ForeignKey("IdAlumno")]
        [InverseProperty("Inscripcionescarreras")]
        public virtual Alumno IdAlumnoNavigation { get; set; } = null!;
        [ForeignKey("IdCarrera")]
        [InverseProperty("Inscripcionescarreras")]
        public virtual Carrera IdCarreraNavigation { get; set; } = null!;
    }
}
