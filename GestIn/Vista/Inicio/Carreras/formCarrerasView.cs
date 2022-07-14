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
using GestIn.Modelo.Clases;

namespace GestIn.Vista.Inicio.Carreras
{
    public partial class formCarrerasView : formHeredable
    {
        BindingSource bs = new BindingSource();
        List<Carrera> carreras = new List<Carrera>();
        public formCarrerasView()
        {
            InitializeComponent();
            carreras.Add(new Carrera(1));
            carreras.Add(new Carrera(2));
            carreras.Add(new Carrera(3));
            carreras.Add(new Carrera(4));
            carreras.Add(new Carrera(5));

            bs.DataSource = carreras;
            dataGridCarreras.DataSource = bs;

        }
    }
}
