using DevExpress.Web.Demos.Mvc;
using System.Linq;
using System.Web.Mvc;
using WENCO.Code.Helpers;

namespace WENCO.Controllers
{
    public partial class CustomizationController : BaseWencoController
    {
        WENCO.Models.BDWENCOEntities2 db = new WENCO.Models.BDWENCOEntities2();
        public ActionResult Toolbar()
        {
            var model = db.dk_users;
            return DemoView("Toolbar", model.ToList());
        }
        public ActionResult ToolbarPartial()
        {
            var model = db.dk_users;
            return PartialView("ToolbarPartial", model.ToList());
        }

        [ValidateInput(false)]
        public ActionResult ToolbarAddNewPartial(EditableProduct product)
        {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.InsertProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return ToolbarPartial();
        }
        [ValidateInput(false)]
        public ActionResult ToolbarUpdatePartial(EditableProduct product)
        {
            if (ModelState.IsValid)
                SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ToolbarPartial();
        }
        [ValidateInput(false)]
        public ActionResult ToolbarDeletePartial(int productID = -1)
        {
            if (productID >= 0)
                SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
            return ToolbarPartial();
        }

        public ActionResult ExportTo(string customExportCommand)
        {
            switch (customExportCommand)
            {
                case "CustomExportToXLS":
                case "CustomExportToXLSX":
                    return GridViewExportDemoHelper.ExportFormatsInfo[customExportCommand](
                        GridViewToolbarHelper.ExportGridSettings, NorthwindDataProvider.GetEditableProducts());
                default:
                    return RedirectToAction("Toolbar");
            }
        }
    }
}