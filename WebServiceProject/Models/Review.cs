namespace WebServiceProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public double Rating { get; set; }



        // Ajoute cette propriété pour lier chaque critique à un utilisateur (Reviewer)
        public User Reviewer { get; set; }
        public int ReviewerId { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public Review()
        {
            Title = string.Empty;
            Text = string.Empty;
        }
    }
}
