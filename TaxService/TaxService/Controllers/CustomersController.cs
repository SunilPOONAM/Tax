using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TaxService.Models;
using TaxService.Services;

namespace TaxService.Controllers
{
    [AuthorizationFilter]
    public class CustomersController : Controller
    {
        private TaxServiceEntities db = new TaxServiceEntities();


        public ActionResult Index()
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            if (Convert.ToInt32(Session["RoleId"]) == 1)
                return View(db.Customers.ToList());
            else
                return View(db.Customers.Where(m => m.CreatedBy== userId).ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        public ActionResult Create()
        {
            return View(new CustomerModel());
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Email")] CustomerModel customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    customer.CreatedBy = Convert.ToInt32(Session["UserID"]);
                    db.Customers.Add(customer.GetNewCustomer());
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View(customer);
        }

        public JsonResult IsEmailAvailable([Bind(Prefix = "Email")] string email, [Bind(Prefix = "CustomerID")] long customerID = 0)
        {
            return Json(Utils.IsEmailAvailable(email, customerID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(new CustomerModel(customer));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CustomerCode,Name,Email,CreatedDate,CreatedBy")] CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = model.UpdateCustomer();
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GenerateLink(Customer objModelMail, int id, Guid guid)
        {
            var url = Url.Action("Index", "Home", new { custid = id, guid = guid }, Request.Url.Scheme);
            var subject = "Form Link";
            var body = "<br/><br/>Hi " + objModelMail.Name + "" + "<br/>You are invited to fill Tax form by clicking on the following link" + " <br/><br/><a href='" + url + "'>Click here</a>" +
                        "<br/><br/>Regards" +
                        "<br/> Nylnc Tax Service" +
                        "<br/>";
            var send = Utils.SendEmail(objModelMail.Email, subject, body);
            if (send)
            {
                ViewBag.Message = "Sent";
                TempData["Message"] = "Sent successfully ";
            }
            else
            {
                ViewBag.Message = "Not Sent";
                TempData["Message"] = "Error in sending email";
            }
            return RedirectToAction("Dashboard", "Admin");

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
