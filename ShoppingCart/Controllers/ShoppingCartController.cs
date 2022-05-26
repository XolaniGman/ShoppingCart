using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ShoppingCart.Models;
using ShoppingCart.ViewModels;

namespace ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {



        //
        //// GET: /ShoppingCart/


        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(int id)
        {
            //Product product = new Product();
            Album album = db.Albums.Find(id);
            if (Session["cart"] == null)
            {
                List<Cart> cart = new List<Cart>();
                cart.Add(new Cart { Album = album, Count = 1, });

                Session["cart"] = cart;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session["cart"];
                int index = isExist(id.ToString());
                if (index != -1)
                {
                    cart[index].Count++;
                }
                else
                {
                    cart.Add(new Cart { Album = album, Count = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Remove(string id)
        {
            List<Items> cart = (List<Items>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Cart> cart = (List<Cart>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Album.AlbumId.Equals(id))
                    return i;
            return -1;
        }
    }
}