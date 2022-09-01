using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Controladora;
using GestIn.UI.Test.Subject;
using GestIn.Vista.Test;
using GestIn.Model;

namespace GestIn.Vista.Test
{
    public partial class formCareer : Form
    {
        careerController carreraController;
        //ControladoraPersona personaController; // para Testear
        public formCareer()
        {
            carreraController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formCarrera_Load(object sender, EventArgs e)
        {
            RefreshTableCarrera();
            carreraController.TestCarrera();
            carreraController.TestMateria();
            //personaController.TestDocente();
            RefreshTableCarrera();
        }

        public void RefreshTableCarrera()
        {
            BindingSourceCarreras.DataSource = carreraController.ReturnListCarreras();
            BindingSourceCarreras.ResetBindings(false);
            dataGridViewCarreras.DataSource = null;
            if (carreraController.ReturnListCarreras().Count > 0)
                dataGridViewCarreras.DataSource = dataGridViewCarreras.DataSource = BindingSourceCarreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            carreraController.CreateCarrera(this.txtNumResolucion.Text, this.txtNombre.Text, this.txtTitulo.Text, this.cbbTurno.Text);
            RefreshTableCarrera();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridViewCarreras.ClearSelection();
            //Carrera aux = new Carrera(Int32.Parse(this.txtNumResolucion.Text), this.txtNombre.Text, this.txtTitulo.Text, this.cbbTurno.Text);
            //carreraController.UpdateCarrera(aux);
            carreraController.UpdateCarrera(1,this.txtNumResolucion.Text, this.txtNombre.Text, this.txtTitulo.Text, this.cbbTurno.Text); //HARDCODED
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridViewCarreras.ClearSelection();
            carreraController.DeleteCarrera(1); //HARDCODED
        }

        private void btnFormMateria_Click(object sender, EventArgs e)
        {
            formSubjectCRUD formMateria = new formSubjectCRUD();
            formMateria.ShowDialog();
            
        }
        
        private void btnTesteo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing Values Added");

        }

        private void dataGridViewCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtNumResolucion.Clear();
            txtNombre.Clear();
            txtTitulo.Clear();
            cbbTurno.SelectedIndex = -1;
        }

        private void dataGridViewCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumResolucion.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[2].Value);
            txtTitulo.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[3].Value);
            cbbTurno.SelectedItem = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value);
        }

        private void txtNumResolucion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
