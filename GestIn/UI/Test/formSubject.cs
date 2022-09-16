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

        public void RefreshTableSubjects()
        {
            bindingSourceCarreraMaterias.DataSource = careerController.getSubjectsFromCareer(cbbCarreraSelector.SelectedItem);
            bindingSourceCarreraMaterias.ResetBindings(false);
            dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
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
            cbbCarreraSelector.Enabled = false;
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
            try
            {
                idmaterium = Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value);
                object selectedSubject = careerController.getSpecificSubjectFromCareer(cbbCarreraSelector.SelectedItem, idmaterium);
                return selectedSubject;
            }
            catch(Exception e) { throw e; }
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Materia Seleccionada" + " " + SetGlobalSubjectium().ToString());
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
                SetGlobalSubject().ToString();
                formSubjectCorrelatives formMateria = new formSubjectCorrelatives(cbbCarreraSelector.SelectedItem, SetGlobalSubject());
                formMateria.ShowDialog();
            }
            catch {}
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            txtNombre.Enabled = true;
            txtAnioCarrera.Enabled = true;
            txtCargaHorariaTotal.Enabled = true;
            cbbCarreraSelector.Enabled = true;
        }

        
    }
}
