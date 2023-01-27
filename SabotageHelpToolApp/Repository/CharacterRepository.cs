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

        public bool CharacterExists(int id)
        {
            return _context.Characters.Any(c => c.Id == id);
        }

        public Character GetCharacter(int id)
        {
            return _context.Characters.Where(c => c.Id == id).FirstOrDefault();
        }

        public Character GetCharacter(string name)
        {
            return _context.Characters.Where(c => c.Name == name).FirstOrDefault();
        }

        public ICollection<Character> GetCharacters()
        {
            return _context.Characters.OrderBy(p => p.Id).ToList();
        }
    }
}
