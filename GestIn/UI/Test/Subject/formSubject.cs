using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Controladora;

namespace GestIn.Vista.Test
{
    public partial class formSubject : Form
    {
        careerController carreraController;
        //ControladoraPersona personaController;
        public formSubject()
        {
            carreraController = careerController.GetInstance();
            InitializeComponent();
        }

        private void formMateria_Load(object sender, EventArgs e)
        {
            NullCheckCarreras();
        }


        public void NullCheckCarreras() //Para que no me paresca errores
        {
            if (carreraController.ReturnListCarreras().Count != 0)
            {
                RefreshCbbCarreras();
                RefreshCbbMateriaSelector();
                RefreshTableMateria();
            }
        }


        public void RefreshTableMateria()
        {
            bindingSourceCarreraMaterias.DataSource = carreraController.MateriasDeUnaCarrera(cbbCarreraSelector.SelectedItem);
            bindingSourceCarreraMaterias.ResetBindings(false);
            dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
        }


        public void RefreshCheckedListCorrelativas(object carrera, object materiaExists) //en teoria recibo la lista de materias menos la misma
        {
            bindingSourceCorrelativasMenosMisma.DataSource = carreraController.MateriasDeUnaCarrera(carrera, materiaExists); //Sobrecarga para no mostrar misma materia
            bindingSourceCorrelativasMenosMisma.ResetBindings(true);
            ((ListBox)checkedListCorrelativas).DataSource = bindingSourceCorrelativasMenosMisma;
            ((ListBox)checkedListCorrelativas).DisplayMember = "NAME";
            ((ListBox)checkedListCorrelativas).ValueMember = "ID";
        }
    
