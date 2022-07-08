using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("MATERIAS")]
    public partial class Materia
    {
        public Materia()
        {
            CorrelativaIdMateriaCorrelativaNavigations = new HashSet<Correlativa>();
            CorrelativaIdMateriaNavigations = new HashSet<Correlativa>();
            Cronogramas = new HashSet<Cronograma>();
            Cursada = new HashSet<Cursada>();
            Docentesmateria = new HashSet<Docentesmaterium>();
        }

        [Key]
        public int Id { get; set; }
        public int Carrera { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        public int AnioEnCarrera { get; set; }
        public int CargaHorariaSemanal { get; set; }
        public int CargaHorariaAnual { get; set; }

        [ForeignKey("Carrera")]
        [InverseProperty("Materia")]
        public virtual Carrera CarreraNavigation { get; set; } = null!;
        [InverseProperty("IdMateriaCorrelativaNavigation")]
        public virtual ICollection<Correlativa> CorrelativaIdMateriaCorrelativaNavigations { get; set; }
        [InverseProperty("IdMateriaNavigation")]
        public virtual ICollection<Correlativa> CorrelativaIdMateriaNavigations { get; set; }
        [InverseProperty("MateriaNavigation")]
        public virtual ICollection<Cronograma> Cronogramas { get; set; }
        [InverseProperty("MateriaNavigation")]
        public virtual ICollection<Cursada> Cursada { get; set; }
        [InverseProperty("IdMateriaNavigation")]
        public virtual ICollection<Docentesmaterium> Docentesmateria { get; set; }
    }
}
