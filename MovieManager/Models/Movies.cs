using System.Globalization;

namespace MovieManager.Models
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string favourite { get; set; }
        public string Self 
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                    "api/Movies/{0}", this.MovieId);
            }
            set { }
        }
    }
}