using GestIn.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Grades
{
    public partial class TempStudentCreate : Form
    {
        userController userController = userController.GetInstance();
        public TempStudentCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDni.Equals("") || txtEmail.Equals("") || txtLastName.Equals("") || txtName.Equals("")) { MessageBox.Show("Complete todos los campos"); }
            else {
                try {
                    DateTime? _date = null;
                    if(!txtBirth.Text.Equals(""))
                    {
                        _date = DateTime.Parse(txtBirth.Text);
                    }
                    if(userController.enrolStudent(Int32.Parse(txtDni.Text), txtEmail.Text, txtName.Text, txtLastName.Text, _date, txtPhone.Text))
                    {
                        MessageBox.Show("Guardado correctamente");
                        CleanText();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar. Verifique que el alumno no este cargado");
                    }
                
                } 
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("") || int.TryParse(txtDni.Text, out int n )==false) { MessageBox.Show("Ingrese un dni valido"); }
            else {
                DisableAllButtons();
                txtDni.ReadOnly = true;
                Dictionary<string, string> studentData = userController.loadStudentInformation(Int32.Parse(txtDni.Text));
                if (studentData != null)
                {
                    txtName.Text = studentData["name"];
                    txtLastName.Text = studentData["lastname"];
                    txtEmail.Text = studentData["email"];
                    btnSearch.Enabled = true;
                    btnSaveChanges.Visible = true; btnSaveChanges.Enabled = true;
                    btnStopEditing.Visible = true; btnStopEditing.Enabled = true;
                }
                else {
                    MessageBox.Show("El alumno no fue encontrado");
                    btnSearch.Enabled = true;
                    button1.Enabled = true;
                }

            }
        }
        void DisableAllButtons() {
            btnSaveChanges.Enabled = false;
            btnSearch.Enabled = false;
            btnStopEditing.Enabled = false;
            button1.Enabled = false;
        }
        void CleanText() {
            txtDni.Text = "";
            txtEmail.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtBirth.Text = "";
            txtPhone.Text = "";
        }

        private void btnStopEditing_Click(object sender, EventArgs e)
        {
            CleanText();
            btnSaveChanges.Visible = false; btnSaveChanges.Enabled = false;
            btnStopEditing.Visible = false; btnStopEditing.Enabled = false;
            button1.Visible = true; button1.Enabled = true;
            txtDni.ReadOnly = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //userController.updateStudent(Int32.Parse(txtDni.Text), txtEmail.Text, txtName.Text, txtLastName.Text);
                MessageBox.Show("Guardado correctamente");
                CleanText();
                txtDni.ReadOnly = false;
            }
            catch
            {
                MessageBox.Show("No se pudo guardar la informacion");
            }
        }
    }
}
