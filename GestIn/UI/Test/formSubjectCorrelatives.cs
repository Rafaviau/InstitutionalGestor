using GestIn.Controladora;
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
        object receivedCareer;
        object receivedSubject;
        public formSubjectCorrelatives(object sentCareer,object sentSubject)
        {
            receivedCareer = sentCareer;
            receivedSubject = sentSubject;
            carreraController = careerController.GetInstance();
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
            bindingSourceCorrelativasMenosMisma.DataSource = carreraController.MateriasDeUnaCarrera(receivedCareer, receivedSubject); //Sobrecarga para no mostrar misma materia
            bindingSourceCorrelativasMenosMisma.ResetBindings(true);
            cbbCorrelativas.DataSource = bindingSourceCorrelativasMenosMisma;
            cbbCorrelativas.DisplayMember = "NAME";
            cbbCorrelativas.ValueMember = "ID";
        }

        public void RefreshTableCorrelativas() //DATATABLE CORRELATIVAS
        {
            try
            {
                bindingSourceMateriaCorrelativas.DataSource = carreraController.GetMateria(receivedCareer, receivedSubject).CORRELATIVES; //clono una materia y pido su materias correlativas
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
                lblmateriaName.Text = (carreraController.GetMateria(receivedSubject).NAME);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void cbbCorrelativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((carreraController.GetMateria(receivedSubject).CORRELATIVES).Any())
            {
                RefreshTableCorrelativas();
            }
        }

        private void btnCorrelativas_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            carreraController.UpdateMateria(receivedCareer, receivedSubject, selectedSubject);
            RefreshTableCorrelativas();
        }

        private void btnRemoveCorrelative_MouseClick(object sender, MouseEventArgs e)
        {
            object selectedSubject = cbbCorrelativas.SelectedItem;
            carreraController.DeleteMateria(receivedCareer, receivedSubject, selectedSubject);
            RefreshTableCorrelativas();
        }
    }
}
