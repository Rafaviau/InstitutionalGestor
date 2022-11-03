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
            cmbUserType.SelectedIndex = 0;

        }

        public void NullCheck()
        {
            if (userController.countUsers() != 0)
            {
                lblStudentCount.Text = userController.countStudents().ToString();
                lblTeacherCount.Text = userController.countTeachers().ToString();
                //RefreshTableUserType(); //not necessary
            }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkCurrentState();
        }

        public void checkCurrentState()
        {
            if (cmbUserType.SelectedItem.ToString().Equals("Estudiante"))
            {
                studentPanel.Visible = true;
                teacherPanel.Visible = false;
                lblUserType.Text = cmbUserType.SelectedItem.ToString();
            }
            else
            {
                studentPanel.Visible = false;
                teacherPanel.Visible = true;
                lblUserType.Text = cmbUserType.SelectedItem.ToString();
            }

        }

        public bool ValidateInformation()
        {
            bool state = true;
            if (txtUserDni.Equals("") || txtUserEmail.Equals("") || txtUserLastName.Equals("") || txtUserName.Equals("")) 
            { 
                state = false; 
            }
            return state;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedItem.ToString().Equals("Estudiante")) //Student
            {
                if (ValidateInformation())
                {
                    try
                    {
                        userController.enrolStudent(Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text, UserDateBirth.Value.Date, txtUserPhoneNumber.Text);
                        lblSuccess.Text = "Estudiante creado";
                        lblSuccess.Visible = true;
                        lblTeacherCount.Text = userController.countStudents().ToString();

                    }
                    catch (Exception ex){MessageBox.Show(ex.Message);}
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            else //Teacher
            {
                if (ValidateInformation())
                {
                    try
                    {
                        userController.inputTeacher(Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text,
                            UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, txtUserGender.Text, txtCUILL.Text, txtTitle.Text);
                        lblSuccess.Text = "Docente creado";
                        lblSuccess.Visible = true;
                        lblTeacherCount.Text = userController.countTeachers().ToString();

                    }
                    catch (Exception ex){MessageBox.Show(ex.Message);}
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lblSuccess_Click(object sender, EventArgs e)
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
