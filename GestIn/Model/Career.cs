using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Table("Career")]
    public partial class Career
    {
        public Career()
        {
            CareerEnrolments = new HashSet<CareerEnrolment>();
            Subjects = new HashSet<Subject>();
        }

        [Key]
        public int Id;
        [StringLength(50)]
        public string Resolution = null!;
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
        public List<Subject> ListSubjects = new();

        public Career(int id)
        {
            Id = id;
        }
        public Career(string resolution, string name, string degree, string? turn)
        {
            RESOLUTION = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
        }

        public Career(int id, string resolution, string name, string degree, string? turn)
        {
            ID = id;
            RESOLUTION = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
        }


        public Career(int id, string resolution, string name, string degree, string? turn, List<Subject> listSubjects)
        {
            ID = id;
            RESOLUTION = resolution;
            NAME = name;
            DEGREE = degree;
            TURN = turn;
            LIST_SUBJECTS = listSubjects;
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

        public string TURN
        {
            set { Turn = value; }
            get { return Turn; }
        }

        public List<Subject> LIST_SUBJECTS
        {
            set { ListSubjects = value; }
            get { return ListSubjects; }
        }

        public override string ToString()
        {
            return "Career{" + "_NRORESOLUCION=" + RESOLUTION + ", Nombre=" + NAME + ", Turno=" + TURN + ", ListaMaterias=" + LIST_SUBJECTS + '}';
        }

        [InverseProperty("Career")]
        public virtual ICollection<CareerEnrolment> CareerEnrolments { get; set; }
        [InverseProperty("Career")]
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
