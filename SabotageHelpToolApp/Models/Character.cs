namespace SabotageHelpToolApp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Skill>? Skills { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        public Team? Team { get; set; }

        public ICollection<CharacterTurnAction>? CharacterTurnActions { get; set; }
    }
}
