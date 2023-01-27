namespace SabotageHelpToolApp.Models
{
    public class TurnAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<CharacterTurnAction>? CharacterTurnAction { get; set; }

    }
}
