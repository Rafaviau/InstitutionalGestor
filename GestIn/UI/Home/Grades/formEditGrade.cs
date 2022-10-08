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
    public partial class formEditGrade : Form
    {
        gradeContorller cntGrade = gradeContorller.GetInstance();
        subjectEnrolmentController cntSubEnrol = subjectEnrolmentController.GetInstance();
        int gradeid;
        int enrolid;
        int studentId_;
        object? subjectObj;
        public formEditGrade(int enrolId, string studentName, string subjectName, string acreditationYear, bool acreditationType,int studentId,object subject)
        {
            InitializeComponent();
            gradeid = -1;
            enrolid = enrolId;
            lblStudent.Text = studentName;
            lblSubject.Text = subjectName;
            txtEntomentYear.Text = acreditationYear;
            ccbPresential.Checked = acreditationType;

            studentId_ = studentId;
            subjectObj = subject;
        }
        public formEditGrade(int gradeId,int enrolId, string studentName, string subjectName,string acreditationYear,bool acreditationType, string grade,string bookRecord,string AcreditationDate,string AccType)
        {
            InitializeComponent();
            gradeid = gradeId;
            enrolid = enrolId;
            lblStudent.Text = studentName;
            lblSubject.Text = subjectName;
            txtEntomentYear.Text = acreditationYear;
            ccbPresential.Checked = acreditationType;

            txtGrade.Text = grade;
            txtBookRecord.Text = bookRecord;
            txtAcreditationDate.Text = AcreditationDate;
            cbAccType.SelectedIndex = cbAccType.FindString(AccType);
        }
        #region "Minimizar,cerrar y arrastrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            int i = 0;
            if (txtEntomentYear.Text.Equals(""))
            {
                MessageBox.Show("El año de acreditacion no puede estar vacio");
            }
            else {
                cntSubEnrol.updateEnrolment(enrolid, txtEntomentYear.Text, ccbPresential.Checked);
                i++;
            }
            int count = ExamFormCompletition();
            if (count < 4 && count > 0) { MessageBox.Show("Complete todos los campos de examen"); }
            else if (count==4 && gradeid < 0) {
                cntGrade.addGrade(studentId_, subjectObj, Int32.Parse(txtGrade.Text), txtBookRecord.Text, DateTime.Parse(txtAcreditationDate.Text), cbAccType.Text);
                i++;
            }
            else if (count == 4 && gradeid > 0)
            {
                cntGrade.updateGrade(gradeid, txtGrade.Text, txtBookRecord.Text,txtAcreditationDate.Text, cbAccType.Text);
                i++;
            }
            if (i > 0) {
                pbDone.Visible = true;
                await Task.Delay(750);
                this.Close();
            }
        }
        private int ExamFormCompletition() {
            int i = 0;
            if (!txtGrade.Text.Equals("")) { i++; }
            if (!txtBookRecord.Text.Equals("")) { i++; }
            if (!txtAcreditationDate.Text.Equals("")) { i++; }
            if (cbAccType.SelectedIndex>=0) { i++; }
            return i;
        }
    }
}
