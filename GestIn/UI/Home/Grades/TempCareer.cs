using GestIn.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Grades
{
    public partial class TempCareer : Form
    {
        careerController careerController = careerController.GetInstance();
        public TempCareer()
        {
            InitializeComponent();
            foreach (object career in careerController.loadCareers())
            {
                cbCareer.Items.Add(career);
            }
        }

        private void btnCareerCreate_Click(object sender, EventArgs e)
        {
            try {
                object career = careerController.createCareer(txtCareerRes.Text, txtCareerName.Text, txtCareerDegree.Text);
                cbCareer.Items.Add(career);
                MessageBox.Show("AGregado correctamente");
            } catch {
                MessageBox.Show("No se pudo guardar");
            };
            
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            try {
                careerController.createSubject(txtSubjectName.Text,
                Int32.Parse(txtYearinCareer.Text), 
                Int32.Parse(txtHours.Text), 
                cbCareer.SelectedItem);
                MessageBox.Show("Guardado correctamente");
            } catch {
                MessageBox.Show("No se pudo guardar");
            };
            
        }
    }
}
