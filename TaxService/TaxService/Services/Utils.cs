using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using TaxService.Models;

namespace TaxService.Services
{
    public static class Utils
    {
        private static TaxServiceEntities db = new TaxServiceEntities();

        public static bool SendEmail(string to, string subject, string body)
        {
            try
            {
                var from = ConfigurationManager.AppSettings.Get("FromMail");
                using (MailMessage mail = new MailMessage(from, to))
                {
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Host = ConfigurationManager.AppSettings.Get("Host");
                        smtp.EnableSsl = true;
                        var username = ConfigurationManager.AppSettings.Get("Username");
                        var password = ConfigurationManager.AppSettings.Get("Password");
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(username, password);
                        int.TryParse(ConfigurationManager.AppSettings.Get("Port"), out int port);
                        smtp.Port = port;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        public static bool SendEmail(string to, string subject, string body, byte[] bytes, string filename)
        {
            try
            {
                var from = ConfigurationManager.AppSettings.Get("FromMail");
                using (MailMessage mail = new MailMessage(from, to))
                {
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    mail.Attachments.Add(new Attachment(new MemoryStream(bytes), filename));
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Host = ConfigurationManager.AppSettings.Get("Host");
                        smtp.EnableSsl = true;
                        var username = ConfigurationManager.AppSettings.Get("Username");
                        var password = ConfigurationManager.AppSettings.Get("Password");
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(username, password);
                        int.TryParse(ConfigurationManager.AppSettings.Get("Port"), out int port);
                        smtp.Port = port;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //return false;
        }


        public static bool SendEmail(string to, string subject, string body, byte[] bytes, byte[] newdata, string mewfilename, string filename)
        {
            try
            {
                var from = ConfigurationManager.AppSettings.Get("FromMail");
                using (MailMessage mail = new MailMessage(from, to))
                {
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    mail.Attachments.Add(new Attachment(new MemoryStream(bytes), filename));
                    mail.Attachments.Add(new Attachment(new MemoryStream(newdata), mewfilename));
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Host = ConfigurationManager.AppSettings.Get("Host");
                        smtp.EnableSsl = true;
                        var username = ConfigurationManager.AppSettings.Get("Username");
                        var password = ConfigurationManager.AppSettings.Get("Password");
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(username, password);
                        int.TryParse(ConfigurationManager.AppSettings.Get("Port"), out int port);
                        smtp.Port = port;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //return false;
        }

        public static bool SendEmail(string to, string subject, string body, byte[] bytes, string filename, HttpFileCollectionBase files)
        {
            try
            {
                var from = ConfigurationManager.AppSettings.Get("FromMail");
                using (MailMessage mail = new MailMessage(from, to))
                {
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    mail.Attachments.Add(new Attachment(new MemoryStream(bytes), filename));
                    for (int i = 0; i < files.Count; i++)
                    {                        
                        HttpPostedFileBase file = files[i];                   
                        if (file != null)
                        {
                            string fileName = Path.GetFileName(file.FileName);
                            mail.Attachments.Add(new Attachment(file.InputStream, fileName));
                        }
                    }
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Host = ConfigurationManager.AppSettings.Get("Host");
                        smtp.EnableSsl = true;
                        var username = ConfigurationManager.AppSettings.Get("Username");
                        var password = ConfigurationManager.AppSettings.Get("Password");
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(username, password);
                        int.TryParse(ConfigurationManager.AppSettings.Get("Port"), out int port);
                        smtp.Port = port;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //return false;
        }


        public static bool IsEmailAvailable(string email, long customerID = 0)
        {
            var customer = db.Customers.Where(s => s.Email == email.Trim()).FirstOrDefault();
            if (customer == null)
            {
                return true;
            }
            return customer.CustomerID == customerID;

        }

        public static string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }
    }
}
