﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestIn.Model
{
    [Table("Subject")]
    public partial class Subject
    {
        public Subject()
        {
            CorrelativeCorrelativeSubjects = new HashSet<Correlative>();
            CorrelativeSubjects = new HashSet<Correlative>();
            Grades = new HashSet<Grade>();
            Schedules = new HashSet<Schedule>();
            SubjectEnrolments = new HashSet<SubjectEnrolment>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        [Key]
        public int Id { get; set; }
        public int CareerId { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public int YearInCareer { get; set; }
        public int AnnualHourlyLoad { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;


        [ForeignKey("CareerId")]
        [InverseProperty("Subjects")]
        public virtual Career Career { get; set; } = null!;
        [InverseProperty("CorrelativeSubject")]
        public virtual ICollection<Correlative> CorrelativeCorrelativeSubjects { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Correlative> CorrelativeSubjects { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<SubjectEnrolment> SubjectEnrolments { get; set; }
        [InverseProperty("Subject")]
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }



        public Subject(int id)
        {
           Id = id;
        }

        public Subject(int careerId, string name, int yearInCareer, int annualHourlyLoad) //CREATE
        {
            CareerId = careerId;
            Name = name;
            YearInCareer = yearInCareer;
            AnnualHourlyLoad = annualHourlyLoad;
        }

        public string TOSTRING()
        {
            return this.Id.ToString() + " "
                + this.CareerId.ToString() + " "
                + this.Name.ToString() + " "
                + this.YearInCareer.ToString() + " "
                + this.AnnualHourlyLoad.ToString();
        }

        /*
        public int ID
        {
            set { Id = value; }
            get { return Id; }
        }
        public int CAREERID
        {
            set { CareerId = value; }
            get { return CareerId; }
        }
        public string NAME
        {
            set { Name = value; }
            get { return Name; }
        }

        public int YEARINCAREER
        {
            set { YearInCareer = value; }
            get { return YearInCareer; }
        }

        public int ANNUALHOURLYLOAD
        {
            set { AnnualHourlyLoad = value; }
            get { return AnnualHourlyLoad; }
        }

        public DateTime CREATEDAT
        {
            set { CreatedAt = value; }
            get { return CreatedAt; }
        }

        public DateTime? UPDATEDAT
        {
            set { UpdatedAt = value; }
            get { return UpdatedAt; }
        }

        public DateTime? DELETEDAT
        {
            set { DeletedAt = value; }
            get { return DeletedAt; }
        }

        public string LASTMODIFICATIONBY
        {
            set { LastModificationBy = value; }
            get { return LastModificationBy; }
        }

        

       public List<Correlative> ListCorrelatives = new List<Correlative>();
       public List<Teacher> ListTeachers = new List<Teacher>();
       public List<Schedule> ListSchedule = new List<Schedule>();

        public List<Correlative> CORRELATIVES
        {
            set { ListCorrelatives = value; }
            get { return ListCorrelatives; }
        }
        public List<Teacher> TEACHERS
        {
            set { ListTeachers = value; }
            get { return ListTeachers; }
        }
        
        public List<Schedule> SCHEDULES
        {
            set { ListSchedule = value; }
            get { return ListSchedule; }
        }

        public override string ToString()
        {
            return (ID + " " + NOMBRE);
        }

       public Subject(int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Correlative> listcorrelatives) //CREATE
       {
           CAREERID = careerId;
           NAME = name;
           YEARINCAREER = yearInCareer;
           ANNUALHOURLYLOAD = annualHourlyLoad;
           CORRELATIVES = listcorrelatives;
       }

       public Subject(int id, int careerId, List<Correlative> listCorrelatives, List<Teacher> listTeachers, List<Schedule> cronogram) //Databases
       {
           ID = id;
           CAREERID = careerId;
           CORRELATIVES = listCorrelatives;
           TEACHERS = listTeachers;
           SCHEDULES = cronogram;
       }

       public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Correlative> listCorrelatives)
       {
           ID = id;
           CAREERID = careerId;
           NAME = name;
           YEARINCAREER = yearInCareer;
           ANNUALHOURLYLOAD = annualHourlyLoad;
           CORRELATIVES = listCorrelatives;
       }


       public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Correlative> listCorrelatives, List<Teacher> listTeachers)
       {
           ID = id;
           CAREERID = careerId;
           NAME = name;
           YEARINCAREER = yearInCareer;
           ANNUALHOURLYLOAD = annualHourlyLoad;
           CORRELATIVES = listCorrelatives;
           TEACHERS = listTeachers;
       }

       public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Correlative> listCorrelatives, List<Teacher> listTeachers, List<Schedule> cronogram)
       {
           ID = id;
           CAREERID = careerId;
           NAME = name;
           YEARINCAREER = yearInCareer;
           ANNUALHOURLYLOAD = annualHourlyLoad;
           CORRELATIVES = listCorrelatives;
           TEACHERS = listTeachers;
           SCHEDULES = cronogram;
       }
       */

    }
}
