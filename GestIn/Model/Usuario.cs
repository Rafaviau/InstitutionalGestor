using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("USUARIOS")]
    [Index("Email", Name = "IX_USUARIOS", IsUnique = true)]
    public partial class Usuario
    {
        public Usuario()
        {
            Alumnos = new HashSet<Alumno>();
            Docentes = new HashSet<Docente>();
        }

        [Key]
        public int Id { get; set; }
        public int Dni { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [StringLength(500)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        public string Rol { get; set; } = null!;
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        [StringLength(50)]
        public string Apellido { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime FechaDeNacimiento { get; set; }
        [StringLength(500)]
        public string LugarDeNacimiento { get; set; } = null!;
        [StringLength(50)]
        public string Celular { get; set; } = null!;
        [StringLength(50)]
        public string CelularDeEmergencia { get; set; } = null!;
        [StringLength(50)]
        public string Sexo { get; set; } = null!;

        [InverseProperty("UsuarioNavigation")]
        public virtual ICollection<Alumno> Alumnos { get; set; }
        [InverseProperty("UsuarioNavigation")]
        public virtual ICollection<Docente> Docentes { get; set; }
    }
}
