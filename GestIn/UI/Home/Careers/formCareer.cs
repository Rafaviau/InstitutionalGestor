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
        public event EventHandler EnterPressed;
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
                dataGridViewCarreras.Focus();
            }
        }

        public bool VerifyInputs()
        {
            bool state = true;
            if(txtResolutionNumber.Text.Length==0 || txtName.Text.Length==0 || txtTitle.Text.Length==0)
            {
                state = false;
            }
            return state;
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
                    careerController.createCareer(txtResolutionNumber.Text, txtName.Text, txtTitle.Text, cbbTurn.Text);
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
            int id = Convert.ToInt32(dataGridViewCarreras.CurrentRow.Cells[0].Value);
            if (VerifyInputs() && id != null)
            {
                try
                {
                    careerController.updateCareer(id, txtResolutionNumber.Text, txtName.Text, txtTitle.Text, cbbTurn.Text, chkActivo.Checked);
                    lblResult.Text = "Carrera Actualizada";
                    lblResult.Visible = true;
                    StartLableRemovalTimer();
                    RefreshTableCarrera();
                } catch { }
            }
            dataGridViewCarreras.ClearSelection();
            ClearAll();
        }

        private void dataGridViewCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtResolutionNumber.Clear();
            txtName.Clear();
            txtTitle.Clear();
            cbbTurn.SelectedIndex = -1;
        }

        private void dataGridViewCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillCareerValues();
        }

        private void dataGridViewCarreras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        public void FillCareerValues()
        {
            txtResolutionNumber.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[1].Value);
            txtName.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[2].Value);
            txtTitle.Text = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[3].Value);

            if (!Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value).Equals(""))
            {
                cbbTurn.SelectedItem = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value);
            }
            else { cbbTurn.SelectedIndex = -1; }
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

        private void chkActivo_MouseHover(object sender, EventArgs e)
        {
           tooltipActive.SetToolTip(chkActivo, "Indica si la carrera se ecnuentra activa para inscripciones.");
        }
    }
}
