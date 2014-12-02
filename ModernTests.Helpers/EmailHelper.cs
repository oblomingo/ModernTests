using System;
using System.Net;
using System.Net.Mail;

namespace ModernTests.Helpers
{
    public static class EmailHelper
    {
        static MailAddress fromAddress = new MailAddress("oblomingo@gmail.com", "From Name");
        const string fromPassword = "otvratitelno";


        public static bool SendEmail(string toAddress, string subject, string body)
        {
            var toMailAddress = new MailAddress(toAddress);
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toMailAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}
