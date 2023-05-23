using Model.Framework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baithi.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
        var iplPro = new productsModel();
         var model = iplPro.ListAll();
        return View(model);
            }

        public ActionResult Sanpham()
        {
            var iplPro = new productsModel();
            var model = iplPro.ListAll();
            return View(model);
        }
        // GET: Products/Details/5
       
        public ActionResult Details(int id)
        {
            var iplPro = new productsModel();
            var objproduct = iplPro.selectID(id).Where(n => n.ID == id).FirstOrDefault();

            return View(objproduct);
        }

        // GET: Products/Create
       
        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(tbl_product collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var model = new productsModel();
                    int res = model.create(collection.ID, collection.Name, collection.Price, collection.Detail, collection.Images);
                    if (res > 0)
                        return RedirectToAction("Sanpham");
                    else
                    {
                        ModelState.AddModelError("", "Thêm không thành công");
                    }
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            productsModel pro = new productsModel();
            tbl_product product = new tbl_product();
            List<tbl_product> model = pro.selectID(id);
            for (int i = 0; i < model.Count; i++)
            {
                if (model[i].ID == id)
                {
                    product = model[i];
                }
            }
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tbl_product collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var model = new productsModel();
                    int res = model.update(collection.ID, collection.Name, collection.Price, collection.Detail, collection.Images);
                    if (res < 0)
                        return RedirectToAction("Sanpham");
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



        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            var iplPro = new productsModel();
            var model = iplPro.selectID(id);

            return View(model);
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(tbl_product collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (true)
                {
                    var model = new productsModel();
                    int res = model.delete(collection.ID);
                    if (res < 0)
                        return RedirectToAction("Sanpham");
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
