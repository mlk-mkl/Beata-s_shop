using Internet_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internet_shop.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy()
        {

            return View(db.Magazines.ToList());
        }

        public ActionResult ConcrectItemBuy(int id)
        {
            return View(db.Magazines.ToList().FirstOrDefault(x => x.Id == id));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}