using LoginApp.Models;
using LoginApp.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(AppUserModel user)
        {
            if (ModelState.IsValid)
            {
                var appService = new LoginAppService();

                var result = await appService.GetIsLoginValid(user);
                
                if (result)
                {
                    ViewBag.Message = "Success";
                }
                else
                {
                    ViewBag.Message = "Invalid Login";
                }
            }

            return View();

        }

    }
}