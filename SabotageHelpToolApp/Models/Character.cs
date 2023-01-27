namespace SabotageHelpToolApp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Skill>? skills { get; set; }

        public ICollection<Review>? Reviews { get; set; }

        public ICollection<CharacterTurnAction>? CharacterTurnActions { get; set; }
    }
}
