using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TaxService.Models;
using TaxService.Services;

namespace TaxService.Controllers
{
    public class HomeController : LanguageBase
    {
        TaxServiceEntities db = new TaxServiceEntities();
        public ActionResult Index(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                {
                    return RedirectToAction("NotAuthorzied", "Error");
                }
                var guid = new Guid(id);
                Customer customer = db.Customers.Where(c => c.CustomerCode == guid).FirstOrDefault();
                if (customer == null)
                {
                    return RedirectToAction("NotAuthorzied", "Error");
                }
                var model = new TaxModel
                {
                    CustomerEmail = customer.Email,
                    CustomerCode = customer.CustomerCode
                };
                return View(model);
            }
            catch
            {
                return RedirectToAction("NotAuthorzied", "Error");
            }
        }

        [HttpPost]
        public ActionResult ChangeLanguage(TaxModel model)
        {
            try
            {
                new LanguageModel().SetLanguage(model.Language);
                return RedirectToAction("Index", "Home", new { id = model.CustomerCode });
            }
            catch
            {
                return RedirectToAction("NotAuthorzied", "Error");
            }
        }

        [HttpPost]
        public ActionResult SendFile(string customerEmail, string chunks, string jsondata)
        {
            try
            {
                HttpFileCollectionBase files = Request.Files;
                byte[] data = Convert.FromBase64String(chunks);
                var send = Utils.SendEmail(customerEmail, "Tax Form", GetEmailContent(), data, "TaxForm.pdf", files);
                if (send)
                {
                    return Json("success");
                }
            }
            catch { }
            return Json("error");
        }

        private string GetEmailContent()
        {
            string body = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(Server.MapPath("~/Content/templates/EmailContent.html")))
                {
                    body = reader.ReadToEnd();
                }
                body = body.Replace("{DateSubmitted}", DateTime.Now.ToString("dd MMM yyyy"));
                body = body.Replace("{TimeSubmitted}", DateTime.Now.ToString("hh:mm tt"));
                body = body.Replace("{IPAddress}", Utils.GetIPAddress());
            }
            catch { }
            return body;
        }

    }
}
