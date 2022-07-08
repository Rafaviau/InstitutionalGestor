using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestIn.Model
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Carrera> Carreras { get; set; } = null!;
        public virtual DbSet<Correlativa> Correlativas { get; set; } = null!;
        public virtual DbSet<Cronograma> Cronogramas { get; set; } = null!;
        public virtual DbSet<Cursada> Cursadas { get; set; } = null!;
        public virtual DbSet<Docente> Docentes { get; set; } = null!;
        public virtual DbSet<Docentesmaterium> Docentesmateria { get; set; } = null!;
        public virtual DbSet<Examene> Examenes { get; set; } = null!;
        public virtual DbSet<Inscripcionescarrera> Inscripcionescarreras { get; set; } = null!;
        public virtual DbSet<Inscripcionesexamene> Inscripcionesexamenes { get; set; } = null!;
        public virtual DbSet<Materia> Materias { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-E6PCVT2U\\SQLEXPRESS;Database=DbGestin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUMNOS_USUARIOS");
            });

            modelBuilder.Entity<Correlativa>(entity =>
            {
                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.CorrelativaIdMateriaNavigations)
                    .HasForeignKey(d => d.IdMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CORRELATIVAS_MATERIAS");

                entity.HasOne(d => d.IdMateriaCorrelativaNavigation)
                    .WithMany(p => p.CorrelativaIdMateriaCorrelativaNavigations)
                    .HasForeignKey(d => d.IdMateriaCorrelativa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CORRELATIVAS_MATERIAS1");
            });

            modelBuilder.Entity<Cronograma>(entity =>
            {
                entity.HasOne(d => d.MateriaNavigation)
                    .WithMany(p => p.Cronogramas)
                    .HasForeignKey(d => d.Materia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRONOGRAMAS_MATERIAS");
            });

            modelBuilder.Entity<Cursada>(entity =>
            {
                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cursada)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURSADAS_ESTUDIANTES");

                entity.HasOne(d => d.MateriaNavigation)
                    .WithMany(p => p.Cursada)
                    .HasForeignKey(d => d.Materia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURSADAS_MATERIAS");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTES_USUARIOS");
            });

            modelBuilder.Entity<Docentesmaterium>(entity =>
            {
                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Docentesmateria)
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTESMATERIA_DOCENTES");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Docentesmateria)
                    .HasForeignKey(d => d.IdMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTESMATERIA_MATERIAS");
            });

            modelBuilder.Entity<Examene>(entity =>
            {
                entity.HasOne(d => d.PrimerVocalNavigation)
                    .WithMany(p => p.ExamenePrimerVocalNavigations)
                    .HasForeignKey(d => d.PrimerVocal)
                    .HasConstraintName("FK_EXAMENES_DOCENTES");

                entity.HasOne(d => d.SegundoVocalNavigation)
                    .WithMany(p => p.ExameneSegundoVocalNavigations)
                    .HasForeignKey(d => d.SegundoVocal)
                    .HasConstraintName("FK_EXAMENES_DOCENTES1");

                entity.HasOne(d => d.TercerVocalNavigation)
                    .WithMany(p => p.ExameneTercerVocalNavigations)
                    .HasForeignKey(d => d.TercerVocal)
                    .HasConstraintName("FK_EXAMENES_DOCENTES2");

                entity.HasOne(d => d.TitularExtraordinarioNavigation)
                    .WithMany(p => p.ExameneTitularExtraordinarioNavigations)
                    .HasForeignKey(d => d.TitularExtraordinario)
                    .HasConstraintName("FK_EXAMENES_DOCENTES3");
            });

            modelBuilder.Entity<Inscripcionescarrera>(entity =>
            {
                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Inscripcionescarreras)
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESCARRERA_ESTUDIANTES");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Inscripcionescarreras)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESCARRERA_CARRERAS");
            });

            modelBuilder.Entity<Inscripcionesexamene>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESEXAMENES_ESTUDIANTES");

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESEXAMENES_EXAMENES");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasOne(d => d.CarreraNavigation)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.Carrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATERIAS_CARRERAS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
