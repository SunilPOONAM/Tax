using System;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using TaxService.Models;
using System.Data.Entity;
using System.Net;
using TaxService.Services;
using System.Collections.Generic;

namespace TaxService.Controllers
{
    public class AdminController : Controller
    {
        TaxServiceEntities db = new TaxServiceEntities();

        [HandleError]
        public ActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User objUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var obj = db.Users.Where(a => a.Username.Equals(objUser.Username) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["RoleID"] = obj.RoleId;
                        Session["UserID"] = obj.UserID.ToString();
                        Session["UserName"] = obj.Username.ToString();
                        Session["AppSecurityKey"] = ConfigurationManager.AppSettings.Get("AppSecurityKey");
                        return RedirectToAction("Home");
                    }
                    else
                    {
                        TempData["Invalid"] = "Invalid username or password !";
                        ModelState.Clear();
                    }
                }
                catch { }
            }
            ModelState.Clear();
            return View(objUser);
        }

        [AuthorizationFilter]
        public ActionResult Home()
        {
            try
            {
                List<Customer> customers;
                var userID = Convert.ToInt32(Session["UserID"]);
                if (Convert.ToInt32(Session["RoleId"]) == 1)
                    customers = db.Customers.ToList();
                else
                    customers = db.Customers.Where(m => m.CreatedBy == userID).ToList();

                
                var count = customers != null ? customers.Count() : 0;
                ViewBag.NOC = count;
            }
            catch { }
            return View();
        }

        [AuthorizationFilter]
        public ActionResult Logout()
        {

            Session.Abandon();
            return RedirectToAction("Index", "Admin");
        }

        [AuthorizationFilter]
        public ActionResult AdminIndex()
        {
            var users = (from u in db.Users
                         join r in db.UserRoles on u.RoleId equals r.Id
                         where u.RoleId!=1
                         select new AdminModel
                         {
                             UserID = u.UserID,
                             Username = u.Username,
                             Role = r.Role,
                            
                         }).ToList();

          
               // users = users.Where(r => r.RoleId != 1).ToList();
          
            return View(users);
        }

        // start
        [AuthorizationFilter]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [AuthorizationFilter]
        public ActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,Password,ConfirmPassword")] AdminModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (user.Username != null && user.Password != null)
                    {
                        db.Users.Add(user.GetNewUser());
                        db.SaveChanges();
                        return RedirectToAction("AdminIndex");
                    }
                }
            }
            catch { }
            return View(user);
        }

        [AuthorizationFilter]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(new AdminModel(user));
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Username")] AdminModel model)
      {

            if (!string.IsNullOrEmpty(model.Username))
            {
                var user = db.Users.Find(model.UserID);
                user.Username = model.Username;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(model);
        }

        [AuthorizationFilter]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("AdminIndex");
        }



        [AuthorizationFilter]
        public ActionResult Change_Password(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(new ChangePasswordModel(user));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Change_Password([Bind(Include = "UserID,NewPassword,ConfirmPassword")] ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.Find(model.UserID);
                user.Password = model.NewPassword;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AdminIndex");
            }
            return View(model);
           
        }


    }
}