using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("ALUMNOS")]
    public partial class Alumno
    {
        public Alumno()
        {
            Cursada = new HashSet<Cursada>();
            Inscripcionescarreras = new HashSet<Inscripcionescarrera>();
        }

        [Key]
        public int Id { get; set; }
        public bool FotocopiaDni { get; set; }
        public bool FotocopiaTitSecundario { get; set; }
        public bool Fotos4x4 { get; set; }
        public bool CertificadoMedico { get; set; }
        public bool CertificadoDeNacimiento { get; set; }
        [Column("ConstCUIL")]
        public bool ConstCuil { get; set; }
        public bool Cooperadora { get; set; }
        [StringLength(50)]
        public string? ObraSocial { get; set; }
        [StringLength(50)]
        public string? ActividadLaboral { get; set; }
        [StringLength(50)]
        public string? HorarioLaboral { get; set; }
        public int Dni { get; set; }
        public int Usuario { get; set; }

        [ForeignKey("Usuario")]
        [InverseProperty("Alumnos")]
        public virtual Usuario UsuarioNavigation { get; set; } = null!;
        [InverseProperty("IdUsuarioNavigation")]
        public virtual ICollection<Cursada> Cursada { get; set; }
        [InverseProperty("IdAlumnoNavigation")]
        public virtual ICollection<Inscripcionescarrera> Inscripcionescarreras { get; set; }
    }
}
