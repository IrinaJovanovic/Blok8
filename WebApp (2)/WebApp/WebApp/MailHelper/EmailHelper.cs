using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace WebApp.MailHelper
{
    public class EmailHelper
    {
        public static void SendEmail(string to, string subj, string body)
        {
            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient();
            //SmtpServer.Host = "smtp.gmail.com";
            //mail.From = new MailAddress("controlorftnc@gmail.com"); //
            ////mail.Sender = new MailAddress("buy.bus.tickets1@gmail.com");
            //mail.IsBodyHtml = true;
            //mail.To.Add(to);
            //mail.Subject = subj;
            //mail.Body = body;
            //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            //SmtpServer.Port = 587;
            //SmtpServer.UseDefaultCredentials = false;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("irininakuhinjica@gmail.com", " Irina123!");//menjaj
            //SmtpServer.EnableSsl = true;
            //SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            //SmtpServer.Send(mail);

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.uns.ac.rs");
                //SmtpClient SmtpServer = new SmtpClient();

                mail.From = new MailAddress("mldmarko@gmail.com");
                mail.Sender = new MailAddress("mldmarko@gmail.com");
                mail.To.Add(to);
                mail.Subject = subj;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("marko.bujagic", "snjuvalo");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}

