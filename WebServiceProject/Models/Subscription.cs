namespace WebServiceProject.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Type { get; set; }  // Type d'abonnement (ex. : Basic, Premium)
        public decimal Price { get; set; }  // Prix de l'abonnement
        public DateTime StartDate { get; set; }  // Date de début de l'abonnement
        public DateTime EndDate { get; set; }    // Date de fin de l'abonnement, si applicable

        // Relation avec l'utilisateur
        public int UserId { get; set; }
        public User User { get; set; }  // L'utilisateur qui possède cet abonnement

        public Subscription()
        {
            Type = string.Empty;
        }
    }
}
