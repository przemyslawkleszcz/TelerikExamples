using System.Collections.Generic;
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

        public ActionResult ClientTemplate()
        {
            ViewBag.Message = "Client template";
            return View();
        }

        public ActionResult ServerTemplate()
        {
            ViewBag.Message = "Server template";
            var model = ModelDataProducer.PrepareModel<ServerTemplateModel, ServerTemplateData>();
            return View(model);
        }

        public ActionResult TreeListCellColorChange()
        {
            ViewBag.Message = "Tree list color change";
            return View();
        }

        public ActionResult DisplayFormatAttribute()
        {
            ViewBag.Message = "Display format attribute";
            var model = new DisplayFormatAttributeModel();
            return View(model);
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

        public ActionResult ClientTemplate_Read([DataSourceRequest] DataSourceRequest request)
        {
            var model = ModelDataProducer.PrepareModel<ClientTemplateModel, ClientTemplateData>();
            return Json(model.Data.ToDataSourceResult(request));
        }

        public ActionResult TreeList_Read([DataSourceRequest] DataSourceRequest request)
        {
            var model = new TreeListModel
            {
                TreeListData = new List<TreeListData>
                {
                    new TreeListData() {Id = 1, Name = "AAA"},
                    new TreeListData() {Id = 2, Name = "BBB", ReportsTo = 1}
                }
            };

            return Json(model.TreeListData.ToTreeDataSourceResult(request));
        }
    }
}
