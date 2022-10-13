using GestIn.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        subjectEnrolmentController gradeEnrolmentController = subjectEnrolmentController.GetInstance();
        careerEnrolmentController careerEnrolmentController = careerEnrolmentController.GetInstance();
        public formGrades(string dni)
        {
            InitializeComponent();
            if (!dni.Equals(""))
            {
                txtDni.Text = dni;
                cbCareer.DataSource = careerEnrolmentController.searchCareerEnrolmentReturnCareer(Int32.Parse(dni));
                cbAccType.SelectedIndex = 0;
            }
            else {
                cbCareer.DataSource = careerController.loadCareers();
                cbAccType.SelectedIndex = 0;
            }
            cbCareerEnrol.DataSource = careerController.loadCareers();
            cbAccType.SelectedIndex = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = userController.findStudent(Int32.Parse(txtDni.Text)).Id;
                if (studentId != 0)
                {
                    try
                    {
                        if (!txtEntomentYear.Text.Equals(""))
                        {
                            bool added = gradeEnrolmentController.enrolToAprovedSubject(studentId, cbSubject.SelectedItem, Int32.Parse(txtEntomentYear.Text), ccbPresential.Checked);
                            if (added)
                            {
                                MessageBox.Show("Cursada agregada");
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
                                    MessageBox.Show("Calificacion agregada correctamente");
                                }
                                cbSubject.Items.Remove(cbSubject.SelectedItem);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar la cursada, verifique los datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Complete el año de acreditacion de cursada");
                        }
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("El alumno no fue encontrado");
                }
            }
            catch
            {
                MessageBox.Show("No se pudo guardar");
            };

        }

        private void cbCareer_SelectedValueChanged(object sender, EventArgs e)
        {
            cbSubject.Items.Clear();
            var list = getavailableSubjects(Int32.Parse(txtDni.Text),cbCareer.SelectedItem);
            foreach (object subject in list)
            {

                cbSubject.Items.Add(subject);
            }
        }
        void clearCamps()
        {
            txtEntomentYear.Text = "";
            ccbPresential.Checked = true;
            cbAccType.SelectedIndex = 0;
            txtGrade.Text = "";
            txtBookRecord.Text = "";
            txtAcreditationDate.Text = "";
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            cbSubject.Items.Clear();
            cbCareer.DataSource = careerEnrolmentController.searchCareerEnrolmentReturnCareer(Int32.Parse(txtDni.Text));
            cbAccType.SelectedIndex = 0;
        }

        private void btnSaveEnrol_Click(object sender, EventArgs e)
        {
            if (tbCarrearEnrolYear.Text == "") { MessageBox.Show("Agregue un año de inscripcion"); }
            else
            {
                if(careerEnrolmentController.enrolStudentWithDni(Int32.Parse(txtDni.Text), cbCareerEnrol.SelectedItem, Int32.Parse(tbCarrearEnrolYear.Text)))
                {
                    MessageBox.Show("Agregado Correctamete");
                    cbCareer.DataSource = careerEnrolmentController.searchCareerEnrolmentReturnCareer(Int32.Parse(txtDni.Text));
                    cbAccType.SelectedIndex = 0;
                }
            }
        }

        private void cbAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccType.SelectedItem.Equals("Libre"))
            {
                ccbPresential.Checked = false;
                txtEntomentYear.Text = txtAcreditationDate.Text;
            }
        }
        private dynamic getavailableSubjects(int dni, object career)
        {
            var list = careerController.loadSubject(career);
            var list2 = gradeEnrolmentController.getEnrolments(dni);
            list.RemoveAll(y => list2.Any(x => y.Name == x.Subject.Name));
            return list;
        }
    }
}
