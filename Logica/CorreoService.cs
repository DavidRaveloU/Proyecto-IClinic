using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public class CorreoService
    {
        private MailMessage email;
        private SmtpClient smtp;
        public CorreoService()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("iclinic944@gmail.com",
             "prueba123");
        }

        private void ConfigurarEmail(Paciente paciente)
        {
            email = new MailMessage();
            email.To.Add(paciente.CorreoElectronico);
            email.From = new MailAddress("iclinic944@gmail.com");
            email.Subject = "Registro de Usuario "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {paciente.PrimerNombre}</b> <br " +
                $" > se ha realizado su registro a Iclinic Sartisfactoriamente, gracias por contar con nosotros";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

        }
        public string EnviarEmail(Paciente paciente)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(paciente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }

        }

    }
}
