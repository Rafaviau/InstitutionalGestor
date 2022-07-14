using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Keyless]
    [Table("INSCRIPCIONESEXAMENES")]
    public partial class Inscripcionesexamene
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdExamen { get; set; }

        [ForeignKey("IdAlumno")]
        public virtual Alumno IdAlumnoNavigation { get; set; } = null!;
        [ForeignKey("IdExamen")]
        public virtual Examene IdExamenNavigation { get; set; } = null!;
    }
}
