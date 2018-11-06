namespace WorldCupAPI.Models
{
    public class Movie
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public double Rating { get; private set; }

        public Movie(){}

        public Movie(string id, string title, int year, double rating)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
        }
    }
}



