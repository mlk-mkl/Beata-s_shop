using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internet_shop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public Guid ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int MagazineID { get; set; }
        public virtual Magazine Magazine { get; set; }

        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Count{ get; set; }
        public int GenerealPrice { get; set; }

    }
}