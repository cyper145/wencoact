using System;
using System.Web.Mvc;
using WENCO.Model;

namespace WENCO.Controllers
{
    public class AccountController : BaseController
    {

        WENCO.Models.BDWENCOEntities2 db = new WENCO.Models.BDWENCOEntities2();
        // GET: /Account/SignIn
        [AllowAnonymous]
        public ActionResult SignIn(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new SignInViewModel() { RememberMe = true });
        }

        // POST: /Account/SignIn
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(SignInViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // DXCOMMENT: You Authentication logic
            if (AuthHelper.SignIn(model.UserName, model.Password))
                return RedirectToAction("Index", "Home");
            else
            {
                SetErrorText("Invalid login attempt.");
                ModelState.AddModelError("", ViewBag.GeneralError);
                return View(model);
            }
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost, ValidateInput(false)]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                WENCO.Models.dk_users user = new Models.dk_users();
                user.username = model.UserName;
                user.name = model.UserName;
                user.firstname = model.FirstName;
                user.address = model.Address;
                user.lastname = model.LastName;
                user.email = model.Email;
                user.password = AuthHelper.Encriptar(model.Password);
                user.phone1 = model.phone1;
                user.phone2 = model.phone2;
                user.photo = "ddd";// falta 
                user.updated_at = DateTime.Now;
                user.created_at = DateTime.Now;
                user.id = AuthHelper.generateID();
                user.last_login = DateTime.Now;
                user.date_of_birth = model.date_of_birth;
                user.isactive = 1;
                var models = db.dk_users;
                if (ModelState.IsValid)
                {
                    try
                    {
                        models.Add(user);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                    catch (Exception e)
                    {
                        ViewData["EditError"] = e.Message;
                    }
                }
                else
                    ViewData["EditError"] = "Please, correct all errors.";
            }

            return View(model);
        }

        // POST: /Account/SignOut
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignOut()
        {
            AuthHelper.SignOut(); // DXCOMMENT: Your Signing out logic
            return RedirectToAction("Index", "Home");
        }

        public ActionResult UserMenuItemPartial()
        {
            return PartialView("UserMenuItemPartial", AuthHelper.GetLoggedInUserInfo());
        }
    }
}