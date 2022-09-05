using GestIn.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestIn.Controllers
{
    internal class careerController
    {
        #region Atributos
        private List<Career> ListCareers = new List<Career>();
        private static careerController? Instance;
        #endregion

        #region Singletone
        private careerController()
        {
            ListCareers = new List<Career>();

            ListCareers = loadCareers();
        }

        public static careerController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new careerController();
            }
            return Instance;
        }
        #endregion

        #region ReturnList
        public List<Career> ReturnListCareers()
        {
            return ListCareers;
        }

       #endregion

        public Career createCareer(string resolutionNum, string name, string degree, string turn)
        {
            Career nuevacarrera = new Career(resolutionNum, name, degree, turn);
            try
            {
                nuevacarrera.CREATEDAT = DateTime.Now;
                nuevacarrera.LASTMODIFICATIONBY = "Preceptor cargando materias";
                MessageBox.Show(nuevacarrera.TOSTRING());
                using (var db = new Context())
                {
                    db.Careers.Add(nuevacarrera);
                    db.SaveChanges();
                }

                ListCareers.Add(nuevacarrera); //ID NOT NECESSARY
                return nuevacarrera;
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
        }

        public bool updateCareer(int idcareer, string resolutionNum, string name, string degree, string turn)
        {
            try
            {
                using (var db = new Context())
                {
                    var updatedCareer = findCareer(idcareer);
                    if (updatedCareer != null)
                    {
                        updatedCareer.RESOLUTION = resolutionNum;
                        updatedCareer.NAME = name;
                        updatedCareer.DEGREE = degree;
                        updatedCareer.TURN = turn;
                        updatedCareer.LASTMODIFICATIONBY = "Alguien actualizo la carrera";
                        updatedCareer.UPDATEDAT = DateTime.Now;
                        db.Update(updatedCareer);
                        db.SaveChanges();
                    }
                }
            }
            catch {}
            return false;
        }

        public Career ReadCarrera(int id)
        {
            Career carrera = null;

            foreach (Career aux in ListCareers)
            {
                if (aux.ID == id)
                {
                    carrera = aux;
                }
            }
            return carrera;
        }

        public List<Career> loadCareers()
        {
            using (var db = new Context())
            {
                return db.Careers.ToList();
            }
        }

        public Dictionary<string, string> loadCareerInformation(string resolutionNum)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                Career career = findCareer(resolutionNum);
                if (career != null)
                {
                    data.Add("id", career.Id.ToString());
                    data.Add("name", career.Name);
                    data.Add("degree", career.Degree);
                    return data;
                }
                return null;
            }
            catch { }
            return null;
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

        public Career findCareer(string resolutionNum)
        {
            using (var db = new Context())
            {
                try
                {
                    var career = db.Careers.Where(x => x.RESOLUTION == resolutionNum).First();
                    return career;
                }
                catch { }
                return null;
            }
        }

        internal bool updateCareer(int id, string reso, string name, string degree) //Rafa
        {
            try
            {
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
            }
            catch { }
            return false;
        }
    }
}
