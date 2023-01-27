using System;

namespace SabotageHelpToolApp.Models
{
    public class CharacterTurnAction
    {
        public int CharacterId { get; set; }
        public int TurnActionId { get; set; }
        public Character Character { get; set; }
        public TurnAction TurnAction { get; set; }
    }
}
