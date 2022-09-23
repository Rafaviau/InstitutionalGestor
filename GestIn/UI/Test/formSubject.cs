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

namespace GestIn.UI.Test
{
    public partial class formSubject : Form
    {
        formCareer thisformCareer;
        careerController careerController;
        public formSubject(formCareer receivedformCareer)
        {
            thisformCareer = receivedformCareer;
            careerController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formSubject_Load(object sender, EventArgs e)
        {
            NullCheckCarreras();
        }

        private void formSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            thisformCareer = new formCareer();
            thisformCareer.ShowDialog();
            this.Close();
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
            bindingSourceCarreraMaterias.DataSource = careerController.getSubjectsFromCareer(cbbCarreraSelector.SelectedItem);
            bindingSourceCarreraMaterias.ResetBindings(false);
            dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
            dataGridViewMaterias.ClearSelection();
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
            txtAnioCarrera.Enabled = false;
            txtCargaHorariaTotal.Enabled = false;
        }

        public void ClearAll()
        {
            txtNombre.Clear();
            txtAnioCarrera.Clear();
            txtCargaHorariaTotal.Clear();
        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            careerController.createSubject(Convert.ToInt32(cbbCarreraSelector.SelectedValue), txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text));
            RefreshTableSubjects();
            DisableUserInput();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.CurrentRow.Cells[0].Value!=null)
            {
                object selectedMateria = SetGlobalSubject();
                careerController.updateSubject(selectedMateria, txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text));
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
                if(dataGridViewMaterias.SelectedRows != null)
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
            txtAnioCarrera.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[3].Value);
            txtCargaHorariaTotal.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
        }

        private void cbbCarreraSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableSubjects();
        }

        private void btnCorrelativas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(SetGlobalSubject()!=null)
                {
                    this.Hide();
                    SetGlobalSubject().ToString();
                    formSubjectCorrelatives formMateria = new formSubjectCorrelatives(cbbCarreraSelector.SelectedItem, SetGlobalSubject(), this, thisformCareer);
                    formMateria.ShowDialog();
                    this.Close();
                }
                
            }
            catch { MessageBox.Show("Error, ninguna materia seleccionada");  }
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            txtNombre.Enabled = true;
            txtAnioCarrera.Enabled = true;
            txtCargaHorariaTotal.Enabled = true;
        }
    }
}
