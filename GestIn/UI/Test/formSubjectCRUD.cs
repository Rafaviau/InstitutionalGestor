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

namespace GestIn.UI.Test.Subject
{
    public partial class formSubjectCRUD : Form
    {
        careerController carreraController;
        public formSubjectCRUD()
        {
            carreraController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formSubjectCRUD_Load(object sender, EventArgs e)
        {
            NullCheckCarreras();
        }

        public void NullCheckCarreras() //Para que no me paresca errores
        {
            if (carreraController.ReturnListCarreras().Count != 0)
            {
                RefreshCbbCarreras();
                RefreshTableMateria();
            }
        }

        public void RefreshTableMateria()
        {
            bindingSourceCarreraMaterias.DataSource = carreraController.MateriasDeUnaCarrera(cbbCarreraSelector.SelectedItem);
            bindingSourceCarreraMaterias.ResetBindings(false);
            dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
        }

        public void RefreshCbbCarreras()
        {
            try
            {
                bindingSourceCarreras.DataSource = carreraController.ReturnListCarreras();
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

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void ClearAll()
        {
            txtNombre.Clear();
            txtAnioCarrera.Clear();
            txtCargaHorariaTotal.Clear();
        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            carreraController.CreateMateria(Convert.ToInt32(cbbCarreraSelector.SelectedValue), txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text), cbbCarreraSelector.SelectedItem);
            RefreshTableMateria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.CurrentRow.Cells[0].Value!=null&&cbbCarreraSelector.SelectedItem!=null)
            {
                object selectedCareer = cbbCarreraSelector.SelectedItem;
                object selectedMateria = SetGlobalSubjectium();
                carreraController.UpdateMateria(selectedCareer, selectedMateria, txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text));
                RefreshTableMateria();
            }
        }

        private object SetGlobalSubjectium()
        {
            int idmaterium = Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value);
            object selectedSubject = carreraController.GetMateria(cbbCarreraSelector.SelectedItem, idmaterium);
            MessageBox.Show(" ID OF MATERIUM " + idmaterium);
            return selectedSubject;
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[2].Value);
            txtAnioCarrera.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
            txtCargaHorariaTotal.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[5].Value);
        }

        private void cbbCarreraSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableMateria();
        }

        private void btnCorrelativas_MouseClick(object sender, MouseEventArgs e)
        {
            formSubjectCorrelatives formMateria = new formSubjectCorrelatives(cbbCarreraSelector.SelectedItem,SetGlobalSubjectium());
            formMateria.ShowDialog();
        }
    }
}
