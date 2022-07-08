using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("CARRERAS")]
    public partial class Carrera
    {
        public Carrera()
        {
            Inscripcionescarreras = new HashSet<Inscripcionescarrera>();
            Materia = new HashSet<Materia>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        [StringLength(50)]
        public string? NombreCorto { get; set; }
        [StringLength(50)]
        public string? Turno { get; set; }
        [Column("Carrera")]
        public int Carrera1 { get; set; }

        [InverseProperty("IdCarreraNavigation")]
        public virtual ICollection<Inscripcionescarrera> Inscripcionescarreras { get; set; }
        [InverseProperty("CarreraNavigation")]
        public virtual ICollection<Materia> Materia { get; set; }
    }
}
