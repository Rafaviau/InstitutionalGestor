using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("DOCENTES")]
    public partial class Docente
    {
        public Docente()
        {
            Docentesmateria = new HashSet<Docentesmaterium>();
            ExamenePrimerVocalNavigations = new HashSet<Examene>();
            ExameneSegundoVocalNavigations = new HashSet<Examene>();
            ExameneTercerVocalNavigations = new HashSet<Examene>();
            ExameneTitularExtraordinarioNavigations = new HashSet<Examene>();
        }

        [Key]
        public int Id { get; set; }
        [Column("CUIL")]
        [StringLength(50)]
        public string? Cuil { get; set; }
        public int Usuario { get; set; }

        [ForeignKey("Usuario")]
        [InverseProperty("Docentes")]
        public virtual Usuario UsuarioNavigation { get; set; } = null!;
        [InverseProperty("IdAlumnoNavigation")]
        public virtual ICollection<Docentesmaterium> Docentesmateria { get; set; }
        [InverseProperty("PrimerVocalNavigation")]
        public virtual ICollection<Examene> ExamenePrimerVocalNavigations { get; set; }
        [InverseProperty("SegundoVocalNavigation")]
        public virtual ICollection<Examene> ExameneSegundoVocalNavigations { get; set; }
        [InverseProperty("TercerVocalNavigation")]
        public virtual ICollection<Examene> ExameneTercerVocalNavigations { get; set; }
        [InverseProperty("TitularExtraordinarioNavigation")]
        public virtual ICollection<Examene> ExameneTitularExtraordinarioNavigations { get; set; }
    }
}
