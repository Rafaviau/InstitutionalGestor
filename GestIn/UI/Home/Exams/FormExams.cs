using GestIn.Controllers;
using GestIn.Model;
using GestIn.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Exams
{
    public partial class FormExams : Form
    {
        careerController careerController = careerController.GetInstance();
        examController examCnt = examController.GetInstance();

        public FormExams()
        {
            InitializeComponent();
            cbbCarrer.DataSource = careerController.loadCareers();
            loadExams();
        }
        private void loadExams()
        {
            foreach (Exam e in examCnt.loadExams()) {
                addExam(e);
            }
        }
        private void addExam(int cod, string career, string subject, DateTime date)
        {
            int StudentsEnroled = 0;
            dgvExams.Rows.Add(cod,career,subject,date, StudentsEnroled);
        }
        private void addExam(Exam ex)
        {
            int StudentsEnroled = 0;
            dgvExams.Rows.Add(ex.Id, ex.IdSubjectNavigation.Career.Name, ex.IdSubjectNavigation.Name, ex.Date, StudentsEnroled);
        }
        private void btnNewExam_Click(object sender, EventArgs e)
        {
            lblMode.Text = "Crear nuevo examen";
            changeButtonsState();
            changeShowLabelState();
            changeNewExamState();
            btnSave.Visible = true;
            btnSaveUpdate.Visible = false;
        }
        private void changeNewExamState() {
            if(gbNewExam.BackColor == Color.FromArgb(54, 57, 63)) gbNewExam.BackColor = Color.FromArgb(84, 87, 93);
            else gbNewExam.BackColor = Color.FromArgb(54, 57, 63);
            cbbCarrer.Visible = !cbbCarrer.Visible;
            cbbSubject.Visible = !cbbSubject.Visible;
            cbb1Vowel.Visible = !cbb1Vowel.Visible;
            cbb2Vowel.Visible = !cbb2Vowel.Visible;
            cbb3Vowel.Visible = !cbb3Vowel.Visible;
            cbbTitular.Visible = !cbbTitular.Visible;
            txtPlace.Visible = !txtPlace.Visible;
            dtDate.Visible = !dtDate.Visible;
            dtTime.Visible = !dtTime.Visible;
            btnCancel.Enabled = !btnCancel.Visible;
            lblMode.Visible = !lblMode.Visible;
            btnCancel.Visible = !btnCancel.Visible;
        }
        private void changeShowLabelState()
        {
            lblShowCareer.Visible = !lblShowCareer.Visible;
            lblShowDate.Visible = !lblShowDate.Visible;
            lblShowFirst.Visible = !lblShowFirst.Visible;
            lblShowPlace.Visible = !lblShowPlace.Visible;
            lblShowSec.Visible = !lblShowSec.Visible;
            lblShowSubject.Visible = !lblShowSubject.Visible;
            lblShowThird.Visible = !lblShowThird.Visible;
            lblShowTime.Visible = !lblShowTime.Visible;
            lblShowTit.Visible = !lblShowTit.Visible;
        }
        private void clearExamForm() {
            cbbCarrer.SelectedIndex = 1;
            cbbSubject.SelectedIndex = 1;
            //cbb1Vowel.SelectedIndex = 1;
            //cbb2Vowel.SelectedIndex = 1;
            //cbb3Vowel.SelectedIndex = 1;
            //cbbTitular.SelectedIndex = 1;
            txtPlace.Text = "";

        }
        private (bool,string) verifyNewExamInfo() {
            string msg = "Cargado";
            bool loaded = true;
            if (cbbSubject.SelectedItem == null)
            {
                msg = "Error, elija una materia";
                loaded = false;
            }
            else if (!dtDate.Checked) { 
                msg = "Error, elija una fecha";
                loaded = false;
            } 
            return (loaded,msg);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var state = verifyNewExamInfo();
            if (!state.Item1) showError(state.Item2, state.Item1);
            else {
                DateTime examDateTime = DateTime.Parse(dtDate.Value.ToString("yyyy-MM-dd") +" "+ dtTime.Value.ToString("HH:mm:00"));
                if (examCnt.createExam(
                    cbbSubject.SelectedItem,
                    teacherSelection(cbbTitular),
                    teacherSelection(cbb1Vowel),
                    teacherSelection(cbb2Vowel),
                    teacherSelection(cbb3Vowel),
                    examDateTime,
                    txtPlace.Text
                    )) 
                {
                    showError("Actualizado correctamente", true);
                    dgvExams.Rows.Clear();
                    loadExams();

                    clearExamForm();
                    changeStates();
                    btnSave.Visible = false;
                }
            }
        }

        private void cbbCarrer_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbSubject.Items.Clear();
            var list = careerController.loadSubject(cbbCarrer.SelectedItem);
            foreach (object subject in list)
            {
                cbbSubject.Items.Add(subject);
            }
        }
        private object teacherSelection(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)return comboBox.SelectedItem;
            else return null;
        }
        private async Task showError(string msg,bool success)
        {
            if (!success)
            {
                lblError.ForeColor = Color.IndianRed;
                lblError.Image = Resources.Error;
            }
            else
            {
                lblError.ForeColor = Color.FromArgb(75, 181, 67);
                lblError.Image = Resources.TickIcon;
            }
            lblError.Text = "         " + msg;
            lblError.Visible = true;
            await Task.Delay(2000);
            lblError.Visible = false;
        }
        private void changeButtonsState() {
            btnNewExam.Visible = !btnNewExam.Visible;
            btnUpdateExam.Visible = !btnUpdateExam.Visible;
            btnDeleteExam.Visible = !btnDeleteExam.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            changeStates();
            changeButtonsState();
            clearExamForm();
            btnSave.Visible = false;
            btnSaveUpdate.Visible = false;
        }

        private void btnUpdateExam_Click(object sender, EventArgs e)
        {
            lblMode.Text = "Actualizar examen existente";
            changeButtonsState();
            changeStates();
            loadEditExam();
            btnSaveUpdate.Visible = true;
            btnSave.Visible = false;
        }
        private void changeStates() {
            changeShowLabelState();
            changeNewExamState();
        }
        private void addExamInfoToLbl(int examCode) {
            var exam = examCnt.findExam(examCode);
            lblShowCareer.Text = exam.IdSubjectNavigation.Career.Name;
            lblShowDate.Text = exam.Date.ToString("yyyy/MM/dd");
            lblShowTime.Text = exam.Date.ToString("HH:mm");
            lblShowPlace.Text = exam.Place;
            lblShowSubject.Text = exam.IdSubjectNavigation.Name;

            if(exam.FirstVowelNavigation != null) lblShowFirst.Text = exam.FirstVowelNavigation.User.Name + " " + exam.FirstVowelNavigation.User.Dni;
            if (exam.SecondVowelNavigation != null)lblShowSec.Text = exam.SecondVowelNavigation.User.Name + " " + exam.SecondVowelNavigation.User.Dni;
            if(exam.ThirdVowelNavigation != null)lblShowThird.Text = exam.ThirdVowelNavigation.User.Name + " " + exam.ThirdVowelNavigation.User.Dni;
            if (exam.TitularNavigation != null)lblShowTit.Text = exam.TitularNavigation.User.Name + " " + exam.TitularNavigation.User.Dni;
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            addExamInfoToLbl(Int32.Parse(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString()));
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            var state = verifyNewExamInfo();
            if (!state.Item1) showError(state.Item2, state.Item1);
            else
            {
                DateTime examDateTime = DateTime.Parse(dtDate.Value.ToString("yyyy-MM-dd") + " " + dtTime.Value.ToString("HH:mm:00"));
                if (examCnt.updateExam(Int32.Parse(lblExamCode.Text),
                    cbbSubject.SelectedItem,
                    teacherSelection(cbbTitular),
                    teacherSelection(cbb1Vowel),
                    teacherSelection(cbb2Vowel),
                    teacherSelection(cbb3Vowel),
                    examDateTime,
                    txtPlace.Text
                    ))
                {
                    showError("Actualizado correctamente", true);
                    dgvExams.Rows.Clear();
                    loadExams();

                    clearExamForm();
                    changeStates();
                    btnSaveUpdate.Visible = false;
                }
            }
        }
        private void loadEditExam()
        {
            lblExamCode.Text = dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cbbCarrer.SelectedIndex = cbbCarrer.FindString(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[1].Value.ToString());
            cbbSubject.SelectedIndex = cbbSubject.FindString(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[2].Value.ToString());
            dtDate.Text = dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dtTime.Text = dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[3].Value.ToString();

            cbbTitular.SelectedIndex = cbbSubject.FindString("TEST");
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (examCnt.deleteExam(Int32.Parse(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString()))) {
                    dgvExams.Rows.RemoveAt(dgvExams.CurrentCell.RowIndex);
                }
            }
        }
    }
}
