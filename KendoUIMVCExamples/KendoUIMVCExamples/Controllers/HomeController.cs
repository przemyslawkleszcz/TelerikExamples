using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIMVCExamples.Models;

namespace KendoUIMVCExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Telerik Kendo UI MVC Examples";
            return View();
        }

        public ActionResult ServerBinding()
        {
            ViewBag.Message = "Server binding";
            var model = ModelDataProducer.PrepareModel<ServerBindingModel, ServerBindingData>();
            return View(model);
        }

        public ActionResult AjaxBinding()
        {
            ViewBag.Message = "Ajax binding";
            return View();
        }

        public ActionResult Index_Read([DataSourceRequest] DataSourceRequest request)
        {
            var model = ModelDataProducer.PrepareIndexModel();
            return Json(model.Data.ToDataSourceResult(request));
        }

        public ActionResult AjaxBinding_Read([DataSourceRequest] DataSourceRequest request)
        {
            var model = ModelDataProducer.PrepareModel<AjaxBindingModel, AjaxBindingData>();
            return Json(model.Data.ToDataSourceResult(request));
        }
    }
}
