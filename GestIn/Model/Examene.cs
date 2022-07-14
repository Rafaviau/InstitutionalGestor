using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("EXAMENES")]
    [Index("Id", Name = "IX_EXAMENES", IsUnique = true)]
    public partial class Examene
    {
        [Key]
        public int Id { get; set; }
        public int Materia { get; set; }
        public int? PrimerVocal { get; set; }
        public int? SegundoVocal { get; set; }
        public int? TercerVocal { get; set; }
        public int? TitularExtraordinario { get; set; }

        [ForeignKey("PrimerVocal")]
        [InverseProperty("ExamenePrimerVocalNavigations")]
        public virtual Docente? PrimerVocalNavigation { get; set; }
        [ForeignKey("SegundoVocal")]
        [InverseProperty("ExameneSegundoVocalNavigations")]
        public virtual Docente? SegundoVocalNavigation { get; set; }
        [ForeignKey("TercerVocal")]
        [InverseProperty("ExameneTercerVocalNavigations")]
        public virtual Docente? TercerVocalNavigation { get; set; }
        [ForeignKey("TitularExtraordinario")]
        [InverseProperty("ExameneTitularExtraordinarioNavigations")]
        public virtual Docente? TitularExtraordinarioNavigation { get; set; }
    }
}
