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
        }

        public void NullCheckCarreras() //Para que no me paresca errores
        {
            if (careerController.countCareers() != 0)
            {
                RefreshCbbCareers();
                RefreshTableSubjects();
            }
        }

        public void RefreshLableSubjectName(object subject)
        {
            try
            {
                this.lblShowSubjectName.Text = careerController.getSubject(subject).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshTableSubjects()
        {
            if(cbbCarreraSelector.SelectedItem!= null && careerController.getSubjectsFromCareer(cbbCarreraSelector.SelectedItem).Count>0)
            {
                try
                {
                    bindingSourceCarreraMaterias.DataSource = careerController.getSubjectsFromCareer(cbbCarreraSelector.SelectedItem);
                    bindingSourceCarreraMaterias.ResetBindings(false);
                    dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
                    RefreshLableSubjectName(SetGlobalSubject());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    RefreshLableSubjectName(SetGlobalSubject());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                dataGridViewTeachers.Rows.Clear();
            }
        }

        public bool VerifyInputs()
        {
            if (txtNombre.Text.Length == 0 || txtCargaHorariaTotal.Text.Length == 0 || cbbSubjectYear.SelectedText.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RefreshCbbCareers()
        {
            try
            {
                bindingSourceCarreras.DataSource = careerController.loadCareers();
                bindingSourceCarreras.ResetBindings(true);
                cbbCarreraSelector.DataSource = bindingSourceCarreras;
                cbbCarreraSelector.DisplayMember = "NAME";
                cbbCarreraSelector.ValueMember = "ID";
                cbbCarreraSelector.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        public void ClearAll()
        {
            txtNombre.Clear();
            txtCargaHorariaTotal.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(VerifyInputs())
            {
                try
                {
                    careerController.createSubject(Convert.ToInt32(cbbCarreraSelector.SelectedValue), txtNombre.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtCargaHorariaTotal.Text));
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (VerifyInputs() && dataGridViewMaterias.CurrentRow.Cells[0].Value != null)
            {
                try
                {
                    object selectedMateria = SetGlobalSubject();
                    careerController.updateSubject(selectedMateria, txtNombre.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtCargaHorariaTotal.Text));
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
        }

        private object SetGlobalSubject() //a seleccionar una fila/materia de la grilla
        {
            int idmaterium;
            object selectedSubject;
            try
            {
                if(dataGridViewMaterias.SelectedRows != null && cbbCarreraSelector.SelectedItem!=null)
                {
                    idmaterium = Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value);
                    selectedSubject = careerController.getSpecificSubjectFromCareer(cbbCarreraSelector.SelectedItem, idmaterium);
                    RefreshLableSubjectName(selectedSubject);
                    return selectedSubject;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e) { throw e; }
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshLableSubjectName(SetGlobalSubject());
            txtNombre.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[2].Value);
            cbbSubjectYear.SelectedItem = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[3].Value);
            txtCargaHorariaTotal.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
            RefreshTableTeachers();
        }

        private void cbCareerSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableSubjects();
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
                    formSubjectCorrelatives form = new formSubjectCorrelatives(cbbCarreraSelector.SelectedItem, SetGlobalSubject(), this);
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

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
