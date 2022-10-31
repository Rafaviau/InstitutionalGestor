using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Controllers;

namespace GestIn.UI.Home.Teachers
{
    public partial class formTeacher : Form
    {
        userController userController;
        public formTeacher()
        {
            userController = userController.GetInstance();
            InitializeComponent();
        }

        private void formTeacher_Load(object sender, EventArgs e)
        {
            NullCheckTeachers();
        }

        public void NullCheckTeachers()
        {
            if (userController.loadTeachers().Count != 0)
            {
                RefreshTableTeachers();
            }
        }

        public void RefreshTableTeachers()
        {
            bindingSourceTeachers.DataSource = userController.loadTeachers();
            bindingSourceTeachers.ResetBindings(false);
            dataGridViewTeachers.DataSource = bindingSourceTeachers;
            if (userController.loadTeachers().Count > 0)
            {
                dataGridViewTeachers.DataSource = dataGridViewTeachers.DataSource = bindingSourceTeachers;
                dataGridViewTeachers.CurrentCell.Selected = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
