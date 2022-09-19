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

namespace GestIn.Vista.Home.Grades
{
    public partial class formGrades : Form
    {
        careerController careerController = Controllers.careerController.GetInstance();
        userController userController = userController.GetInstance();
        gradeContorller gradeController = gradeContorller.GetInstance();
        subjectEnrolmentController gradeEnrolmentController = subjectEnrolmentController.GetInstance();
        public formGrades()
        {
            InitializeComponent();
            foreach (object career in careerController.loadCareers()) {
                cbCareer.Items.Add(career);
            }
            cbAccType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int studentId = userController.findStudent(Int32.Parse(txtDni.Text)).Id;
                if (studentId != 0)
                {
                    try
                    {
                        bool added = gradeEnrolmentController.enrolToAprovedSubject(studentId, cbSubject.SelectedItem, Int32.Parse(txtEntomentYear.Text), ccbPresential.Checked);
                        if (added)
                        {
                            if (!txtGrade.Text.Equals("") && !txtBookRecord.Text.Equals("") && !txtAcreditationDate.Equals(""))
                            {
                                gradeController.addGrade(
                                    studentId,
                                    cbSubject.SelectedItem,
                                    Int32.Parse(txtGrade.Text),
                                    txtBookRecord.Text,
                                    DateTime.Parse(txtAcreditationDate.Text),
                                    cbAccType.SelectedItem.ToString()
                                    );
                                clearCamps();
                                MessageBox.Show("Agreggado correctamente");
                            }
                            else {
                                MessageBox.Show("Para agregar una nota a un examen todos los campos deben estar completos");
                            }
                        }
                        else {
                            MessageBox.Show("No se pudo guardar la cursada, verifique los datos");
                        }
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
        void clearCamps() {
            txtEntomentYear.Text = "";
            ccbPresential.Checked = true;
            cbAccType.SelectedIndex = 0;
            txtGrade.Text = "";
            txtBookRecord.Text = "";
            txtAcreditationDate.Text = "";
        }
    }
}
