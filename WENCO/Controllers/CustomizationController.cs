using System;
using System.Web.Mvc;

namespace WENCO.Controllers
{
    public partial class CustomizationController : BaseWencoController
    {
        public override string Name { get { return "Customization"; } }

        public ActionResult Index()
        {
            return RedirectToAction("Toolbar");
        }

        public void SafeExecute(Action method)
        {
            try
            {
                method();
            }
            catch (Exception e)
            {
                ViewData["EditError"] = e.Message;
            }
        }
    }
}