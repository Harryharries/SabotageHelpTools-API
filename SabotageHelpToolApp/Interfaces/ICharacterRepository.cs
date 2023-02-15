using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface ICharacterRepository
    {
        ICollection<Character> GetCharacters();
        Character GetCharacter(int id);
        Character GetCharacter(string name);
        ICollection<TurnAction> GetActionByCharacter(int characterId);

        bool CharacterExists(int id);

    }
}
