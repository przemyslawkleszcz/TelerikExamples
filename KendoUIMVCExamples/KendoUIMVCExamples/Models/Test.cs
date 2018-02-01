using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;

namespace KendoUIMVCExamples.Models
{
    public static class ReflectionHelper
    {
        private static PropertyInfo GetPropertyInfo(Type type, string propertyName)
        {
            PropertyInfo propInfo = null;
            do
            {
                propInfo = type.GetProperty(propertyName,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                type = type.BaseType;
            }
            while (propInfo == null && type != null);
            return propInfo;
        }

        public static object GetPropertyValue(this object obj, string propertyName)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            Type objType = obj.GetType();
            PropertyInfo propInfo = GetPropertyInfo(objType, propertyName);
            if (propInfo == null)
                throw new ArgumentOutOfRangeException("propertyName",
                    string.Format("Couldn't find property {0} in type {1}", propertyName, objType.FullName));
            return propInfo.GetValue(obj, null);
        }

        public static void SetPropertyValue(this object obj, string propertyName, object val)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            Type objType = obj.GetType();
            PropertyInfo propInfo = GetPropertyInfo(objType, propertyName);
            if (propInfo == null)
                throw new ArgumentOutOfRangeException("propertyName",
                    string.Format("Couldn't find property {0} in type {1}", propertyName, objType.FullName));
            propInfo.SetValue(obj, val, null);
        }
    }

    public static class Test
    {
        

        public static string DoSomething(this HtmlHelper helper)
        {
            

            //var moduleName = helper.ViewContext.RouteData.GetRequiredString("module");
            var engine = new RazorViewEngine();
            var result = engine.FindView(helper.ViewContext.Controller.ControllerContext, "AjaxBinding", "AjaxBinding", false);
            var buildManager = result.View.GetPropertyValue("BuildManager");



            //if (moduleName.Equals(this.Module.Name, StringComparison.InvariantCultureIgnoreCase))
            //{
            //    var baseResult = base.FindView(controllerContext, viewName, masterName, useCache);
            //    return baseResult;
            //}


            return "";
        }
    }
}