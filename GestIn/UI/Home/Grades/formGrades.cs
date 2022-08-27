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
    public partial class formGrades : Form
    {
        careerController careerController = careerController.GetInstance();
        userController userController = userController.GetInstance();
        gradeContorller gradeController = gradeContorller.GetInstance();
        public formGrades()
        {
            InitializeComponent();
            foreach (object career in careerController.loadCareers()) {
                cbCareer.Items.Add(career);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int studentId = userController.findStudent(Int32.Parse(txtDni.Text)).Id;
                if (studentId != 0)
                {
                    try
                    {
                        gradeController.addGrade(
                            studentId,
                            cbSubject.SelectedItem,
                            Int32.Parse(txtGrade.Text),
                            txtBookRecord.Text,
                            DateTime.Parse(txtAcreditationDate.Text));
                    }
                    catch { }
                }
                else {
                    MessageBox.Show("El alumno no fue encontrado");
                }
            } catch {
                MessageBox.Show("No se pudo guardar");
            };
            
        }

        private void cbCareer_SelectedValueChanged(object sender, EventArgs e)
        {
            cbSubject.Items.Clear();
            IEnumerable<object> list = careerController.loadSubject(cbCareer.SelectedItem);
            foreach (object subject in list)
            {

                cbSubject.Items.Add(subject);
            }
        }
    }
}
