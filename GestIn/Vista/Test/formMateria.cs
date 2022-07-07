using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Modelo.Clases;
using GestIn.Controladora;

namespace GestIn.Vista.Test
{
    public partial class formMateria : Form
    {
        //ControladoraMateria MateriaController;
        ControladoraCarrera carreraController;

        public formMateria()
        {
            this.carreraController = ControladoraCarrera.GetInstance();
            InitializeComponent();
            RefreshCbbCarreras(); //SIEMPRE VA DESPUES DE INITIALIZECOMPONENT()
            RefreshCbbMateriaSelector();
            RefreshTableMateria();
            RefreshCheckedListMaterias();
        }

        private void formMateria_Load(object sender, EventArgs e)
        {
            RefreshCbbCarreras();
            RefreshCbbMateriaSelector();
            RefreshTableMateria();
        }

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

            if (checkedListCorrelativas.Items.Count >= 0)
            {
                //foreach (Materia itemsList in checkedListCorrelativas.Items)
                for (indice = 0; indice < checkedListCorrelativas.Items.Count; indice++)
                {
                    //MessageBox.Show(checkedListCorrelativas.Items[i].ToString());
                    if (rowid == FiltrarMateria(GetThisID((Materia)checkedListCorrelativas.Items[indice])).ID)
                    {
                        checkedListCorrelativas.SetItemCheckState(indice, CheckState.Indeterminate);
                    }
                    else if (rowid != FiltrarMateria(GetThisID((Materia)checkedListCorrelativas.Items[indice])).ID)
                    {
                        //RefreshCheckedListMaterias();
                        checkedListCorrelativas.SetItemCheckState(indice, CheckState.Unchecked);
                    }
                }
            }
        }

        public int GetThisID(Materia checkedMateria) //casteando a combobox (no es necesario)
        {
            //int indice = checkedMateria.IndexOf(' ');
            //indice = checkedMateria.IndexOf(' ', indice);
            //int idmateria = Int32.Parse(checkedMateria.Substring(0, indice));
            int idmateria = checkedMateria.ID;
            return idmateria;
        }

        public void RefreshTableMateria()
        {
            bindingSourceCarreraMaterias.DataSource = FiltrarListMaterias();
            bindingSourceCarreraMaterias.ResetBindings(false);
            dataGridViewMaterias.DataSource = bindingSourceCarreraMaterias;
        }


        public void RefreshCheckedListMaterias()
        {
            bindingSourceCarreraMaterias.DataSource = FiltrarListMaterias();
            bindingSourceCarreraMaterias.ResetBindings(true);
            ((ListBox)checkedListCorrelativas).DataSource = bindingSourceCarreraMaterias;
            ((ListBox)checkedListCorrelativas).DisplayMember = "NOMBRE";
            ((ListBox)checkedListCorrelativas).ValueMember = "Id";
            /*
            foreach (Materia materia in FiltrarListMaterias())
            {
                checkedListCorrelativas.Items.Add(materia.ID + " " + materia.NOMBRE);
            }
            */
            //checkedListCorrelativas.Items.AddRange(FiltrarListMaterias().ToArray());
        }

        public void RefreshTableCorrelativas(Materia materiaSelector)
        {
            try
            {
                bindingSourceMateriaCorrelativas.DataSource = materiaSelector.CORRELATIVAS; //clono una materia y pido su materias correlativas
                bindingSourceMateriaCorrelativas.ResetBindings(true);
                dataGridViewCorrelativas.DataSource = bindingSourceMateriaCorrelativas;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void RefreshTableCronograma(Materia materiaSelector)
        {
            try
            {
                bindingSourceMateriaCronograma.DataSource = materiaSelector.CRONOGRAMA; //clono una materia y pido su cronograma
                bindingSourceMateriaCronograma.ResetBindings(true);
                dataGridViewCronograma.DataSource = bindingSourceMateriaCronograma;
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
                cbbCarreras.DataSource = bindingSourceCarreras;
                cbbCarreras.DisplayMember = "NOMBRE";
                cbbCarreras.ValueMember = "NRORESOLUCION";
                cbbCarreras.SelectedIndex = 0;

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
                bindingSourceCarreraMaterias.DataSource = FiltrarListMaterias();
                bindingSourceCarreraMaterias.ResetBindings(true);
                cbbMateriaSelector.DataSource = bindingSourceCarreraMaterias;
                cbbMateriaSelector.DisplayMember = "NOMBRE";
                cbbMateriaSelector.ValueMember = "ID";
                cbbMateriaSelector.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }



        private void dataGridViewMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[1].Value);
            txtAnioCarrera.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[3].Value);
            txtCargaHorariaTotal.Text = Convert.ToString(dataGridViewMaterias.CurrentRow.Cells[4].Value);
            CheckListBoxDuplicate(Convert.ToInt32(txtID.Text)); //CheckListBox
            //(Carrera)cbbCarreras.SelectedItem);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            carreraController.CreateMateria(Int32.Parse(txtID.Text), txtNombre.Text, GetCheckedCorrelativas(), Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaTotal.Text), (Carrera)cbbCarreras.SelectedItem);
            //MessageBox.Show("This is Checkbox Item" + " " + TestingCheckList());
            RefreshTableMateria();

            //DataCarreras.DataSource = carreraController.ReturnListCarreras();
            //dataGridViewCarreras.DataSource = DataCarreras.DataSource;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mauro no toques");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            carreraController.DeleteMateria((Materia)cbbMateriaSelector.SelectedItem,(Carrera)cbbCarreras.SelectedItem);
            MessageBox.Show("Mauro no toques");
        }



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
            Materia materiaCheck = (Materia)cbbMateriaSelector.SelectedItem;
            string emptykey = "";
            RefreshTableCorrelativas(materiaCheck);

            if (materiaCheck.CORRELATIVAS!=null)
            {
                MessageBox.Show(Convert.ToString(materiaCheck.CORRELATIVAS.Count) + " " + "Correlativas");
            }

            if (materiaCheck.CRONOGRAMA.Any())
            {
                foreach(string key in ListaDias())
                {
                    if(materiaCheck.CRONOGRAMA.ContainsKey(key))
                    {
                        RefreshTableCronograma(materiaCheck);
                    }
                }
                MessageBox.Show(Convert.ToString(materiaCheck.CRONOGRAMA.Count) + " " + "Cronogramas");
            }
        }

        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {

            Materia materiaCheck = (Materia)cbbMateriaSelector.SelectedItem;

            MessageBox.Show((txtHorarioDesde.Text + " " + cbbDia.Text));

            if (txtHorarioDesde.Text.Length > 0 && cbbDia.Text.Length > 0)
            {
                if (MessageBox.Show("Desea agregar este cronograma a la materia" + " " + materiaCheck.NOMBRE + " " + "?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    materiaCheck.CRONOGRAMA.Add(cbbDia.Text, TimeSpan.Parse(txtHorarioDesde.Text));
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }else
            {
                MessageBox.Show("Mauro no touch");
            }
        }

        private void dataGridViewMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtAnioCarrera.Clear();
            txtCargaHorariaTotal.Clear();
        }
    }
}
    
