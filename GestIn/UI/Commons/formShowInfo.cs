using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Commons
{
    public partial class formShowInfo : Form
    {
        public formShowInfo(string texto, Image img)
        {
            InitializeComponent();
            lblText.Text = texto;
            pictureBox1.Image = img;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
