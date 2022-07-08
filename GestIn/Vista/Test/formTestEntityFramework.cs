using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Model;

namespace GestIn.Vista.Test
{
    public partial class formTestEntityFramework : Form
    {
        public formTestEntityFramework()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = new List<Usuario>();
            using (var context = new Context())
            {
                foreach (var item in context.Usuarios.ToList()) {
                    lista.Add(item);
                }
            }
            MessageBox.Show(lista.Count.ToString());
        }
    }
}