        public void RefreshTableCorrelativas(object carreraSelector,object materiaSelector) //DATATABLE CORRELATIVAS
        {
            try
            {
                bindingSourceMateriaCorrelativas.DataSource = carreraController.GetMateria(carreraSelector,materiaSelector).CORRELATIVES; //clono una materia y pido su materias correlativas
                bindingSourceMateriaCorrelativas.ResetBindings(true);
                dataGridViewCorrelativas.DataSource = bindingSourceMateriaCorrelativas;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshTableCronograma(object materiaSelector)
        {
            try
            {
                bindingSourceMateriaCronograma.DataSource = carreraController.GetMateria(materiaSelector).CRONOGRAM; //clono una materia y pido su cronograma
                bindingSourceMateriaCronograma.ResetBindings(true);
                dataGridViewCronograma.DataSource = bindingSourceMateriaCronograma;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshTableDocente(object materiaSelector)
        {
            try
            {
                bindingSourceMateriaDocentes.DataSource = carreraController.GetMateria(materiaSelector).TEACHERS; //clono una materia y pido su docente
                bindingSourceMateriaDocentes.ResetBindings(true);
                dataGridViewCronograma.DataSource = bindingSourceMateriaDocentes;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshCbbCarreras()
        {
            try
            {
                bindingSourceCarreras.DataSource = carreraController.ReturnListCarreras();
                bindingSourceCarreras.ResetBindings(true);
                cbbCarreraSelector.DataSource = bindingSourceCarreras;
                cbbCarreraSelector.DisplayMember = "NAME";
                cbbCarreraSelector.ValueMember = "ID";
                cbbCarreraSelector.SelectedIndex = 0;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public void RefreshCbbMateriaSelector()
        {
            try
            {
                bindingSourceCarreraMaterias.DataSource = carreraController.MateriasDeUnaCarrera(cbbCarreraSelector.SelectedItem);
                bindingSourceCarreraMaterias.ResetBindings(true);
                cbbMateriaSelector.DataSource = bindingSourceCarreraMaterias;
                cbbMateriaSelector.DisplayMember = "NAME";
                cbbMateriaSelector.ValueMember = "ID";
                cbbMateriaSelector.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public void RefreshCbbDocenteSelector()
        {
            try
            {
                bindingSourceDocentes.ResetBindings(true);
                cbbDocentes.DataSource = bindingSourceDocentes;
                cbbDocentes.DisplayMember = "NAME";
                cbbDocentes.ValueMember = "cuil";
                cbbDocentes.SelectedIndex = 0;

            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object materiaCheck = cbbMateriaSelector.SelectedItem; //Controller Correlativas
            object carreraCheck = cbbCarreraSelector.SelectedItem;
            //txtID.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[2].Value);
            txtAnioCarrera.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
            txtCargaHorariaTotal.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[5].Value);
            RefreshCheckedListCorrelativas(carreraCheck, materiaCheck); //Problema
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            carreraController.CreateMateria(Convert.ToInt32(cbbCarreraSelector.SelectedValue),txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text), carreraController.GetCheckedCorrelativas(checkedListCorrelativas.CheckedItems.Cast<object>().ToList()), cbbCarreraSelector.SelectedItem);
            //MessageBox.Show("This is Checkbox Item" + " " + TestingCheckList());
            RefreshTableMateria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("N/A");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            carreraController.DeleteMateria(cbbMateriaSelector.SelectedItem,cbbCarreraSelector.SelectedItem);
            MessageBox.Show("N/A");
        }


        private void cbbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableMateria();
        }

        public List<string> ListaDias() //creo que es necesario para dict keys
        {
            List<string> listaDias = new List<string>();
            listaDias.Add("Lunes");
            listaDias.Add("Martes");
            listaDias.Add("Miercoles");
            listaDias.Add("Jueves");
            listaDias.Add("Viernes");
            listaDias.Add("Sabado");
            return listaDias;
        }



        private void cbbMateriaSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMateriaSelector.Items.Count > 0)
            { 
                object materiaCheck = cbbMateriaSelector.SelectedItem; //Controller Correlativas
                object carreraCheck = cbbCarreraSelector.SelectedItem;
            
                
                if (carreraController.GetMateria(carreraCheck, materiaCheck).CORRELATIVES.Any()) //Correlativas nulas?
                {
                    RefreshTableCorrelativas(carreraCheck, materiaCheck); //Problema era de aca, mejorar en el futuro
                }

                if (carreraController.GetMateria(carreraCheck, materiaCheck).CRONOGRAM.Any())
                {
                    foreach(string key in ListaDias())
                    {
                        if(carreraController.GetMateria(carreraCheck, materiaCheck).CRONOGRAM.ContainsKey(key))
                        {
                            RefreshTableCronograma(materiaCheck);
                        }
                    }
                }
            }
        }

        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            object materiaCheck = cbbMateriaSelector.SelectedItem; //Controller materia determinada
 

            MessageBox.Show(txtHorarioDesde.Text + " " + cbbDia.Text);

            if (txtHorarioDesde.Text.Length > 0 && cbbDia.Text.Length > 0)
            {
                if (MessageBox.Show("Desea agregar este cronograma a la materia" + " " + materiaCheck.ToString() + " " + "?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    carreraController.GetMateria(materiaCheck).CRONOGRAM.Add(cbbDia.Text, TimeSpan.Parse(txtHorarioDesde.Text));
                    MessageBox.Show(carreraController.GetMateria(materiaCheck).CRONOGRAM.ToString());
                    RefreshTableCronograma(materiaCheck);
                }
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void dataGridViewMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtNombre.Clear();
            txtAnioCarrera.Clear();
            txtCargaHorariaTotal.Clear();
        }

        private void btnGuardarDocente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void bindingSourceMateriaCorrelativas_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCorrelativas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        public List<Materia> FiltrarListMaterias()
        {
            Carrera carreraSelector = (Carrera)cbbCarreras.SelectedItem;

            foreach (Carrera carrera in carreraController.ReturnListCarreras())
            {
                if (carrera.NRORESOLUCION == carreraSelector.NRORESOLUCION)
                {
                    return carrera.LIST_MATERIAS;
                }
            }
            return null;
        }
        

        public Materia FiltrarMateria(int materiaSelector) //Checklist casteando
        {
            Materia objMateria = null;
            foreach (Materia materia in FiltrarListMaterias())
            {
                if (materiaSelector == materia.ID)
                {
                    objMateria = materia;
                }
            }
            return objMateria;
        }
        

        public List<Materia> GetCheckedCorrelativas() //Lista de Correlativas
        {
            List<Materia> correlativasList = new List<Materia>();
            foreach (Materia checkedMateria in checkedListCorrelativas.CheckedItems)
            {
                correlativasList.Add(checkedMateria);
            }
            return correlativasList;
        }
        


        public void CheckListBoxDuplicate(int rowid) //Deshabilita el checkbox de la misma materia 
        {
            int indice = 0;

            if (checkedListCorrelativas.Items.Count > 0)
            {
                for (indice = 0; indice < checkedListCorrelativas.Items.Count; indice++)
                {
                    if (rowid == carreraController.FiltrarMateria(cbbCarreras.SelectedItem, GetThisID(checkedListCorrelativas.Items[indice])).ID)
                    {
                        checkedListCorrelativas.SetItemCheckState(indice, CheckState.Indeterminate);
                    }
                    else if (rowid != carreraController.FiltrarMateria(cbbCarreras.SelectedItem, GetThisID(checkedListCorrelativas.Items[indice])).ID)
                    {
                        checkedListCorrelativas.SetItemCheckState(indice, CheckState.Unchecked);
                    }
                }
            }
        }

        

        public int GetThisID(Materia checkedMateria) //casteando a combobox (no es necesario)
        {
            int idmateria = checkedMateria.ID;
            return idmateria;
        }

        */


        /*
        public int TestingCheckList()
        {
        int returno = 0;
        foreach (object nombreID in checkedListCorrelativas.CheckedItems)
        {
            string thisID = nombreID.ToString();
            if (thisID!=null)
            {
                int indice = thisID.IndexOf(' ');
                indice = thisID.IndexOf(' ', indice);
                int idmateria = Int32.Parse(thisID.Substring(0, indice));
                returno = idmateria;
            }
        }
        return returno;
        }
        */
    }
    }
    
