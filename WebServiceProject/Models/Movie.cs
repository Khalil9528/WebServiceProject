namespace WebServiceProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public string PosterUrl { get; set; }  // URL de l'affiche du film

        // Relation avec les critiques du film
        public ICollection<Review> Reviews { get; set; }

        public Movie()
        {
            Title = string.Empty;
            Synopsis = string.Empty;
            Director = string.Empty;
            PosterUrl = string.Empty;
        }

        // Calcul de la note moyenne à partir des critiques
        public double GetAverageRating()
        {
            if (Reviews == null || !Reviews.Any())
            {
                return 0;  // Pas de critiques, pas de note
            }
            return Reviews.Average(r => r.Rating);
        }
    }
}
