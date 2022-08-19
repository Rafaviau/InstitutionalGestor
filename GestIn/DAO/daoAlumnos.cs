using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Model;
using GestIn.Conexiones.Database;
using System.Data.SqlClient;
using System.Data;

namespace GestIn.DAO
{
    class daoAlumnos : ConexionDb, Idao<Alumno>
    {
        public bool create(Alumno c)
        {
            throw new NotImplementedException();
        }

        public bool delete(object key)
        {
            throw new NotImplementedException();
        }

        public Alumno read(object key)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> readALL()
        {
            throw new NotImplementedException();
        }

        public bool update(Alumno c)
        {
            throw new NotImplementedException();
        }

        internal bool changePassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        internal bool createAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        internal bool ReadUsuario(int dni)
        {
            throw new NotImplementedException();
        }
    }
}
