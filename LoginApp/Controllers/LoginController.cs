using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        private UserDBContextEntities db = new UserDBContextEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var obj = db.Users.Where(a => a.Name.Equals(user.Name) && a.Password.Equals(user.Password)).FirstOrDefault();
                if (obj != null)
                {
                    Session["UserID"] = obj.Id.ToString();
                    Session["UserName"] = obj.Name.ToString();
                    return RedirectToAction("Index", "Users" );
                }

            }
            return View();

        }

    }
}