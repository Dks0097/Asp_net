using Baithi.code;
using dbAspNet.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baithi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            var result = new acountModel().Login(model.UserName,
            model.Password, model.QL);
            
            if (result && ModelState.IsValid)
            {
                bool isAuthentic = (model.UserName.Equals("admin") && model.Password.Equals("123"));
                SessionHelper.SetSession(new UserSession()
                {
                    UserName = model.UserName
                });
                if (isAuthentic)
                {
                    return RedirectToAction("Sanpham", "Products");
                }
                else
                {
                    return RedirectToAction("Index", "LayoutEx");
                }
                




            }
           
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng !");
            }
            return View(model);
        }
        
    }
}