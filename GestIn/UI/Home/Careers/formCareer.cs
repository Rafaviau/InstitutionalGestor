﻿using System;
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

        private void formCareer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void formCarrera_Load(object sender, EventArgs e)
        {
            RefreshTableCarrera();
        }

        public void RefreshTableCarrera()
        {
            BindingSourceCarreras.DataSource = careerController.loadCareers();
            BindingSourceCarreras.ResetBindings(false);
            dataGridViewCarreras.DataSource = null;
            if (careerController.loadCareers().Count > 0)
                dataGridViewCarreras.DataSource = dataGridViewCarreras.DataSource = BindingSourceCarreras;
            dataGridViewCarreras.CurrentCell.Selected = false;
        }

        public void RefreshLableCareerName(int careerID)
        {
            try
            {
                lblcarreraaqui.Text = careerController.getCareer(careerID).Name;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void DisableUserInput()
        {
            txtNumResolucion.Enabled = false;
            txtNombre.Enabled = false;
            txtTitulo.Enabled = false;
            cbbTurno.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            lblPermission.Visible = false;
            dataGridViewCarreras.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            careerController.createCareer(this.txtNumResolucion.Text, this.txtNombre.Text, this.txtTitulo.Text, this.cbbTurno.Text);
            RefreshTableCarrera();
            DisableUserInput();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dataGridViewCarreras.ClearSelection();
            int id = Convert.ToInt32(dataGridViewCarreras.CurrentRow.Cells[0].Value);
            careerController.updateCareer(id, this.txtNumResolucion.Text, this.txtNombre.Text, this.txtTitulo.Text, this.cbbTurno.Text);
            RefreshTableCarrera();
            DisableUserInput();
        }

        private void btnFormMateria_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                formSubject formMateria = new formSubject(this);
                formMateria.ShowDialog();
            }
            catch { }
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
            cbbTurno.SelectedItem = Convert.ToString(dataGridViewCarreras.CurrentRow.Cells[4].Value);
            RefreshLableCareerName(id);
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataGridViewCarreras.CurrentRow!=null)
            {
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                txtNumResolucion.Enabled = true;
                txtNombre.Enabled = true;
                txtTitulo.Enabled = true;
                cbbTurno.Enabled = true;
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                lblPermission.Visible = true;
                dataGridViewCarreras.Enabled = false;
            }
        }

        private void lblcarreraaqui_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}