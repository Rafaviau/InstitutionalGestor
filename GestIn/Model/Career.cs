using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("Career")]
    [Index("Resolution", Name = "IX_Career", IsUnique = true)]
    public partial class Career
    {
        public Career()
        {
            CareerEnrolments = new HashSet<CareerEnrolment>();
            Subjects = new HashSet<Subject>();
        }

        [Key]
        public int Id  {get; set; }
        [StringLength(50)]
        public string Resolution { get; set; } = null!;
        [StringLength(50)]
        public string Name = null!;
        [StringLength(50)]
        public string Degree= null!;
        [StringLength(50)]
        public string? Turn;
        public DateTime CreatedAt;
        public DateTime? UpdatedAt;
        public DateTime? DeletedAt;
        [StringLength(50)]
        public string LastModificationBy = null!;

        [InverseProperty("Career")]
        public virtual ICollection<CareerEnrolment> CareerEnrolments { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<Subject> Subjects { get; set; }


        public Career(int id)
        {
            Id = id;
        }
        public Career(string resolution, string name, string degree, string? turn)
        {
            Resolution = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
        }

        public Career(int id, string resolution, string name, string degree, string? turn, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt, string lastModificationBy)
        {
            ID = id;
            Resolution = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
            CREATEDAT = createdAt;
            UPDATEDAT = updatedAt;
            DELETEDAT = deletedAt;
            LASTMODIFICATIONBY = lastModificationBy;
        }

        public int ID
        {
            set { Id = value; }
            get { return Id; }
        }

        public string RESOLUTION
        {
            set { Resolution = value; }
            get { return Resolution; }
        }
        public string NAME
        {
            set { Name = value; }
            get { return Name; }
        }

        public string DEGREE
        {
            set { Degree = value; }
            get { return Degree; }
        }

        public string? TURN
        {
            set { Turn = value; }
            get { return Turn; }
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

        public int CalcularHorasSemanales(int horasTotales)
        {
            return horasTotales / 32;
        }

        public string TOSTRING()
        {
            return this.ID.ToString() + " "
                + this.RESOLUTION.ToString() + " "
                + this.NAME.ToString() + " "
                + this.DEGREE.ToString() + " "
                + this.TURN.ToString();
        }

        /*
        public List<Subject> ListSubjects = new();

        
        public List<Subject> LIST_SUBJECTS
        {
            set { ListSubjects = value; }
            get { return ListSubjects; }
        }
       

        public override string ToString()
        {
            return "Career{" + "_NRORESOLUCION=" + RESOLUTION + ", Nombre=" + NAME + ", Turno=" + TURN + ", ListaMaterias=" + LIST_SUBJECTS + '}';
        }

        public Career(string resolution, string name, string degree, string? turn, List<Subject> listSubjects)
        {
            RESOLUTION = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
            LIST_SUBJECTS = listSubjects;
        }
        */


    }
}
