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
            try {
                userController.enrolStudent(Int32.Parse(txtDni.Text), txtEmail.Text, txtName.Text, txtLastName.Text);
                MessageBox.Show("Guardado correctamente");
            } catch {
                MessageBox.Show("No se pudo guardar la informacion");
                    }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> studentData = userController.loadStudentInformation(Int32.Parse(txtDni.Text));
            txtName.Text = studentData["name"];
            txtLastName.Text = studentData["lastname"];
            txtEmail.Text = studentData["email"];
        }
    }
}
