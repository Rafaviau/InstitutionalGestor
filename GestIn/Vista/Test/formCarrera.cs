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
using GestIn.Modelo.Clases;

namespace GestIn.Vista.Test
{
    public partial class formCarrera : Form
    {
        ControladoraCarrera carreraController;
        public formCarrera()
        {
            carreraController = ControladoraCarrera.GetInstance();
            InitializeComponent();
        }

        private void formCarrera_Load(object sender, EventArgs e)
        {
            RefreshTableCarrera();
        }

        public void RefreshTableCarrera()
        {
            BindingSourceCarreras.DataSource = carreraController.ReturnListCarreras();
            BindingSourceCarreras.ResetBindings(false);
            dataGridViewCarreras.DataSource = BindingSourceCarreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            carreraController.CreateCarrera(Int32.Parse(this.txtNumResolucion.Text), this.txtNombre.Text, this.txtNombreCorto.Text, this.cbbTurno.Text);
            RefreshTableCarrera();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Carrera aux = new Carrera(Int32.Parse(this.txtNumResolucion.Text), this.txtNombre.Text, this.txtNombreCorto.Text, this.cbbTurno.Text);
            carreraController.UpdateCarrera(aux);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            carreraController.DeleteCarrera(Convert.ToInt32(txtNumResolucion.Text));
        }

        private void btnFormMateria_Click(object sender, EventArgs e)
        {
            formMateria formMateria = new formMateria();
            formMateria.ShowDialog();
        }
        
        private void btnTesteo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing Values Added");
            carreraController.TestCarrera();
            carreraController.TestMateria();
            RefreshTableCarrera();
        }

        private void dataGridViewCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtNumResolucion.Clear();
            txtNombre.Clear();
            txtNombreCorto.Clear();
            cbbTurno.SelectedIndex = -1;
        }

        private void dataGridViewCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumResolucion.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[1].Value);
            txtNombreCorto.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[2].Value);
            cbbTurno.SelectedItem = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[3].Value);
        }
    }
}
