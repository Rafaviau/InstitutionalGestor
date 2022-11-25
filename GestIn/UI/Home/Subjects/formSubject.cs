using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.UI.Home.Careers;
using GestIn.Controllers;

namespace GestIn.UI.Home.Subjects
{
    public partial class formSubject : Form
    {
        careerController careerController;
        public formSubject()
        {
            careerController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formSubject_Load(object sender, EventArgs e)
        {
            NullCheckCarreras();
            NullCheckCareerSubjectCount();
        }

        public void NullCheckCarreras() //Para que no me paresca errores
        {
            if (careerController.countCareers() != 0)
            {
                RefreshCbbCareers();
                NullCheckCareerSubjectCount();
                dataGridViewMaterias.Focus();
            }
        }

        public void NullCheckCareerSubjectCount()
        {
            if(cbbCareerSelector.SelectedItem != null && 
                careerController.getSubjectsFromCareer(cbbCareerSelector.SelectedItem).Count != 0)
            {
                RefreshTableSubjects();
                RefreshLableSubjectName();
                RefreshTableCorrelatives();
            }
        }

        public void RefreshLableSubjectName()
        {
            try
            {
                if(dataGridViewMaterias.CurrentRow != null)
                this.lblShowSubjectName.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[2].Value);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshTableSubjects()
        {
            if(cbbCareerSelector.SelectedItem!= null && careerController.getSubjectsFromCareer(cbbCareerSelector.SelectedItem).Count>0)
            {
                try
                {
                    bindingSourceCarreraMaterias.DataSource = careerController.getSubjectsFromCareer(cbbCareerSelector.SelectedItem);
                    bindingSourceCarreraMaterias.ResetBindings(false);
                    dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                dataGridViewMaterias.DataSource = null;
            }
        }

        public void RefreshTableTeachers()
        {
            int id = Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value);
            if (careerController.getAllActiveCharges(id).Count>0)
            {
                try
                {
                    teacherSubjectBindingSource.DataSource = careerController.getAllActiveCharges(id);
                    teacherSubjectBindingSource.ResetBindings(false);
                    dataGridViewTeachers.DataSource = teacherSubjectBindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                dataGridViewTeachers.Rows.Clear();
                dataGridViewTeachers.DataSource = null;
            }
        }

        public void RefreshTableCorrelatives()
        {
            if(SetGlobalSubject()!=null)
            {
                if (careerController.getCorrelativesFromSubject(SetGlobalSubject()).Count > 0)
                {
                    try
                    {
                        correlativeBindingSource.DataSource = careerController.getCorrelativesFromSubject(SetGlobalSubject());
                        correlativeBindingSource.ResetBindings(false);
                        dataGridViewCorrelatives.DataSource = correlativeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    dataGridViewCorrelatives.Rows.Clear();
                    dataGridViewCorrelatives.DataSource = null;
                }
            }
        }

        public bool VerifyInputs()
        {
            bool state = true;
            if (txtName.Text.Length == 0 || txtTotalHourCount.Text.Length == 0 || cbbSubjectYear.Text.Length == 0)
            {
                state = false;
            }
            return state;
        }

        public void RefreshCbbCareers()
        {
            try
            {
                bindingSourceCarreras.DataSource = careerController.loadCareers();
                bindingSourceCarreras.ResetBindings(true);
                cbbCareerSelector.DataSource = bindingSourceCarreras;
                cbbCareerSelector.DisplayMember = "NAME";
                cbbCareerSelector.ValueMember = "ID";
                cbbCareerSelector.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        public void ClearAll()
        {
            txtName.Clear();
            txtTotalHourCount.Clear();
            txtCupof.Clear();
            lblShowSubjectName.Text = "";
            cbbSubjectYear.SelectedIndex = -1;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(VerifyInputs())
            {
                try
                {
                    careerController.createSubject(Convert.ToInt32(cbbCareerSelector.SelectedValue), txtName.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtTotalHourCount.Text), txtCupof.Text);
                    lblResult.Text = "Materia Guardada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                }
                catch { }
                RefreshTableSubjects();
            }
            else
            {
                MessageBox.Show("Campos Invalidos");
            }
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (VerifyInputs() && dataGridViewMaterias.CurrentRow.Cells[0].Value != null)
            {
                try
                {
                    object selectedMateria = SetGlobalSubject();
                    careerController.updateSubject(selectedMateria, txtName.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtTotalHourCount.Text), txtCupof.Text);
                    lblResult.Text = "Materia Actualizada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                }
                catch { }
                RefreshTableSubjects();
            }
            else
            {
                MessageBox.Show("Campos Invalidos");
            }
            dataGridViewMaterias.ClearSelection();
            ClearAll();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.CurrentRow.Cells[0].Value != null)
            {
                try
                {
                    object selectedMateria = SetGlobalSubject();
                    careerController.softDeleteSubject(selectedMateria);
                    lblResult.Text = "Materia Eliminada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                }
                catch { }
                RefreshTableSubjects();
            }
        }

        private object SetGlobalSubject() //a seleccionar una fila/materia de la grilla
        {
            int idsubject;
            object selectedSubject = null;
            try
            {
                if(dataGridViewMaterias.SelectedRows != null && cbbCareerSelector.SelectedItem != null && dataGridViewMaterias.CurrentRow.Cells[0].Value != null)
                {
                    idsubject = Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value);
                    selectedSubject = careerController.getSpecificSubjectFromCareer(cbbCareerSelector.SelectedItem, idsubject);
                }
                return selectedSubject;
            }
            catch(Exception e) { throw e; }
            ClearAll();
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //FillSubjectValues();
        }
        
        public void FillSubjectValues()
        {
            txtName.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[2].Value);
            cbbSubjectYear.SelectedItem = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[3].Value);
            txtCupof.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
            txtTotalHourCount.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[5].Value);
            RefreshLableSubjectName();
            RefreshTableTeachers();
            RefreshTableCorrelatives();
        }

        private void dataGridViewMaterias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cbCareerSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableSubjects();
            ClearAll();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                if (SetGlobalSubject() != null)
                {
                    this.Visible = false;
                    formSubjectTeachers form = new formSubjectTeachers(SetGlobalSubject(), this);
                    form.Show();
                }

            }
            catch { MessageBox.Show("Error, ninguna materia seleccionada"); }
        }

        private void btnCorrelativas_Click(object sender, EventArgs e)
        {
            try
            {
                if (SetGlobalSubject() != null)
                {
                    this.Visible = false;
                    formSubjectCorrelatives form = new formSubjectCorrelatives(cbbCareerSelector.SelectedItem, SetGlobalSubject(), this);
                    form.Show();
                }
            }
            catch { MessageBox.Show("Error, ninguna materia seleccionada"); }
        }

        public void StartLableRemovalTimer()
        {
            lableTimer.Interval = 4000; // 3 segundos
            lableTimer.Tick += lableTimer_Tick;
            lableTimer.Start();
        }

        private void lableTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lableTimer.Stop();
        }

        private void dataGridViewMaterias_SelectionChanged(object sender, EventArgs e)
        {
            FillSubjectValues();
        }
    }
}
