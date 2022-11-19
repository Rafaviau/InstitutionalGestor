using GestIn.Reports.ActaVolante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn
{
    public partial class pdfTest : Form
    {
        generatorActaVolante gActaVolante = new generatorActaVolante();
        public pdfTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gActaVolante.generateActaVolante("123", "Carrera de prueba", "MAteria de prueba", "Docente titular", "VOCALES", "2°año", DateTime.Now.ToString("dd/MM/yyy"), "Aula 3"); ;
        }
    }
}
