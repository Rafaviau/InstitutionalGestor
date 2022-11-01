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

namespace GestIn.UI.Home.ExamEnrolment
{
    public partial class formActaVolante : Form
    {
        examEnrolmentController cntExamEnrol = examEnrolmentController.GetInstance();
        public formActaVolante(int IdExam)
        {
            InitializeComponent();
            foreach (var item in cntExamEnrol.getEnroledStudent(IdExam)) {
                lbStudents.Items.Add(item);
            }
        }
    }
}
