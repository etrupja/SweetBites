namespace SweetBites.ServerApp.Data.Models
{
    public class Sweet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfReviewers { get; set; }
        public double ReviewValue { get; set; }
        public string ImageUrl { get; set; }
    }
}
