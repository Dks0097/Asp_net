using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Baithi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Index",
            url: "Index",
            defaults: new {
            controller = "LayoutEx",
            action = "Index"
            } );

            routes.MapRoute(
            name: "Products",
            url: "Products",
            defaults: new
            {
                controller = "LayoutEx",
                action = "Products"
            });
            routes.MapRoute(
            name: "Blogs",
            url: "Blogs",
            defaults: new
            {
                controller = "LayoutEx",
                action = "Blogs"
            });
            routes.MapRoute(
            name: "Contacts",
            url: "Contacts",
            defaults: new
            {
                controller = "LayoutEx",
                action = "Contacts"
            });
            routes.MapRoute(
            name: "Sanpham",
            url: "Sanpham",
            defaults: new
            {
                controller = "Products",
                action = "Sanpham"
            });
            //đăng nhập
            routes.MapRoute(
            name: "Login",
            url: "Login",
            defaults: new
            {
                controller = "Login",
                action = "Login"
            });
            //đăng kí
            routes.MapRoute(
          name: "Register",
          url: "Register",
          defaults: new
          {
              controller = "User",
              action = "Register"
          });
            //người dùng
            routes.MapRoute(
            name: "Users",
            url: "Users",
            defaults: new
            {
                controller = "User",
                action = "Users"
            });
            routes.MapRoute(
           name: "Create",
           url: "Create",
           defaults: new
           {
               controller = "Products",
               action = "Create"
           });
            
            //cart
            routes.MapRoute(
         name: "ShowCart",
          url: "ShowCart",
          defaults: new
          {
              controller = "ShoppingCart",
              action = "ShowCart"
          });
            routes.MapRoute(
        name: "CheckOut",
         url: "CheckOut",
         defaults: new
         {
             controller = "ShoppingCart",
             action = "CheckOut"
         });
            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}

