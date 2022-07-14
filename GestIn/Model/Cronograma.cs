using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("CRONOGRAMAS")]
    public partial class Cronograma
    {
        [Key]
        public int Id { get; set; }
        public int Materia { get; set; }
        [StringLength(50)]
        public string Dia { get; set; } = null!;
        public TimeSpan HoraDeInicio { get; set; }

        [ForeignKey("Materia")]
        [InverseProperty("Cronogramas")]
        public virtual Materia MateriaNavigation { get; set; } = null!;
    }
}
