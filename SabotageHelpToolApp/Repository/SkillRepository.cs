using AutoMapper;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Repository
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public SkillRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public Character GetCharacterBySkill(int id)
        {
            return _context.Skills.Where(t => t.Id == id).Select(s=> s.Character).FirstOrDefault(); ;
        }

        public Skill GetSkill(int id)
        {
            return _context.Skills.Where(t => t.Id == id).FirstOrDefault();
        }

        public ICollection<Skill> GetSkills()
        {
            return _context.Skills.ToList();
        }

        public bool SkillExists(int id)
        {
            return _context.Skills.Any(t => t.Id == id);
        }

    }
}
