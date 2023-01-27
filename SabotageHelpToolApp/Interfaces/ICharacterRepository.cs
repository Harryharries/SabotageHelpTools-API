using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface ICharacterRepository
    {
        ICollection<Character> GetCharacters();

    }
}
