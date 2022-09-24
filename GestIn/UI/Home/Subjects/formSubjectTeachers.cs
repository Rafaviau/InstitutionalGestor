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

namespace GestIn.UI.Home.Subjects
{
    public partial class formSubjectTeachers : Form
    {
        formSubject parentFormSubject;
        careerController careerController;
        userController userController;
        object receivedSubject;
        public formSubjectTeachers(object sentSubject, formSubject receivedFormSubject)
        {
            parentFormSubject = receivedFormSubject;
            receivedSubject = sentSubject;
            careerController = careerController.GetInstance();
            userController = userController.GetInstance();
            InitializeComponent();
        }

        private void formSubjectTeachers_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentFormSubject.Visible = true;
            this.Close();
        }

        private void formSubjectTeachers_Load(object sender, EventArgs e)
        {
            RefreshLableSubjectName();
        }

        public void RefreshComboboxTeachers()
        {
            /*
            //TeacherController  || UserController
            bindingSourceTeachers.DataSource = userController.loadTeachers();
            bindingSourceTeachers.ResetBindings(true);
            cbbTeacher.DataSource = bindingSourceTeachers;
            cbbTeacher.DisplayMember = "NAME";
            cbbTeacher.ValueMember = "ID";
            */
        }

        public void RefreshTableTeachersSubject()
        {
            try
            {
                bindingSourceTeachersSubject.DataSource = careerController.getTeacherFromSubject(receivedSubject);
                bindingSourceTeachersSubject.ResetBindings(true);
                dataGridViewTeachers.DataSource = bindingSourceTeachersSubject;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshLableSubjectName()
        {
            try
            {
                lblmateriaName.Text = careerController.getSubject(receivedSubject).Name;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAddDocente_Click(object sender, EventArgs e)
        {
            object selectedTeacher = cbbTeacher.SelectedItem;
            careerController.assignTeacherCharge(receivedSubject, selectedTeacher);
            RefreshTableTeachersSubject();
        }

        private void btnRemoveDocente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0)
                {
                    int selectedTeacherID = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
                    careerController.removeTeacherCharge(selectedTeacherID);
                    RefreshTableTeachersSubject();
                }
            }
            catch { }
        }
    }
}
