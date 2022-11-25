using GestIn.Controllers;
using GestIn.Model;
using GestIn.Properties;
using GestIn.Reports;
using GestIn.UI.Commons;
using GestIn.UI.Home.ExamEnrolment;
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
        examEnrolmentController examEnrolCnt = examEnrolmentController.GetInstance();
        userController userCnt = userController.GetInstance();
        generatorActaVolante genActaVolante = new generatorActaVolante();

        public FormExams()
        {
            InitializeComponent();
            dtDate.CustomFormat = "dd-MM-yyyy";
            cbbCarrer.DataSource = careerController.loadCareers();
            loadExams(examCnt.loadExams());
        }
        private void loadExams(List<Exam>exams)
        {
            dgvExams.Rows.Clear();
            foreach (Exam e in exams) {
                addExam(e);
            }
        }
        private void loadExam(Exam exam)
        {
            dgvExams.Rows.Clear();
            addExam(exam);
        }
        private void addExam(Exam ex)
        {
            int StudentsEnroled = examEnrolCnt.countEnroledStudent(ex.Id);
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
            cbbCarrer.SelectedIndex = 0;
            cbbSubject.SelectedIndex = -1;
            cbb1Vowel.SelectedIndex = -1;
            cbb2Vowel.SelectedIndex = -1;
            cbb3Vowel.SelectedIndex = -1;
            cbbTitular.SelectedIndex = -1;
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
                    loadExams(examCnt.loadExams());
                    clearExamForm();
                    changeStates();
                    changeButtonsState();
                    btnSave.Visible = false;
                }
            }
        }

        private void cbbCarrer_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbSubject.Items.Clear();
            var list = careerController.getSubjectsFromCareer(cbbCarrer.SelectedItem);
            foreach (object subject in list)
            {
                cbbSubject.Items.Add(subject);
            }
            loadTeachersCb();
        }

        private void loadTeachersCb() {
            var list = userCnt.getAllTeachersFromCareer(cbbCarrer.SelectedItem);
            cbbTitular.Items.Clear();
            cbb1Vowel.Items.Clear();
            cbb2Vowel.Items.Clear();
            cbb3Vowel.Items.Clear();

            cbbTitular.Items.Add("--Vacio--");
            cbb1Vowel.Items.Add("--Vacio--");
            cbb2Vowel.Items.Add("--Vacio--");
            cbb3Vowel.Items.Add("--Vacio--");
            foreach (object subject in list)
            {
                cbbTitular.Items.Add(subject);
                cbb1Vowel.Items.Add(subject);
                cbb2Vowel.Items.Add(subject);
                cbb3Vowel.Items.Add(subject);
            }

        }
        private object teacherSelection(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null || comboBox.SelectedItem == "--Vacio--") return null;
            else return comboBox.SelectedItem;
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
            lblShowDate.Text = exam.Date.ToString("dd/MM/yyyy");
            lblShowTime.Text = exam.Date.ToString("HH:mm");
            lblShowPlace.Text = exam.Place;
            lblShowSubject.Text = exam.IdSubjectNavigation.Name;

            lblShowFirst.Text = exam?.FirstVowelNavigation?.User.Name + " " + exam?.FirstVowelNavigation?.User.Dni;
            lblShowSec.Text = exam?.SecondVowelNavigation?.User.Name + " " + exam?.SecondVowelNavigation?.User.Dni;
            lblShowThird.Text = exam?.ThirdVowelNavigation?.User.Name + " " + exam?.ThirdVowelNavigation?.User.Dni;
            lblShowTit.Text = exam?.TitularNavigation?.User.Name + " " + exam?.TitularNavigation?.User.Dni;
        }

        private void dgvExams_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
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
                    loadExams(examCnt.loadExams());

                    clearExamForm();
                    changeStates();
                    changeButtonsState();
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
            if (Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells["enrollments"].Value) > 0) {
                showError("No se pueden eliminar examenes con estudiantes inscriptos. Primero delos de baja", false);
            }
            else
            {
                var confirmResult = MessageBox.Show("¿Esta seguro que desa eliminar este examen?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (examCnt.deleteExam(Int32.Parse(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                    {
                        dgvExams.Rows.RemoveAt(dgvExams.CurrentCell.RowIndex);
                    }
                }
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            panelOptions.Visible = !panelOptions.Visible;
        }

        private void btnGenerateExams_Click(object sender, EventArgs e)
        {
            FormGenerateMultipleExams formGenerate = new FormGenerateMultipleExams();
            formGenerate.ShowDialog();
            panelOptions.Visible = !panelOptions.Visible;
        }

        private void dgvExams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dgvExams.Rows[dgvExams.SelectedRows[0].Index].Cells[0] != null) {
                Helpers.OpenChildForm(
                    new formGradeFromExam(
                    Convert.ToInt32(dgvExams.Rows[dgvExams.SelectedRows[0].Index].Cells[0].Value)), this.Parent);
            }
        }

        private void cbbSubject_SelectedValueChanged(object sender, EventArgs e)
        {
            selectTitularTeacher();
        }
        void selectTitularTeacher() {
            User thisTitular = userCnt.getMostResentActiveUserTeacher(cbbSubject.SelectedItem);
            if (thisTitular == null) cbbTitular.SelectedIndex = cbbTitular.FindString("--Vacio--");
            else cbbTitular.SelectedIndex = cbbTitular.FindString(thisTitular.fullName());
        }

        private void toggDate_CheckedChanged(object sender, EventArgs e)
        {
            if (toggDate.Checked) {
                dtSearchDate.Enabled = false;
            }
            else {
                dtSearchDate.Enabled = true;
            }
        }

        private void btnSearchExam_Click(object sender, EventArgs e)
        {
            if (txtSearchCode.Text != "")
            {
                loadExam(examCnt.findExam(Convert.ToInt32(txtSearchCode.Text)));
            }
            else
            {
                if (toggDate.Checked)
                    loadExams(examCnt.loadExamsRecord());
                else
                {
                    loadExams(examCnt.loadExams(dtSearchDate.Value));
                }
            }
        }

        private void btnGenerateActaVolante_Click(object sender, EventArgs e)
        {
            genActaVolante.getActaVolante(Convert.ToInt32(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[0].Value));
        }
    }
}
