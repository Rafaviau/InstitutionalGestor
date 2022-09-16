using System.ComponentModel.DataAnnotations;
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
        [StringLength(200)]
        public string Name { get; set; } = null!;
        public int YearInCareer { get; set; }
        public int AnnualHourlyLoad { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy = null!;



        public List<Subject> ListCorrelatives = new List<Subject>();
        public List<Teacher> ListTeachers;
        Dictionary<string, TimeSpan>? Cronogram = new();

        Dictionary<int, bool> DictEstado = new();
        //public List<Dictionary<int, bool>> ListCorrelatives = new List<Dictionary<int, bool>> ();

        public Subject(int id)
        {
            ID = id;
        }

        public Subject(int careerId, string name, int yearInCareer, int annualHourlyLoad) //CREATE
        {
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
        }

        public Subject(int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Subject> listcorrelatives) //CREATE
        {
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
            CORRELATIVES = listcorrelatives;
        }

        public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad) //Database
        {
            ID = id;
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
        }

        public Subject(int id, int careerId, List<Subject> listCorrelatives, List<Teacher> listTeachers, Dictionary<string, TimeSpan>? cronogram) //Databases
        {
            ID = id;
            CAREERID = careerId;
            CORRELATIVES = listCorrelatives;
            TEACHERS = listTeachers;
            CRONOGRAM = cronogram;
        }

        public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Subject> listCorrelatives)
        {
            ID = id;
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
            CORRELATIVES = listCorrelatives;
        }

        public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Subject> listCorrelatives, List<Teacher> listTeachers)
        {
            ID = id;
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
            CORRELATIVES = listCorrelatives;
            TEACHERS = listTeachers;
        }

        public Subject(int id, int careerId, string name, int yearInCareer, int annualHourlyLoad, List<Subject> listCorrelatives, List<Teacher> listTeachers, Dictionary<string, TimeSpan>? cronogram)
        {
            ID = id;
            CAREERID = careerId;
            NAME = name;
            YEARINCAREER = yearInCareer;
            ANNUALHOURLYLOAD = annualHourlyLoad;
            CORRELATIVES = listCorrelatives;
            TEACHERS = listTeachers;
            CRONOGRAM = cronogram;
        }

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
        public List<Subject> CORRELATIVES
        {
            set { ListCorrelatives = value; }
            get { return ListCorrelatives; }
        }
        public List<Teacher> TEACHERS
        {
            set { ListTeachers = value; }
            get { return ListTeachers; }
        }
        public Dictionary<string, TimeSpan> CRONOGRAM
        {
            set { Cronogram = value; }
            get { return Cronogram; }
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

        public override string ToString()
        {
            return NAME;
            //return "MATERIA {" + "_ID=" + ID + ", Nombre=" + NOMBRE + ", Correlativas" + CORRELATIVAS + ", Docente=" + DOCENTES + ", ANIOENCARRERA=" + ANIOENCARRERA + ", Correlativas" + CORRELATIVAS + ", CARGAHORARIASEMANAL=" + CARGAHORARIASEMANAL + ", CARGAHORARIATOTAL=" + CARGAHORARIATOTAL + '}';
        }

        /*
        public override string ToString()
        {
            return (ID + " " + NOMBRE);
        }
        */

        public string CronogramTOSTRING()
        {
            return string.Join("CRONOGRAMA", CRONOGRAM.Select(x => x.Key + " " + x.Value).ToArray());
        }

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
    }
}
