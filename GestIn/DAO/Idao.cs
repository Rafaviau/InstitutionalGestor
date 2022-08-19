using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.DAO
{
    internal interface Idao<objeto>
    {
        public bool create(objeto c);
        public bool delete(object key);
        public bool update(objeto c);

        public objeto read(object key);
        public List<objeto> readALL();
    }
}