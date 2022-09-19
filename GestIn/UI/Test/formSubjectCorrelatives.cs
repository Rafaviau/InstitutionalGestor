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

namespace GestIn.UI.Test
{
    public partial class formSubjectCorrelatives : Form
    {
        formSubject parentFormSubject;
        formCareer parentFormCareer;
        careerController careerController;
        object receivedCareer;
        object receivedSubject;
        public formSubjectCorrelatives(object sentCareer,object sentSubject, formSubject receivedFormSubject, formCareer parentFormCareer)
        {
            parentFormSubject = receivedFormSubject;
            parentFormCareer = parentFormCareer;
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
            careerController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formSubjectCorrelatives_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            parentFormSubject = new formSubject(parentFormCareer);
            parentFormSubject.ShowDialog();
            this.Close();
        }

        private void formSubjectCorrelatives_Load(object sender, EventArgs e)
        {
            RefreshLableSubjectName();
            RefreshComboboxCorrelativas();
            RefreshTableCorrelativas();
        }


        public void RefreshComboboxCorrelativas() //en teoria recibo la lista de materias menos la misma
        {
            bindingSourceCorrelativasMenosMisma.DataSource = careerController.getEnabledCorrelatives(receivedCareer,receivedSubject); //Sobrecarga para no mostrar misma materia
            bindingSourceCorrelativasMenosMisma.ResetBindings(true);
            cbbCorrelativas.DataSource = bindingSourceCorrelativasMenosMisma;
            cbbCorrelativas.DisplayMember = "NAME";
            cbbCorrelativas.ValueMember = "ID";
        }

        public void RefreshTableCorrelativas() //DATATABLE CORRELATIVAS
        {
            try
            {
                bindingSourceMateriaCorrelativas.DataSource = careerController.getCorrelativesFromSubject(receivedSubject); 
                bindingSourceMateriaCorrelativas.ResetBindings(true);
                dataGridViewCorrelativas.DataSource = bindingSourceMateriaCorrelativas;
                //dataGridViewCorrelativas.Rows.Add("DDD", "ssss", true);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshLableSubjectName()
        {
            try
            {
                lblmateriaName.Text = careerController.getSubject(receivedSubject).Name;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCorrelativas_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            bool status = false;
            if (chkEstado.Checked)
            {
                status = true;
            }
            careerController.createCorrelative(receivedSubject, selectedSubject, status);
            RefreshTableCorrelativas();
            RefreshComboboxCorrelativas();
        }

        private void btnRemoveCorrelative_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedSubjectID = Convert.ToInt32(dataGridViewCorrelativas.CurrentRow.Cells[0].Value);
            careerController.removeCorrelative(careerController.findCorrelative(selectedSubjectID));
            RefreshTableCorrelativas();
            RefreshComboboxCorrelativas();
        }


    }
}
