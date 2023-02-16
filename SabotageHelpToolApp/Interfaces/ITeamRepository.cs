using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface ITeamRepository
    {
        ICollection<Team> GetTeams();
        Team GetTeam(int id);
        Team GetTeamByCharacter(int characterId);
        ICollection<Character> GetCharactersByTeamId(int teamId);

        bool TeamExists(int id);

    }
}
