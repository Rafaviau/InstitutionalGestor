using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.Vista
{
    public partial class FormMateria : Form
    {
        ControladoraMateria obj;
        public FormMateria()
        {
            this.obj = ControladoraMateria.GetInstance();
            InitializeComponent();
        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            obj.CreateMateria(Int32.Parse(txtID.Text),txtNombre.Text, Int32.Parse(txtAnioCarrera.Text), Int32.Parse(txtCargaHorariaSemanal.Text), Int32.Parse(txtCargaHorariaTotal.Text));
        }

        private void btnModificar_MouseClick(object sender, MouseEventArgs e)
        {
            //obj.UpdateMateria();
        }

        private void btnBorrar_MouseClick(object sender, MouseEventArgs e)
        {
            obj.DeleteMateria(Convert.ToInt32(this.txtID.Text));
        }
    }
}
