namespace SabotageHelpToolApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? text { get; set; }

        public Reviewer? reviewer { get; set; }

        public Character? character { get; set; }
    }
}
