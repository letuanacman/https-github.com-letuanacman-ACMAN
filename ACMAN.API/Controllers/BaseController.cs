using ACMAN.API.Extentions;
using ACMAN.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACMAN.API.Controllers
{
    public class BaseController:Controller
    {
        protected DoanhNghiepDbcontext dbUser = null;
        protected ConnectStringInfo bussinessInfo = null;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bussinessInfo = SecurityExtention.GetPackageService(Session["ConnectStringInfo"].ToString());
            dbUser = new DoanhNghiepDbcontext(bussinessInfo.connectionString);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
        }
    }
}