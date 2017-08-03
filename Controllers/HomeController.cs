using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testsaleh.Controllers
{
    public class HomeController : Controller
    {

        TestsalehEntities db = new TestsalehEntities();

        public ActionResult Index()


        { 

            var product = db.Products.ToList();
            ViewBag.myproducts = db.Products.ToList();
            return View();
        }

        public ActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProducts(string name,int price,string discription)
        {
            Product p = new Product();
            p.Name = name;
            p.Price = price;
            p.Discription = discription;

            db.Products.Add(p);
            db.SaveChanges();
            TempData["message"] = "Data is inserted";

            return View();
        }

    }
}