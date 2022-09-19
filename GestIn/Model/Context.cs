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

        public virtual DbSet<Career> Careers { get; set; } = null!;
        public virtual DbSet<CareerEnrolment> CareerEnrolments { get; set; } = null!;
        public virtual DbSet<Correlative> Correlatives { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<ExamEnrolment> ExamEnrolments { get; set; } = null!;
        public virtual DbSet<ExamEnrolmentConfig> ExamEnrolmentConfigs { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<LoginInformation> LoginInformations { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<SubjectEnrolment> SubjectEnrolments { get; set; } = null!;
        public virtual DbSet<SubjectEnrolmentConfig> SubjectEnrolmentConfigs { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=tcp:servidor-itec.database.windows.net,1433;Initial Catalog=gestin;Persist Security Info=False;User ID=gestin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                optionsBuilder.UseSqlServer("Server=LAPTOP-E6PCVT2U\\SQLEXPRESS;Database=DbGestin;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Server=LAPTOP-MRUPP9SV\\SQLEXPRESS;Database=DbGestin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CareerEnrolment>(entity =>
            {
                entity.HasOne(d => d.Career)
                    .WithMany(p => p.CareerEnrolments)
                    .HasForeignKey(d => d.CareerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESCARRERA_CARRERAS");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CareerEnrolments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESCARRERA_ESTUDIANTES");
            });

            modelBuilder.Entity<Correlative>(entity =>
            {
                entity.HasOne(d => d.CorrelativeSubject)
                    .WithMany(p => p.CorrelativeCorrelativeSubjects)
                    .HasForeignKey(d => d.CorrelativeSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CORRELATIVAS_MATERIAS1");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CorrelativeSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CORRELATIVAS_MATERIAS");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasOne(d => d.ExtraordinaryTenuredNavigation)
                    .WithMany(p => p.ExamExtraordinaryTenuredNavigations)
                    .HasForeignKey(d => d.ExtraordinaryTenured)
                    .HasConstraintName("FK_EXAMENES_DOCENTES3");

                entity.HasOne(d => d.FirstVowelNavigation)
                    .WithMany(p => p.ExamFirstVowelNavigations)
                    .HasForeignKey(d => d.FirstVowel)
                    .HasConstraintName("FK_EXAMENES_DOCENTES");

                entity.HasOne(d => d.SecondVowelNavigation)
                    .WithMany(p => p.ExamSecondVowelNavigations)
                    .HasForeignKey(d => d.SecondVowel)
                    .HasConstraintName("FK_EXAMENES_DOCENTES1");

                entity.HasOne(d => d.ThirdVowelNavigation)
                    .WithMany(p => p.ExamThirdVowelNavigations)
                    .HasForeignKey(d => d.ThirdVowel)
                    .HasConstraintName("FK_EXAMENES_DOCENTES2");
            });

            modelBuilder.Entity<ExamEnrolment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Exam)
                    .WithMany()
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESEXAMENES_EXAMENES");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INSCRIPCIONESEXAMENES_ESTUDIANTES");
            });

            modelBuilder.Entity<ExamEnrolmentConfig>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Calificaciones_ALUMNOS");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Calificaciones_MATERIAS");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRONOGRAMAS_MATERIAS");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasOne(d => d.LoginInformation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.LoginInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_LoginInformation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUMNOS_USUARIOS");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasOne(d => d.Career)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.CareerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MATERIAS_CARRERAS");
            });

            modelBuilder.Entity<SubjectEnrolment>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SubjectEnrolments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectEnrolment_Student");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectEnrolments)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURSADAS_MATERIAS");
            });

            modelBuilder.Entity<SubjectEnrolmentConfig>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasOne(d => d.LoginInformation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.LoginInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teacher_LoginInformation1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTES_USUARIOS");
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTESMATERIA_MATERIAS");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TeacherSubject_Teacher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
