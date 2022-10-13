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
        public FormExams()
        {
            InitializeComponent();
        }

        private void btnNewExam_Click(object sender, EventArgs e)
        {
            gbNewExam.Enabled = true;
        }
    }
}
