using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.Modelo.DAO
{
    internal interface Idao <objeto>
    {
        public Boolean create(objeto c);
        public Boolean delete(Object key);
        public Boolean update(objeto c);

        public objeto read(Object key);
        public List<objeto> readALL();
    }
}