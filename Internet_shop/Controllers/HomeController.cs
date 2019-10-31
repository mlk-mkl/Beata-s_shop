using Internet_shop.Models;
using Internet_shop.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
        [HttpGet]
        public ActionResult ConcrectItemBuy(int id)
        {
            return View(db.Magazines.ToList().FirstOrDefault(x => x.Id == id));
        }


        [HttpPost, ActionName("BuyConcrect")]
        public ActionResult BuyConcrectMagazine(PurchaseViewModel PurchaseViewModel)
        {
            string currentUserId = User.Identity.GetUserId();

            Purchase purchForDb = new Purchase()
            {
                Address = PurchaseViewModel.Address,
                Count = PurchaseViewModel.Count,
                MagazineID = PurchaseViewModel.MagazineID,
                Date = DateTime.Now,
                ApplicationUserID = new Guid(currentUserId),
                GenerealPrice = db.Magazines.FirstOrDefault(x => x.Id == PurchaseViewModel.MagazineID).Price * PurchaseViewModel.Count
            };

            db.Purchases.Add(purchForDb);

            db.SaveChanges();

            return RedirectToAction("AfterBuy", "Home", new { purchId = purchForDb.PurchaseId });
        }

        [HttpGet]
        public ActionResult AfterBuy(int purchId)
        {

            return View(db.Purchases.FirstOrDefault(x => x.PurchaseId == purchId));
        }



        public ActionResult MyPurchases()
        {
            var allPurchases = db.Purchases.ToList();
            var thisUserPurch = allPurchases.Where(x => x.ApplicationUserID == new Guid(User.Identity.GetUserId())).ToList();
            return View(thisUserPurch);
        }
    }
}