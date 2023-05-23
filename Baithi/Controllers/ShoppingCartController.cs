using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baithi.Models;
using Model.Framework;

namespace Baithi.Controllers
{
    public class ShoppingCartController : Controller
    {
        Entities db = new Entities();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        // GET: ShoppingCart
        public ActionResult AddtoCart(int id)
        {
            var pro = db.tbl_product.SingleOrDefault(s => s.ID == id);
            if (pro != null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ShowCart", "ShoppingCart");
        }

        //trang gio hang
        public ActionResult ShowCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ShowCart", "ShoppingCart");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);

        }
        public ActionResult CheckOut()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("CheckOut", "ShoppingCart");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);

        }
        public ActionResult Update_Quatity_Cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int id = int.Parse(form["ID_Product"]);
            int quatity = int.Parse(form["quatity"]);
            cart.update_quatity(id , quatity);
            return RedirectToAction("ShowCart", "ShoppingCart");
        }
        public ActionResult delete_SP(int id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.delete_SP_Shopping(id);
            return RedirectToAction("ShowCart", "ShoppingCart");
        }
    }
}