using Model;
using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baithi.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        // GET: Login
        
        public ActionResult Users()
        {
            var us = new acountModel();
            var user = us.ListAll();
            return View(user);
        }



        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Register(tbl_account collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var model = new acountModel();
                    int res = model.creat(collection.username, collection.pass);
                    if (res > 0)
                        return RedirectToAction("Login", "Login");
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật không thành công");
                    }
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(string username)
        {
            //acountModel pro = new acountModel();
            //tbl_account user = new tbl_account();
            //List<tbl_account> model = pro.selectID(username);
            //for (int i = 0; i < model.Count; i++)
            //{
            //    if (model[i].username == username)
            //    {
            //        user = model[i];
            //    }
            //}
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(string username, tbl_account collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var model = new acountModel();
                    int res = model.update(username, collection.pass);
                    if (res < 0)
                        return RedirectToAction("User");
                    else
                    {
                        ModelState.AddModelError("", "Cập nhật không thành công");
                    }
                }

                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(string username)
        {
            var iplPro = new acountModel();
            var model = iplPro.selectID(username);

            return View(model);
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(tbl_account collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (true)
                {
                    var model = new acountModel();
                    int res = model.delete(collection.username);
                    if (res < 0)
                        return RedirectToAction("User");
                    else
                    {
                        ModelState.AddModelError("", "Xóa không thành công");
                    }
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }
    }
}
