using Model.Framework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baithi.Controllers
{
    public class LayoutExController : Controller
    {
        // GET: LayoutEx
        public ActionResult Index()
        {
            var iplPro = new productsModel();
            var model = iplPro.ListAll();
            return View(model);
        }
        public ActionResult Products()
        {
            var iplPro = new productsModel();
 var model = iplPro.ListAll();
 return View(model);
        }
        public ActionResult Blogs()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
       
    }
}