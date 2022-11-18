using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestIn.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace GestIn.Reports
{
    internal class actaVolante
    {
           string header = @"
            <div style='width:auto; float:left; height:auto;'>
                <h3 style='margin:0px'>Instituto Superior de Formación Técnica N° 194</h3>
            </div>
            <div style='width: auto;float:right;  height:auto;'>
                <h4 style='float:right; margin: 0px;margin-right:10%'>Código: @ExamId</h4>
            </div>
            <h5 style='margin: 2px;margin-right:3%;text-align:right'>Libro: ____Folio: ___</h5>
            ";
            string title = @"
            <div style='width:100%;'>
                <h1 style='text-align: center; padding-top: 0px;'>Acta volante de examen</h1>
            </div>";
            string info = @"
    <div style='height:auto; width:100%;line-height: 1px'>
        <div style='width:auto; float:left;padding-top=10%'>
            <h5>CARRERA: @career</h5>
            <h5>MATERIA: @subject</h5>
            <h5>DOCENTE: @titular</h5>
            <h5>VOCALES: @vowels</h5>
        </div>
        <div style='width: auto;float:right'>
            <h5>AÑO: @yearInCareer</h5>
            <h5>FECHA: @date</h5>
            <h5>LUGAR: @place</h5>
            <h5>MODALIDAD: Examen final</h5>
        </div>
    </div>";
            string table = @"
            <div style='padding:1px;text-align:center;'>
                 <table style='border: 1px solid black; border-collapse: collapse; width:100%'>
                    <tr style='border: 1px solid black;border-collapse: collapse;'>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>N°</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Apellido y nombre</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Dni</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Condición</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Escrito</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Oral</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px'>Nota final</td>
                    </tr>

";
            string sign = @"
                </table>
            </div>
            <div style='text-align:left;width:100%;padding-top: 50px'>
                <div style='width:auto; float:left; height:auto;padding-right: 20px'>
                    <h4 style='display: inline;'>Presidente __________________</h4>
                </div>
                <div style='width:auto; float:left; height:auto;padding-right: 20px'>
                    <h4 style='display: inline;'>Vocal __________________</h4>
                </div>
                <div style='width:auto; float:left; height:auto;'>
                    <h4 style='display: inline;'>Vocal __________________</h4>
                </div>
            </div>";
            string data = @"
            <div style='text-align:center;item-align:center;padding-top: 30px;width:100%'>
                <div style='width:auto; float:right; height:auto;padding-left: 20px;padding-right: 60px'>
                    <h4 style='display: inline;'>Ausentes: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;padding-left: 20px'>
                    <h4 style='display: inline;'>Desaprobados: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;padding-left: 20px'>
                    <h4 style='display: inline;'>Aprobados: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;'>
                    <h4 style='display: inline;'>Total de alumnos: ____</h4>
                </div>



            </div>";
        public void generateActaVolante(string examId, string career, string subject, string titular, string vowels, string yearInCareer, string date, string place)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            header = header.Replace("@ExamId", examId);

            info = info.Replace("@career", career);
            info = info.Replace("@subject", subject);
            info = info.Replace("@titular", titular);
            info = info.Replace("@vowels", vowels);
            info = info.Replace("@yearInCareer", yearInCareer);
            info = info.Replace("@date", date);
            info = info.Replace("@place", place);

            string filas = string.Empty;
            User u1 = new User();
            u1.Dni = 56156165;
            u1.Name = "Pepe";
            u1.LastName = "Argento";
            User u2 = new User();
            u2.Dni = 345345;
            u2.Name = "Marta";
            u2.LastName = "Dias";
            List<User> lista = new List<User>();
            lista.Add(u1);
            lista.Add(u2);
            List<string> ready = new List<string>();
            foreach (User us in lista)
            {
                filas = string.Empty;
                filas += "<tr style='border: 1px solid black;border-collapse: collapse'>>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'>>" + us.Name+" "+us.LastName + "</td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'>>" + us.Dni + "</td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'>>" + "Presencial" + "</td>";
                filas += "</tr style='border: 1px solid black;border-collapse: collapse:5px'>>";
                ready.Add(filas);
            }
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader((header + title + info + table  + sign + data)))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
        void replaceText(string examId) {
            header = header.Replace("@ExamId", examId);
        }
    }
}
