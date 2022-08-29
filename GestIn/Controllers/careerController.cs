using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Controllers
{
    internal class careerController
    {
        static careerController? Instance;

        private careerController()
        {
        }
        public static careerController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new careerController();
            }
            return Instance;
        }

        #region career
        public List<Career> loadCareers() {
            using (var db = new Context())
            {
                return db.Careers.ToList();
            }
        }
        public Career createCareer(string resolution, string name, string degree) {
                    try
                    {
                        Career career = new Career();
                        career.Resolution = resolution;
                        career.Name = name;
                        career.Degree = degree;
                        career.CreatedAt = DateTime.Now;
                        career.LastModificationBy = "Preceptor cargando materias";
                        using (var db = new Context())
                        {
                            db.Careers.Add(career);
                            db.SaveChanges();
                        }

                        return career;
                    }
                    catch (SqlException exception)
                    {
                        if (exception.Number == 2601)
                        {
                            // MANEJAR ERROR DE DNI DUPLICADO
                            return null;
                        }
                        else
                            throw; // MANEAJAR EXCEPEPTION INDEFINIDA
                    }
                    return null;
                }

        public Career findCareer(string reso) {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Resolution == reso).First();
                    return career;
                }
                catch { }
                return null;
            }
        }
        public Career findCareer(int id)
        {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.Id == id).First();
                    return career;
                }
                catch { }
                return null;
            }
        }
        public Dictionary<string, string> loadCareerInformation(string reso) {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                Career career = findCareer(reso);
                if (career != null)
                {
                    data.Add("id", career.Id.ToString());
                    data.Add("name", career.Name);
                    data.Add("degree",career.Degree );
                    return data;
                }
                return null;
            }
            catch { }
            return null;
        }
        internal bool updateCareer(int id, string reso ,string name, string degree)
        {
            try { 
                using (var db = new Context())
                {
                    var result = findCareer(id);
                    if (result != null)
                    {
                        result.Resolution = reso;
                        result.Name = name;
                        result.Degree = degree;
                        result.LastModificationBy = "Preceptor cargando notas";
                        result.UpdatedAt = DateTime.Now;
                        db.Update(result);
                        db.SaveChanges();
                        return true;
                    }
                }
            } catch { }
            return false;
        }

        #endregion
        #region subject
        public IEnumerable<Subject> loadSubject(object career)
        {
            Career car = (Career)career;
            using (var db = new Context())
            {
                return db.Subjects.Where(x => x.CareerId == car.Id).ToList();
            }
        }
        public Subject createSubject(string name,int yearincareer,int hourlyLoad,object career) {
                    try
                    {
                        Career car = (Career)career;
                        Subject subject = new Subject();
                        subject.CareerId = car.Id;
                        subject.Name = name;
                        subject.YearInCareer = yearincareer;
                        subject.AnnualHourlyLoad = hourlyLoad;
                        subject.CreatedAt = DateTime.Now;
                        subject.LastModificationBy = "Preceptor cargando materias";
                        using (var db = new Context())
                        {
                            db.Subjects.Add(subject);
                            db.SaveChanges();
                        }

                        return subject;
                    }
                    catch (SqlException exception)
                    {
                        if (exception.Number == 2601)
                        {
                            // MANEJAR ERROR DE DNI DUPLICADO
                            return null;
                        }
                        else
                            throw; // MANEAJAR EXCEPEPTION INDEFINIDA
                    }
                    return null;
                }


        #endregion





    }
}
