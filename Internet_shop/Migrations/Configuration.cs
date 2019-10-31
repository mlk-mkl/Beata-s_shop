namespace Internet_shop.Migrations
{
    using Internet_shop.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Internet_shop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Internet_shop.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Magazines.AddOrUpdate(
                x => x.Id,
                new Magazine() { Name = "TEENVOGUE", Country = "USA", Price = 220, Site = "https://www.teenvogue.com/", PicturePath = "/Content/img/teenvogue.jpg" },
                new Magazine { Name = "BILLBOARD", Country = "Ucraine", Price = 40, Site = "https://www.billboard.com/music/magazine", PicturePath = "/Content/img/billboard.jpg" },
                new Magazine { Name = "VOGUE", Country = "Russia", Price = 150, Site = "https://www.vogue.com/", PicturePath = "/Content/img/vogue.jpg" },
                new Magazine { Name = "MARIE CLAIRE", Country = "USA", Price = 220, Site = "https://www.marieclaire.com/", PicturePath = "/Content/img/marieclaire.jpg" },
                new Magazine { Name = "TIME", Country = "Ucraine", Price = 40, Site = "https://time.com/", PicturePath = "/Content/img/time.jpg" },
                new Magazine { Name = "WONDERLAND", Country = "Russia", Price = 150, Site = "https://www.wonderlandmagazine.com", PicturePath = "/Content/img/wonderland.jpg" },
                new Magazine { Name = "GLAMOUR", Country = "USA", Price = 220, Site = "https://www.glamour.com/", PicturePath = "/Content/img/glamour.jpg" },
                new Magazine { Name = "FASHION", Country = "Ucraine", Price = 40, Site = "https://fashionmagazine.com", PicturePath = "/Content/img/fashion.jpg" },
                new Magazine { Name = "COSMOPOLITAN", Country = "Russia", Price = 150, Site = "https://www.cosmopolitan.com", PicturePath = "/Content/img/cosmopolitan.jpg" }
                );
        }
    }
}
