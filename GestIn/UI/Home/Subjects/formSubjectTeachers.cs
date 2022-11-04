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

        private void formSubjectTeachers_Load(object sender, EventArgs e)
        {
            this.ListboxSearchResults.Visible = false;
            RefreshTableTeachersSubject();
            RefreshLableSubjectName();
        }

        private void formSubjectTeachers_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFormSubject.Show();
        }

        public void RefreshTableTeachersSubject()
        {
            try
            {
                bindingSourceTeachersSubject.DataSource = careerController.getTeachersFromSubject(receivedSubject);
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

        public void RefreshLableTeacherName()
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    object teacher = dataGridViewTeachers.CurrentRow.Cells[1].Value;
                    lblteachername.Text = teacher.ToString();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshLableTeacherName(string teachername)
        {
            try
            {
                lblteachername.Text = teachername;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbCondition.GetItemText(cmbCondition.SelectedItem).Equals(""))
                {
                    MessageBox.Show("Error, agregar Condicion");
                }
                else
                {
                    careerController.assignTeacherCharge(ListboxSearchResults.SelectedItem, receivedSubject, cmbCondition.GetItemText(cmbCondition.SelectedItem));
                    RefreshTableTeachersSubject();
                }
            }
            catch { }
        }

        private void btnModifyDates_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    int selectedTeacherID = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
                    careerController.changeChargeDates(selectedTeacherID, dateTimePickerSince.Value.Date, dateTimePickerUntil.Value.Date);
                    RefreshTableTeachersSubject();
                }
            }
            catch { }
        }

        private void btnDeactivateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    int selectedTeacherID = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
                    string condition = Convert.ToString(dataGridViewTeachers.CurrentRow.Cells[1].Value);
                    careerController.deactivateCharge(selectedTeacherID,condition);
                    RefreshTableTeachersSubject();
                }
            }
            catch { }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeachers.Rows.Count > 0 && dataGridViewTeachers.SelectedRows != null)
                {
                    int selectedTeacherID = Convert.ToInt32(dataGridViewTeachers.CurrentRow.Cells[0].Value);
                    careerController.deactivateCharge(selectedTeacherID);
                    RefreshTableTeachersSubject();
                }
            }
            catch { }
        }

        private void loadSearchResults()
        {
            int Integer = 0;
            bool checkState = Int32.TryParse(txtSearchbar.Text, out Integer);
            if(checkState)
            {
                ListboxSearchResults.DataSource = userController.searchBoxTeacherWithInt(Int32.Parse(txtSearchbar.Text));
            }
            else
            {
                ListboxSearchResults.DataSource = userController.searchBoxTeacherWithString(txtSearchbar.Text);
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchbar.Text.Length == 0)
            {
                ListboxSearchResults.Visible = false;
            }
            else
            {
                ListboxSearchResults.Visible = true;
                loadSearchResults();
            }
        }

        private void txtSearchbar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                ListboxSearchResults.Focus();
            }
        }

        private void ListboxSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && ListboxSearchResults.SelectedIndex <= 0)
            {
                ListboxSearchResults.ClearSelected();
                txtSearchbar.Focus();
            }
            if (e.KeyCode == Keys.Enter && ListboxSearchResults.SelectedIndex >= 0)
            {
                cmbCondition.Enabled = true;
                RefreshLableTeacherName(userController.getTeacher(ListboxSearchResults.SelectedItem).User.Name);
                btnInsert.Enabled = true;
                cmbCondition.Focus();
            }
        }

        private void ListboxSearchResults_DoubleClick(object sender, EventArgs e)
        {
            int index = ListboxSearchResults.SelectedIndex;
            if( index!= null || index<0)
            {
                cmbCondition.Enabled = true;
                RefreshLableTeacherName(userController.getTeacher(ListboxSearchResults.SelectedItem).User.Name);
                btnInsert.Enabled = true;
                cmbCondition.Focus();
                ListboxSearchResults.Visible = false;
            }
        }

        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshLableTeacherName();
        }
    }
}
