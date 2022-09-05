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
        careerController carreraController;
        subjectController subjectController;
        object receivedCareer;
        object receivedSubject;
        public formSubjectCorrelatives(object sentCareer,object sentSubject)
        {
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
            carreraController = careerController.GetInstance();
            subjectController = subjectController.GetInstance();
            InitializeComponent();
        }

        private void formSubjectCorrelatives_Load(object sender, EventArgs e)
        {
            RefreshLableSubjectName();
            RefreshComboboxCorrelativas();
            RefreshTableCorrelativas();
        }


        public void RefreshComboboxCorrelativas() //en teoria recibo la lista de materias menos la misma
        {
            bindingSourceCorrelativasMenosMisma.DataSource = subjectController.getSubject(receivedCareer, receivedSubject); //Sobrecarga para no mostrar misma materia
            bindingSourceCorrelativasMenosMisma.ResetBindings(true);
            cbbCorrelativas.DataSource = bindingSourceCorrelativasMenosMisma;
            cbbCorrelativas.DisplayMember = "NAME";
            cbbCorrelativas.ValueMember = "ID";
        }

        public void RefreshTableCorrelativas() //DATATABLE CORRELATIVAS
        {
            try
            {
                bindingSourceMateriaCorrelativas.DataSource = subjectController.getCorrelativesFromSubject(receivedSubject); //clono una materia y pido su materias correlativas
                bindingSourceMateriaCorrelativas.ResetBindings(true);
                dataGridViewCorrelativas.DataSource = bindingSourceMateriaCorrelativas;
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
                lblmateriaName.Text = (subjectController.getSubject(receivedSubject).NAME);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cbbCorrelativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((subjectController.getCorrelativesFromSubject(receivedSubject).Any()))
            {
                RefreshTableCorrelativas();
            }
        }

        private void btnCorrelativas_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            //subjectController.updateSubject(receivedCareer, receivedSubject, selectedSubject);
            RefreshTableCorrelativas();
        }

        private void btnRemoveCorrelative_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            //subjectController.deleteSubject(receivedCareer, receivedSubject, selectedSubject);
            RefreshTableCorrelativas();
        }
    }
}
