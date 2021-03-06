﻿namespace PhotoGallery.Controllers
{
    using PhotoGallery.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var photoList = new List<Photo>
            {
                new Photo 
                {
                    Title = "Chrysanthemum",
                    FileName = "Chrysanthemum.jpg"
                },
                new Photo 
                {
                    Title = "Koala",
                    FileName = "Koala.jpg"
                },
                new Photo 
                {
                    Title = "Penguins",
                    FileName = "Penguins.jpg"
                },
                new Photo 
                {
                    Title = "Tulips",
                    FileName = "Tulips.jpg"
                },
                new Photo 
                {
                    Title = "Desert",
                    FileName = "Desert.jpg"
                },
                new Photo 
                {
                    Title = "Lighthouse",
                    FileName = "Lighthouse.jpg"
                },
                new Photo 
                {
                    Title = "Jellyfish",
                    FileName = "Jellyfish.jpg"
                }
            };

            return this.View(photoList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}
