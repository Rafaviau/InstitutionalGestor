using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Vista.Inicio;

//
using GestIn.Model;

namespace GestIn.Vista.Inicio.Carreras
{
    public partial class formCarrerasView : Form
    {
        BindingSource bs = new BindingSource();
        List<Carrera> carreras = new List<Carrera>();
        public formCarrerasView()
        {
            InitializeComponent();

            bs.DataSource = carreras;
            dataGridCarreras.DataSource = bs;

        }
    }
}
