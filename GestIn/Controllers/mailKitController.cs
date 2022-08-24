using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

using GestIn.Model;


namespace GestIn.Controllers
{
    internal class mailKitController
    {
        static mailKitController? Instance;
        string? verificationCode;
        private mailKitController() { }
        public static mailKitController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new mailKitController();
            }
            return Instance;
        }
        public bool sendPasswordRecoverEmail(string RecipientMail)
        {
            generateCode();
            try
            {
                Mail mail = new Mail("testsend1233@outlook.com", "Prueba123456", "smtp-mail.outlook.com", 587);

                InternetAddressList list = new InternetAddressList();
                list.Add(InternetAddress.Parse(RecipientMail));
                BodyBuilder body = new BodyBuilder();
                string cuerpoDelMensaje = "Su codigo para recuperar su contraseña es:\n" + verificationCode;
                body.TextBody = cuerpoDelMensaje;
                if (mail.sendMail("Recuperar contraseña", "GestIn", body, list)) { return true; }
            }
            catch (Exception ex) { }
            return false;
        }
        public bool sendEmail(string encabezado, string subject, string cuerpoDelMensaje, List<string> listRecipientMail)
        {

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
                if (mail.sendMail(encabezado, subject, body, list)) { return true; }
            }
            catch (Exception ex) { }
            return false;
        }
        public void generateCode()
        {
            Guid cod = Guid.NewGuid();
            verificationCode = cod.ToString();
        }
        public bool verifyCode(string cod)
        {
            return cod.Equals(verificationCode);
        }
        public bool changePass(string email, string password)
        {
            using (var db = new Context()) {
                LoginInformation log = db.LoginInformations.Where(u => u.Email == email).FirstOrDefault();
                log.Password = password;
                db.SaveChanges();
                return (log != null);
            }
        }
    }
}
