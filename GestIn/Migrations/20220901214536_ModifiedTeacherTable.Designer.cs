﻿// <auto-generated />
using System;
using GestIn.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestIn.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220901214536_ModifiedTeacherTable")]
    partial class ModifiedTeacherTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GestIn.Model.Career", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Turn")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Resolution" }, "IX_Career")
                        .IsUnique();

                    b.ToTable("Career");
                });

            modelBuilder.Entity("GestIn.Model.CareerEnrolment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("YearOfRegistration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.HasIndex("StudentId");

                    b.ToTable("CareerEnrolment");
                });

            modelBuilder.Entity("GestIn.Model.Correlative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("CorrelativeFinal")
                        .HasColumnType("bit");

                    b.Property<int>("CorrelativeSubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CorrelativeSubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Correlative");
                });

            modelBuilder.Entity("GestIn.Model.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExtraordinaryTenured")
                        .HasColumnType("int");

                    b.Property<int?>("FirstVowel")
                        .HasColumnType("int");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SecondVowel")
                        .HasColumnType("int");

                    b.Property<int>("Subject")
                        .HasColumnType("int");

                    b.Property<int?>("ThirdVowel")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExtraordinaryTenured");

                    b.HasIndex("FirstVowel");

                    b.HasIndex("SecondVowel");

                    b.HasIndex("ThirdVowel");

                    b.HasIndex(new[] { "Id" }, "IX_EXAMENES")
                        .IsUnique();

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("GestIn.Model.ExamEnrolment", b =>
                {
                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.ToTable("ExamEnrolment");
                });

            modelBuilder.Entity("GestIn.Model.ExamEnrolmentConfig", b =>
                {
                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExamEnrolmentCloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExamEnrolmentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.ToTable("ExamEnrolmentConfig");
                });

            modelBuilder.Entity("GestIn.Model.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("AccreditationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccreditationType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BookRecord")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade1")
                        .HasColumnType("int")
                        .HasColumnName("Grade");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("GestIn.Model.LoginInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LoginInformation");
                });

            modelBuilder.Entity("GestIn.Model.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeSpan>("StartingTime")
                        .HasColumnType("time");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("GestIn.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("BirthCertificate")
                        .HasColumnType("bit");

                    b.Property<bool>("Cooperative")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CuilConstansy")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DniPhotocopy")
                        .HasColumnType("bit");

                    b.Property<bool>("HighSchoolTitPhotocopy")
                        .HasColumnType("bit");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LoginInformationId")
                        .HasColumnType("int");

                    b.Property<bool>("MedicalCertificate")
                        .HasColumnType("bit");

                    b.Property<bool>("Photo4x4")
                        .HasColumnType("bit");

                    b.Property<string>("SocialWork")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkActivity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WorkingHours")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("LoginInformationId");

                    b.HasIndex("UserId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("GestIn.Model.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnnualHourlyLoad")
                        .HasColumnType("int");

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("YearInCareer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CareerId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("GestIn.Model.SubjectEnrolment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Presential")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectEnrolment");
                });

            modelBuilder.Entity("GestIn.Model.SubjectEnrolmentConfig", b =>
                {
                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("SubjectEnrolmentCloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SubjectEnrolmentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.ToTable("SubjectEnrolmentConfig");
                });

            modelBuilder.Entity("GestIn.Model.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cuil")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LoginInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoginInformationId");

                    b.HasIndex("UserId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("GestIn.Model.TeacherSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSince")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUntil")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherSubject");
                });

            modelBuilder.Entity("GestIn.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("EmergencyPhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModificationBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumbre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaceOfBirth")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Dni" }, "IX_User")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("GestIn.Model.CareerEnrolment", b =>
                {
                    b.HasOne("GestIn.Model.Career", "Career")
                        .WithMany("CareerEnrolments")
                        .HasForeignKey("CareerId")
                        .IsRequired()
                        .HasConstraintName("FK_INSCRIPCIONESCARRERA_CARRERAS");

                    b.HasOne("GestIn.Model.Student", "Student")
                        .WithMany("CareerEnrolments")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_INSCRIPCIONESCARRERA_ESTUDIANTES");

                    b.Navigation("Career");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GestIn.Model.Correlative", b =>
                {
                    b.HasOne("GestIn.Model.Subject", "CorrelativeSubject")
                        .WithMany("CorrelativeCorrelativeSubjects")
                        .HasForeignKey("CorrelativeSubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_CORRELATIVAS_MATERIAS1");

                    b.HasOne("GestIn.Model.Subject", "Subject")
                        .WithMany("CorrelativeSubjects")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_CORRELATIVAS_MATERIAS");

                    b.Navigation("CorrelativeSubject");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GestIn.Model.Exam", b =>
                {
                    b.HasOne("GestIn.Model.Teacher", "ExtraordinaryTenuredNavigation")
                        .WithMany("ExamExtraordinaryTenuredNavigations")
                        .HasForeignKey("ExtraordinaryTenured")
                        .HasConstraintName("FK_EXAMENES_DOCENTES3");

                    b.HasOne("GestIn.Model.Teacher", "FirstVowelNavigation")
                        .WithMany("ExamFirstVowelNavigations")
                        .HasForeignKey("FirstVowel")
                        .HasConstraintName("FK_EXAMENES_DOCENTES");

                    b.HasOne("GestIn.Model.Teacher", "SecondVowelNavigation")
                        .WithMany("ExamSecondVowelNavigations")
                        .HasForeignKey("SecondVowel")
                        .HasConstraintName("FK_EXAMENES_DOCENTES1");

                    b.HasOne("GestIn.Model.Teacher", "ThirdVowelNavigation")
                        .WithMany("ExamThirdVowelNavigations")
                        .HasForeignKey("ThirdVowel")
                        .HasConstraintName("FK_EXAMENES_DOCENTES2");

                    b.Navigation("ExtraordinaryTenuredNavigation");

                    b.Navigation("FirstVowelNavigation");

                    b.Navigation("SecondVowelNavigation");

                    b.Navigation("ThirdVowelNavigation");
                });

            modelBuilder.Entity("GestIn.Model.ExamEnrolment", b =>
                {
                    b.HasOne("GestIn.Model.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .IsRequired()
                        .HasConstraintName("FK_INSCRIPCIONESEXAMENES_EXAMENES");

                    b.HasOne("GestIn.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_INSCRIPCIONESEXAMENES_ESTUDIANTES");

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GestIn.Model.Grade", b =>
                {
                    b.HasOne("GestIn.Model.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Calificaciones_ALUMNOS");

                    b.HasOne("GestIn.Model.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_Calificaciones_MATERIAS");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GestIn.Model.Schedule", b =>
                {
                    b.HasOne("GestIn.Model.Subject", "Subject")
                        .WithMany("Schedules")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_CRONOGRAMAS_MATERIAS");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GestIn.Model.Student", b =>
                {
                    b.HasOne("GestIn.Model.LoginInformation", "LoginInformation")
                        .WithMany("Students")
                        .HasForeignKey("LoginInformationId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_LoginInformation");

                    b.HasOne("GestIn.Model.User", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_ALUMNOS_USUARIOS");

                    b.Navigation("LoginInformation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GestIn.Model.Subject", b =>
                {
                    b.HasOne("GestIn.Model.Career", "Career")
                        .WithMany("Subjects")
                        .HasForeignKey("CareerId")
                        .IsRequired()
                        .HasConstraintName("FK_MATERIAS_CARRERAS");

                    b.Navigation("Career");
                });

            modelBuilder.Entity("GestIn.Model.SubjectEnrolment", b =>
                {
                    b.HasOne("GestIn.Model.Student", "Student")
                        .WithMany("SubjectEnrolments")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_SubjectEnrolment_Student");

                    b.HasOne("GestIn.Model.Subject", "Subject")
                        .WithMany("SubjectEnrolments")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_CURSADAS_MATERIAS");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GestIn.Model.Teacher", b =>
                {
                    b.HasOne("GestIn.Model.LoginInformation", "LoginInformation")
                        .WithMany("Teachers")
                        .HasForeignKey("LoginInformationId")
                        .IsRequired()
                        .HasConstraintName("FK_Teacher_LoginInformation1");

                    b.HasOne("GestIn.Model.User", "User")
                        .WithMany("Teachers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_DOCENTES_USUARIOS");

                    b.Navigation("LoginInformation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GestIn.Model.TeacherSubject", b =>
                {
                    b.HasOne("GestIn.Model.Subject", "Subject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("SubjectId")
                        .IsRequired()
                        .HasConstraintName("FK_DOCENTESMATERIA_MATERIAS");

                    b.HasOne("GestIn.Model.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_TeacherSubject_Teacher");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("GestIn.Model.Career", b =>
                {
                    b.Navigation("CareerEnrolments");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("GestIn.Model.LoginInformation", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("GestIn.Model.Student", b =>
                {
                    b.Navigation("CareerEnrolments");

                    b.Navigation("Grades");

                    b.Navigation("SubjectEnrolments");
                });

            modelBuilder.Entity("GestIn.Model.Subject", b =>
                {
                    b.Navigation("CorrelativeCorrelativeSubjects");

                    b.Navigation("CorrelativeSubjects");

                    b.Navigation("Grades");

                    b.Navigation("Schedules");

                    b.Navigation("SubjectEnrolments");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("GestIn.Model.Teacher", b =>
                {
                    b.Navigation("ExamExtraordinaryTenuredNavigations");

                    b.Navigation("ExamFirstVowelNavigations");

                    b.Navigation("ExamSecondVowelNavigations");

                    b.Navigation("ExamThirdVowelNavigations");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("GestIn.Model.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
