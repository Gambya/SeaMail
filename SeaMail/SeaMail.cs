using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SeaMail
{
    public static class SeaMail
    {
        public static SmtpClient Client { get; set; }
        public static void Send(String host, String user, String password, String from, String to, String subject, String message)
        {
            Client = new SmtpClient();
            Client.Host = host;
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential(user, password);
            Client.Send(from, to, subject, message);
        }

        public static void Send(String host, String user, String password, String from, String[] to, String subject, String message)
        {
            Client = new SmtpClient();
            Client.Host = host;
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential(user, password);

            MailMessage msg = new MailMessage();
            msg.Sender = new MailAddress(from);
            msg.From = new MailAddress(from);
            foreach(String t in to)
            {
                msg.To.Add(t);
            }
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;

            Client.Send(msg);
        }
    }
}
