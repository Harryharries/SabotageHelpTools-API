using AutoMapper;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TeamRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public ICollection<Character> GetCharactersByTeamId(int teamId)
        {
            return _context.Characters.Where(t => t.Team.Id == teamId).ToList();
        }

        public Team GetTeam(int id)
        {
            return _context.Teams.Where(t => t.Id == id).FirstOrDefault();
        }

        public Team GetTeamByCharacter(int characterId)
        {
            return _context.Characters.Where(c => c.Id == characterId).Select(t => t.Team).FirstOrDefault();
        }

        public ICollection<Team> GetTeams()
        {
            return _context.Teams.ToList();
        }

        public bool TeamExists(int id)
        {
            return _context.Teams.Any(t => t.Id == id);
        }
    }
}
