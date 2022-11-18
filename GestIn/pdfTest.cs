using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Reports.ActaVolante;
using System.IO;
using GestIn.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace GestIn
{
    public partial class pdfTest : Form
    {
        generatorActaVolante gActaVolante = generatorActaVolante.GetInstance();
        public pdfTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));


            string b = @"
      <h3>Instituto Superior de Formación Técnica N° 194</h3>
      <h4 style='text-align:right; margin: 2px;'>Código: 675433</h4>
      <h1 style='text-align: center; margin: 2px;'>Acta volante de examen</h1>
      <h5 style='display: inline-block;margin: 2px;'>Libro: ____</h5><h5 style='display: inline-block;margin: 2px;'>Folio: ____</h5>
    <br>
    <hr>";
            string c = @"<section style='width: 49%;display: inline-block;text-align: left;'>
      <h5>CARRERA: Tecnicatura Superior en análisis desarrollo y programación de aplicaciones</h5>
      <h5>MATERIA: Análisis de sistemas</h5>      
      <h5>DOCENTE: Gómez Mauro</h5>
      <h5>VOCALES: Santini Esteban</h5>
    </section>";
            string d = @"<section class='info'>
      <h5>AÑO: 2do</h5>
      <h5>FECHA: 19/12/22</h5>
      <h5>LUGAR: Aula 8</h5>
      <h5>MODALIDAD: Examen final</h5>
    </section>";
            string ee = @"<table style='border: 1px solid;'>
      <tr>
        <td>N</td>
        <td>Apellido y nombre</td>
        <td>Dni</td>
        <td>Condición</td>
        <td>Escrito</td>
        <td>Oral</td>
        <td>Nota final</td>
      </tr><hr>     
    </table>";
            string f = @"    <h4>Presidente _________</h4>
    <h4>Vocal _________</h4>
    <h4>Vocal _________</h4>
    <br>
    <h4>Total de alumnos: _______</h4>
    <h4>Aprobados: _______</h4>
    <h4>Desaprobados: _______</h4>
    <h4>Ausentes: _______</h4>";

            //string PaginaHTML_Texto = Properties.Resources.actaVolante.ToString();

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader((b+c+d+ee+f)))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
    }
}
