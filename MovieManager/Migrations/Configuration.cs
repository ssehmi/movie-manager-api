namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieManager.Models.MovieManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MovieManager.Models.MovieManagerContext";
        }

        protected override void Seed(MovieManager.Models.MovieManagerContext context)
        {
            context.Movies.AddOrUpdate(p => p.Name,
                new Movie
                {
                    Name = "The Hobbit",
                    Genre = "Action",
                    ImageUrl = "http://cdn4.blinkboxmedia.com/i/contentasset31/000/064/451/ivgibvjt/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "The Avangers",
                    Genre = "Action",
                    ImageUrl = "http://cdn3.blinkboxmedia.com/i/contentasset20/000/038/582/akca4515/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Captain America",
                    Genre = "Action",
                    ImageUrl = "http://cdn1.blinkboxmedia.com/i/contentasset30/000/037/687/waodvb24/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Hulk",
                    Genre = "Action",
                    ImageUrl = "http://cdn2.blinkboxmedia.com/i/contentasset30/000/004/817/4owecr43/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Spiderman",
                    Genre = "Action",
                    ImageUrl = "http://cdn4.blinkboxmedia.com/i/contentasset31/000/027/967/0a22tiie/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Batman",
                    Genre = "Action",
                    ImageUrl = "http://cdn1.blinkboxmedia.com/i/contentasset15/000/037/807/gtqjeb2w/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "X Men",
                    Genre = "Action",
                    ImageUrl = "http://cdn4.blinkboxmedia.com/i/contentasset27/000/028/924/usyz4135/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Iron Man",
                    Genre = "Action",
                    ImageUrl = "http://cdn1.blinkboxmedia.com/i/contentasset30/000/029/760/feclx1v1/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Thor",
                    Genre = "Action",
                    ImageUrl = "http://cdn3.blinkboxmedia.com/i/contentasset31/000/035/768/o2msrytj/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Iron Man 2",
                    Genre = "Action",
                    ImageUrl = "http://cdn2.blinkboxmedia.com/i/contentasset15/000/028/001/g4pavuyy/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                },
                new Movie
                {
                    Name = "Iron Man 3",
                    Genre = "Action",
                    ImageUrl = "http://cdn3.blinkboxmedia.com/i/contentasset31/000/048/122/he1ptrvl/v=308/w=237;h=133;rm=Crop;q=85/image.jpg",
                    favourite = "false"
                });
        }
    }
}
