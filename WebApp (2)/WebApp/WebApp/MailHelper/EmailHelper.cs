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
          
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.uns.ac.rs");
              

                mail.From = new MailAddress("control@gmail.com");
                mail.Sender = new MailAddress("control@gmail.com");
                mail.To.Add("alek.jagodic@gmail.com");
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

