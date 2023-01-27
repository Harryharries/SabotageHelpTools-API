using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DataContext _context;
        public CharacterRepository(DataContext context) 
        {
            _context = context;
        }

        public ICollection<Character> GetCharacters()
        {
            return _context.Characters.OrderBy(p => p.Id).ToList();
        }
    }
}
