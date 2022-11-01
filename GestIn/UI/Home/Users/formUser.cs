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

namespace GestIn.UI.Home.Users
{
    public partial class formUser : Form
    {
        userController userController;
        public formUser()
        {
            userController = userController.GetInstance();
            InitializeComponent();
        }

        private void formTeacher_Load(object sender, EventArgs e)
        {
            NullCheck();
            studentPanel.Visible = false;
            teacherPanel.Visible = false;
        }

        public void NullCheck()
        {
            if (userController.countUsers() != 0)
            {
                lblStudentCount.Text = userController.countStudents().ToString();
                lblTeacherCount.Text = userController.countTeachers().ToString();
                lblUserCount.Text = userController.countUsers().ToString();
                //RefreshTableUserType(); //not necessary
            }
            
        }
        private void checkedListBoxUserType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //solamente 1 seleccionado a la ves
            for (int ix = 0; ix < checkedListBoxUserType.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxUserType.SetItemChecked(ix, false);

            if (checkedListBoxUserType.CheckedItems.Contains("Estudiante")) 
            {
                studentPanel.Visible = false;
                teacherPanel.Visible = true; //por las dudas
            }
            else if (checkedListBoxUserType.CheckedItems.Contains("Docente"))
            {
                teacherPanel.Visible = false;
                studentPanel.Visible = true;
            }
        }
        public void setCheckState()
        {
            int index = getCheckItemIndex();
            if (index>0)
            {
                lblUserType.Text = checkedListBoxUserType.CheckedItems[getCheckItemIndex()].ToString();
            }
            else
            {

            }
        }

        public int getCheckItemIndex()
        {
            //MessageBox.Show("" + checkedListBoxUserType.Items.Count);
            int index = 0;
            for (int i = 0; i < checkedListBoxUserType.Items.Count; i++)
            {
                if (checkedListBoxUserType.GetItemCheckState(i) == CheckState.Checked)
                {
                    index = i;
                }
            }
            MessageBox.Show("" + index + " vs " + checkedListBoxUserType.Items.Count);
            return index;
        }


        private void checkedListBoxUserType_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        public int getListBoxIndex()
        {
            return 0;
        }

        private void checkedListBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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

        private void panelStudentInfoRead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void studentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        

        /* Unnecessary
        public bool NullCheck(int userType)
        {
            bool state = false;
            if (userType == 0)
            {
                if (userController.countStudents() != 0)
                {
                    state = true;
                }
            }
            else
            {
                if (userController.countTeachers() != 0)
                {
                    state = true;
                }
            }
            return state;
        }

        public void RefreshTableUserType(int userType)
        {
            if (userType == 0) //again i'm assuming student starts at index 0
            {
                bindingSourceStudents.DataSource = userController.loadStudent();
                bindingSourceStudents.ResetBindings(false);
                dataGridViewUsers.DataSource = bindingSourceStudents;
                if (userController.countStudents() > 0)
                {
                    dataGridViewUsers.DataSource = dataGridViewUsers.DataSource = bindingSourceStudents;
                    dataGridViewUsers.CurrentCell.Selected = false;
                }
            }
            else
            {
                bindingSourceTeachers.DataSource = userController.loadTeachers();
                bindingSourceTeachers.ResetBindings(false);
                dataGridViewUsers.DataSource = bindingSourceTeachers;
                if (userController.countTeachers() > 0)
                {
                    dataGridViewUsers.DataSource = dataGridViewUsers.DataSource = bindingSourceTeachers;
                    dataGridViewUsers.CurrentCell.Selected = false;
                }
            }
        }

        private void checkedListBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userTypeState = checkedListBoxUserType.SelectedIndex;
            if (NullCheck(userTypeState))
            {
                RefreshTableUserType(userTypeState);
            }

            //Asumo de que el primer indice es el estudiante

        }
        */
    }
}
