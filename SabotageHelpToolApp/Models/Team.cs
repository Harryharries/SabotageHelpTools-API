namespace SabotageHelpToolApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public ICollection<Character>? characters { get; set; }
    }
}
