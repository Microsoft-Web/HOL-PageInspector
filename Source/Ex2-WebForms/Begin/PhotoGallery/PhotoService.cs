namespace PhotoGallery
{
    using System.Collections.Generic;
    using PhotoGallery.Models;

    public static class PhotoService
    {
        public static List<Photo> GetPhotos()
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

            return photoList;
        }
    }
}