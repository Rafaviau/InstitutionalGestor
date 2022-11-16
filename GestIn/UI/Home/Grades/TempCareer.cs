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
    public partial class TempCareer : Form
    {
        careerController careerController = careerController.GetInstance();
        private int careerId;

        public TempCareer()
        {
            InitializeComponent();
            foreach (object career in careerController.loadCareers())
            {
                cbCareer.Items.Add(career);
            }
            int careerId = -1;
        }

        #region Career
        private void btnCareerCreate_Click(object sender, EventArgs e)
        {
            try {
                object career = careerController.createCareer(txtCareerRes.Text, txtCareerName.Text, txtCareerDegree.Text,"TURNO AQUI");
                cbCareer.Items.Add(career);
                MessageBox.Show("AGregado correctamente");
            } catch {
                MessageBox.Show("No se pudo guardar");
            };
            
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            /*
            try {
                careerController.createSubject(123,
                txtSubjectName.Text,
                Int32.Parse(txtYearinCareer.Text),
                Int32.Parse(txtHours.Text),
                cbCareer.SelectedItem);
                clearCareerText();
                MessageBox.Show("Guardado correctamente");
            } catch {
                MessageBox.Show("No se pudo guardar");
            };
            */
        }

        private void bntSearchRes_Click(object sender, EventArgs e)
        {
            if (txtCareerRes.Text.Equals("")) { MessageBox.Show("Ingrese una resolucion valida"); }
            else {
                disableCareerButtons();
                
                Dictionary<string, string> careerData = careerController.loadCareerInformation(txtCareerRes.Text);
                if (careerData != null)
                {
                    careerId = Int32.Parse(careerData["id"]);
                    txtCareerDegree.Text = careerData["degree"];
                    txtCareerName.Text = careerData["name"];
                    btnSearchRes.Enabled = true;
                    btnCareerUpdate.Enabled = true;
                    btnCareerStopEditing.Enabled = true;
                    btnCareerUpdate.Visible = true;
                    btnCareerStopEditing.Visible = true;
                }
                else
                {
                    MessageBox.Show("La carrera no fue encontrada");
                    btnSearchRes.Enabled = true;
                    btnCareerCreate.Enabled = true;
                }
            }
        }

        private void disableCareerButtons()
        {
            btnCareerCreate.Enabled = false;
            btnCareerStopEditing.Enabled = false;
            btnCareerUpdate.Enabled = false;
            btnSearchRes.Enabled = false;
        }

        private void btnCareerStopEditing_Click(object sender, EventArgs e)
        {
            clearCareerText();
            careerId = -1;
            btnCareerCreate.Visible = true; btnCareerCreate.Enabled = true;
            btnCareerStopEditing.Visible = false;
            btnCareerUpdate.Visible = false;
        }
        void clearCareerText() {
            txtCareerDegree.Text = "";
            txtCareerName.Text = "";
            txtCareerRes.Text = "";
        }

        private void btnCareerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (careerId == -1) { MessageBox.Show("No hay una carrera seleccionada. Por favor, busque una carrera para editar"); }
                else {
                  if (careerController.updateCareer(careerId,txtCareerRes.Text, txtCareerName.Text, txtCareerDegree.Text))
                    {
                        careerId = -1;
                        MessageBox.Show("Guardado correctamente");
                        clearCareerText();
                    }
                    else {
                    MessageBox.Show("No se pudo guardar la informacion");
                    }
                }

            }
            catch
            {
                MessageBox.Show("No se pudo guardar la informacion");
            }
        }
        #endregion

        #region Subject



        #endregion
    }
}
