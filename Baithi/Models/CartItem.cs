using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unipluss.Sign.ExternalContract.Entities;

namespace Baithi.Models
{
    public class CartItem
    {
        public int ProductID { set; get; }
        public  tbl_product products { set; get; } 

        public int Quatity { set; get; }
            
    }
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(tbl_product pro , int quatity =  1 )
        {
            var item = items.FirstOrDefault(s => s.products.ID == pro.ID);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    products = pro,
                    Quatity = quatity

                });
            }
            else
            {
                item.Quatity += quatity;
            }
            
        }
        public void update_quatity (int id , int quatity)
        {
            var item = items.Find(s => s.products.ID == id);
            if(item==null)
            {
                item.Quatity = quatity;
            }
        }
        public void delete_SP_Shopping(int id)
        {
            var item = items.Find(s => s.products.ID == id);
            if (item != null)
            {
               items.Remove(item);
            }
        }
    }
}