using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace TurStok.Helper
{
    public class MailClass
    {
        public MailClass()
        {
        }
        public bool MailGonder(string to, string subject, string body)
        {
            try
            {
                #region calısıyor
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.Subject = subject;
                message.From = new MailAddress("turstok@gmail.com");
                message.Body = body;
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                smtp.Credentials = new System.Net.NetworkCredential("turstok@gmail.com", "tur123stok");
                smtp.Send(message);
                #endregion
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MailGonder(string to, string subject, string body, byte[] dosya, string DosyaAdi)
        {
            try
            {
                #region Deneme
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.Subject = subject;
                message.From = new MailAddress("turstok@gmail.com");
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                message.Attachments.Add(new System.Net.Mail.Attachment(new MemoryStream(dosya), DosyaAdi));
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("turstok@gmail.com", "tur123stok");
                smtp.Send(message);
                #endregion
              
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MailGonder(string to, string subject, string body, Dictionary<string, byte[]> Dosyalar)
        {
            try
            {
                #region DenemeCalisiyor
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.Subject = subject;
                message.From = new MailAddress("turstok@gmail.com");
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                foreach (string item in Dosyalar.Keys)
                {
                    message.Attachments.Add(new System.Net.Mail.Attachment(new MemoryStream(Dosyalar[item]), item));
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("turstok@gmail.com", "tur123stok");

                smtp.Send(message);
                #endregion
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool MailGonder(string to, string subject, string body, string CC)
        {
            try
            {
                #region DenemeCalisiyor
                MailMessage message = new MailMessage();
                message.To.Add(to);
                // message.CC.Add(CC);
                message.Subject = subject;
                message.From = new MailAddress("turstok@gmail.com");
                message.Body = body;
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("turstok@gmail.com", "tur123stok");

                smtp.Send(message);
                #endregion
               
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
