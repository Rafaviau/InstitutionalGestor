using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GestIn.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using GestIn.Controllers;

namespace GestIn.Reports
{
    internal class generatorActaVolante
    {
        examEnrolmentController cntExamEnrol = examEnrolmentController.GetInstance();
        subjectEnrolmentController cntSubEnrol = subjectEnrolmentController.GetInstance();
        examController cntExam = examController.GetInstance();
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
    <div style='height:auto; width:100%'>
        <div style='width:auto; float:left;padding-top=10%'>
            <h5>CARRERA: @career</h5>
            <h5>MATERIA: @subject</h5>
            <h5>DOCENTE: @titular</h5>
            <h5>VOCALES: @vowels</h5>
        </div>
        <div style='width: auto;float:right'>
            <h5>AÑO: @yearInCareer° año</h5>
            <h5>FECHA: @date</h5>
            <h5>LUGAR: @place</h5>
            <h5>MODALIDAD: Examen final</h5>
        </div>
    </div>";
        string table = @"
            <div style='padding:1px;'>
                 <table style='border: 1px solid black; border-collapse: collapse; width:100%'>
                    <tr style='border: 1px solid black;border-collapse: collapse;'>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>N°</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Apellido y nombre</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Dni</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Condición</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Escrito</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Oral</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Nota final</td>
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
        List<Student> Presentials = new List<Student>();
        List<Student> free = new List<Student>();

        public void getActaVolante(int examId)
        {
            Exam exam = cntExam.findExam(examId);
            foreach (Student us in cntExamEnrol.getEnroledStudent(exam.Id)) {
                if (cntSubEnrol.getAcreditationType(us.User.Dni, exam.IdSubject) != "Presencial")
                {
                    free.Add(us);
                }
                else {
                    Presentials.Add(us);
                }
            }
            if(Presentials.Count > 0)
                generate(exam,Presentials,"Presencial");
            if (free.Count > 0)
                generate(exam,free,"Libres");
        }
        void generate(Exam _exam,List<Student> stds,string accType)
        {
            string name = accType.ToUpper() + "-" +
                        _exam.IdSubjectNavigation.Career.Name + "-" +
                        _exam.IdSubjectNavigation.Name + "-" +
                        _exam.Date.ToString("dd-MM-yyyy");
            name = name.Replace(" ", "");
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", name);

            string header_ = header.Replace("@ExamId", _exam.Id.ToString());

            string info_ = info.Replace("@career", _exam.IdSubjectNavigation.Career.Name);
            info_ = info.Replace("@subject", _exam.IdSubjectNavigation.Name);
            info_ = info.Replace("@titular", _exam.TitularNavigation?.User.fullName());
            info_ = info.Replace("@vowels", _exam.FirstVowelNavigation?.User.fullName() + " " +
                                           _exam.SecondVowelNavigation?.User.fullName() + " " +
                                           _exam.ThirdVowelNavigation?.User.fullName());
            info_ = info.Replace("@yearInCareer", _exam.IdSubjectNavigation.YearInCareer.ToString());
            info_ = info.Replace("@date", _exam.Date.ToString("dd/MM/yyyy"));
            info_ = info.Replace("@place", _exam.Place);

            string filas = string.Empty;
            int i = 0;
            foreach (Student us in stds)
            {
                filas += "<tr style='border: 1px solid black;border-collapse: collapse;'>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + i + "</p></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + us.User.LastName + ", " + us.User.Name + "</p></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin:2px;'>" + us.User.Dni + "</p></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse;'><p style='margin-top:20px;'>" + accType + "</p></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
                filas += "<td style='border: 1px solid black;border-collapse: collapse'></td>";
                filas += "</tr>";
                i++;
            }
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(header_ + title + info_ + table + filas + sign + data))
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
