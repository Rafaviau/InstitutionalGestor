using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("CURSADAS")]
    public partial class Cursada
    {
        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int Materia { get; set; }
        public int Anio { get; set; }
        public bool Aprobada { get; set; }

        [ForeignKey("IdUsuario")]
        [InverseProperty("Cursada")]
        public virtual Alumno IdUsuarioNavigation { get; set; } = null!;
        [ForeignKey("Materia")]
        [InverseProperty("Cursada")]
        public virtual Materia MateriaNavigation { get; set; } = null!;
    }
}
