using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GestIn.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using GestIn.Reports;

namespace GestIn
{
    public partial class pdfTest : Form
    {
        actaVolante av = new actaVolante();
        public pdfTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            av.generateActaVolante("123","Pasteleria","Ciencias de las tortas II","Carlos Menem","Los redonditos de ricota y tu hermana xd xd","2 año",DateTime.Today.ToString("dd/MM/yyyy"),"Narnia");
        }
    }
}
