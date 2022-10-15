using GestIn.Controllers;
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
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            if (cbbTitular.Enabled == true) disableNewExam();
            else enableNewExam();
        }
        private void enableNewExam() {
            gbNewExam.BackColor = Color.FromArgb(54, 57, 63);
            cbbCarrer.Enabled = true;
            cbbSubject.Enabled = true;
            cbb1Vowel.Enabled = true;
            cbb2Vowel.Enabled = true;
            cbb3Vowel.Enabled = true;
            cbbTitular.Enabled = true;
            txtPlace.Enabled = true;
            dtDate.Enabled = true;
            dtTime.Enabled = true;
            btnSave.Enabled = true;
        }
        private void disableNewExam() {
            gbNewExam.BackColor = Color.FromArgb(84, 87, 93);
            cbbCarrer.Enabled = false;
            cbbSubject.Enabled = false;
            cbb1Vowel.Enabled = false;
            cbb2Vowel.Enabled = false;
            cbb3Vowel.Enabled = false;
            cbbTitular.Enabled = false;
            txtPlace.Enabled = false;
            dtDate.Enabled = false;
            dtTime.Enabled = false;
            btnSave.Enabled = false;
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
            if (!state.Item1) showError(state.Item2);
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
                    )) MessageBox.Show("Cargado");
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
        private async Task showError(string msg)
        {
            lblError.ForeColor = Color.IndianRed;
            lblError.Image = (Image)Resources.ResourceManager.GetObject("Error.png");
            lblError.Text = "         " + msg;
            lblError.Visible = true;
            await Task.Delay(2000);
            lblError.Visible = false;
        }
    }
}
