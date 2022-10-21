using GestIn.Controllers;
using GestIn.UI.Home.Subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Subjects
{
    public partial class formSubjectCorrelatives : Form
    {
        formSubject parentFormSubject;
        careerController careerController;
        object receivedCareer;
        object receivedSubject;
        public formSubjectCorrelatives(object sentCareer,object sentSubject, formSubject receivedFormSubject)
        {
            parentFormSubject = receivedFormSubject;
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
            careerController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formSubjectCorrelatives_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFormSubject.Show();
        }

        private void formSubjectCorrelatives_Load(object sender, EventArgs e)
        {
            RefreshLableSubjectName();
            RefreshComboboxCorrelativas();
            RefreshTableCorrelativas();
        }


        public void RefreshComboboxCorrelativas()
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

        private void btnAddCorrelative_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            careerController.createCorrelative(receivedSubject, selectedSubject, chkEstado.Checked);
            RefreshComboboxCorrelativas();
            RefreshTableCorrelativas();
            
        }

        private void btnRemoveCorrelative_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridViewCorrelativas.Rows.Count > 0)
                {
                    int selectedSubjectID = Convert.ToInt32(dataGridViewCorrelativas.CurrentRow.Cells[0].Value);
                    careerController.removeCorrelative(careerController.findCorrelative(selectedSubjectID));
                    RefreshComboboxCorrelativas();
                    RefreshTableCorrelativas();
                }
            }
            catch { }
        }

        private void formSubjectCorrelatives_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }

        private void formSubjectCorrelatives_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
