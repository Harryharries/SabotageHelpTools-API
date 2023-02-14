using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class TurnActionRepository : ITurnActionRepository
    {
        private readonly DataContext _context;

        public TurnActionRepository(DataContext context)
        {
            this._context = context;
        }

        public TurnAction GetTurnActionById(int id)
        {
            return _context.TurnActions.Where(t => t.Id == id).FirstOrDefault();
        }

        public ICollection<TurnAction> GetTurnActions()
        {
            return _context.TurnActions.ToList();
        }

        public bool TurnActionExists(int id)
        {
            return _context.TurnActions.Any(t => t.Id == id);
        }
    }
}
