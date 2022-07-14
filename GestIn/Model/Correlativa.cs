using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("CORRELATIVAS")]
    public partial class Correlativa
    {
        [Key]
        public int Id { get; set; }
        public int IdMateria { get; set; }
        public int IdMateriaCorrelativa { get; set; }
        public bool CorrelativasFinal { get; set; }

        [ForeignKey("IdMateriaCorrelativa")]
        [InverseProperty("CorrelativaIdMateriaCorrelativaNavigations")]
        public virtual Materia IdMateriaCorrelativaNavigation { get; set; } = null!;
        [ForeignKey("IdMateria")]
        [InverseProperty("CorrelativaIdMateriaNavigations")]
        public virtual Materia IdMateriaNavigation { get; set; } = null!;
    }
}
