using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface ITurnActionRepository
    {
        ICollection<TurnAction> GetTurnActions();

        TurnAction GetTurnActionById(int id);

        bool TurnActionExists(int id);

    }
}
