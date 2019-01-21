using System;
using System.Net.Mail;


namespace TEST
{

    internal class Example
    {
        private static void Main(string[] args)
        {
            SmtpClient smtpClient = new SmtpClient();

            MailMessage message = new MailMessage();
            message.To.Add("martintaylorsoegaard@gmail.com");
            message.Subject = "TEST";
            message.Body = "TESTTESTTEST";
            smtpClient.Send(message);


      
        }
    }
}
