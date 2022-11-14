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
using GestIn.UI.Home.Subjects;
using GestIn.Model;

namespace GestIn.UI.Home.Careers
{
    public partial class formCareer : Form
    {
        careerController careerController;
        public formCareer()
        {
            careerController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formCarrera_Load(object sender, EventArgs e)
        {
            NullCheckCarreras();
        }

        public void NullCheckCarreras()
        {
            if (careerController.countCareers() != 0)
            {
                RefreshTableCarrera();
            }
        }

        public bool VerifyInputs()
        {
            if(txtNumResolucion.Text.Length==0 || txtNombre.Text.Length==0 || txtTitulo.Text.Length==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RefreshTableCarrera()
        {
            BindingSourceCarreras.DataSource = careerController.loadCareers();
            BindingSourceCarreras.ResetBindings(false);
            dataGridViewCarreras.DataSource = null;
            if (careerController.loadCareers().Count > 0)
            {
                dataGridViewCarreras.DataSource = dataGridViewCarreras.DataSource = BindingSourceCarreras;
                dataGridViewCarreras.CurrentCell.Selected = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerifyInputs())
            {
                try
                {
                    careerController.createCareer(txtNumResolucion.Text, txtNombre.Text, txtTitulo.Text, cbbTurno.Text);
                    lblResult.Text = "Carrera Guardada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                    RefreshTableCarrera();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Campos Incorrectos");
            }
            ClearAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridViewCarreras.ClearSelection();
            int id = Convert.ToInt32(dataGridViewCarreras.CurrentRow.Cells[0].Value);
            if(VerifyInputs() && id!=null)
            {
                try
                {
                    careerController.updateCareer(id, txtNumResolucion.Text, txtNombre.Text, txtTitulo.Text, cbbTurno.Text, chkActivo.Checked);
                    lblResult.Text = "Carrera Actualizada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                    RefreshTableCarrera();
                } catch { }
            }
            else
            {
                MessageBox.Show("Campos Incorrectos");
            }
            ClearAll();
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
            int id = Convert.ToInt32(dataGridViewCarreras.CurrentRow.Cells[0].Value);
            txtNumResolucion.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[2].Value);
            txtTitulo.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[3].Value);

            if (!Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value).Equals(""))
            {
                cbbTurno.SelectedItem = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value);
            }
            else { cbbTurno.SelectedIndex = -1; }
            chkActivo.Checked = Convert.ToBoolean(dataGridViewCarreras.CurrentRow.Cells[5].Value);
        }

        public void StartLableRemovalTimer()
        {
            lableTimer.Interval = 4000; // 4 segundos
            lableTimer.Tick += lableTimer_Tick;
            lableTimer.Start();
        }

        private void lableTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lableTimer.Stop();
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkActivo_MouseHover(object sender, EventArgs e)
        {
           //toolTip1.SetToolTip(chkActivo, "Indica si la carrera se ecnuentra activa para inscripciones.");
        }
    }
}
