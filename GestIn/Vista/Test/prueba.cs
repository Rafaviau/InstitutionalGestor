using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Modelo.DAO;

namespace GestIn.Vista.Test
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daoAlumnos dao = new daoAlumnos();

            dao.ReadUsuario(123432);
        }

        private void prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
