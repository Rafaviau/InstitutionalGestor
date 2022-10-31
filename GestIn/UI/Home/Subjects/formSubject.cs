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
            if (careerController.loadCareers().Count != 0)
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
                    //dataGridViewMaterias.Sort(dataGridViewMaterias.Columns[3], 0);
                    dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
                    RefreshLableSubjectName(SetGlobalSubject());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        public void DisableUserInput()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            txtNombre.Enabled = false;
            cbbSubjectYear.Enabled = false;
            cbbCarreraSelector.Enabled = true;
            txtCargaHorariaTotal.Enabled = false;
            lblPermission.Visible = true;
            dataGridViewMaterias.Enabled = true;
        }

        public void ClearAll()
        {
            txtNombre.Clear();
            txtCargaHorariaTotal.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            careerController.createSubject(Convert.ToInt32(cbbCarreraSelector.SelectedValue), txtNombre.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtCargaHorariaTotal.Text));
            RefreshTableSubjects();
            DisableUserInput();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.CurrentRow.Cells[0].Value!=null)
            {
                object selectedMateria = SetGlobalSubject();
                careerController.updateSubject(selectedMateria, txtNombre.Text, Convert.ToInt32(cbbSubjectYear.SelectedItem), Int32.Parse(txtCargaHorariaTotal.Text));
                RefreshTableSubjects();
                DisableUserInput();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            txtNombre.Enabled = true;
            cbbSubjectYear.Enabled = true;
            cbbCarreraSelector.Enabled = false;
            txtCargaHorariaTotal.Enabled = true;
            lblPermission.Visible = true;
            dataGridViewMaterias.Enabled = false;
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
    }
}
