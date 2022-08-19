using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using GestIn.DAO;

namespace GestIn.Controladora
{
    internal class ControladoraMailKit 
    {
        daoAlumnos daoAlumnos = new daoAlumnos();
        static ControladoraMailKit? Instance;
        string? codigoVerificacion;
        private ControladoraMailKit(){}
        public static ControladoraMailKit GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControladoraMailKit();
            }
            return Instance;
        }
        public bool enviarRecuperarPassword(string RecipientMail)
        {
            generarcodigo();
            try
            {
                Mail mail = new Mail("testsend1233@outlook.com", "Prueba123456", "smtp-mail.outlook.com", 587);

                InternetAddressList list = new InternetAddressList();
                list.Add(InternetAddress.Parse(RecipientMail));
                BodyBuilder body = new BodyBuilder();
                string cuerpoDelMensaje = "Su codigo para recuperar su contraseña es:\n" + codigoVerificacion; 
                body.TextBody = cuerpoDelMensaje;
                if (mail.sendMail("Recuperar contraseña", "GestIn", body, list)) { return true; }
            }
            catch (Exception ex) { }
            return false;
        }
        public bool enviarEmail(string encabezado,string subject,string cuerpoDelMensaje,List<string>listRecipientMail) {

            try
            {
                Mail mail = new Mail("testsend1233@outlook.com", "Prueba123456", "smtp-mail.outlook.com", 587);

                InternetAddressList list = new InternetAddressList();
                foreach (string email in listRecipientMail)
                {
                    list.Add(InternetAddress.Parse(email));
                }
                BodyBuilder body = new BodyBuilder();
                body.TextBody = cuerpoDelMensaje;
                if (mail.sendMail(encabezado, subject, body, list)) {return true; }
            }
            catch (Exception ex) { }
            return false;
        }
        public void generarcodigo()
        {
            Guid cod = Guid.NewGuid();
            codigoVerificacion = cod.ToString();
        }
        public bool verificarCodigo(string cod) {
            return cod.Equals(codigoVerificacion);
        }
        public bool cambiarPassword(string email, string password) {
            return daoAlumnos.changePassword(email, password);
        }
    }
}
