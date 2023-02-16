using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Interfaces
{
    public interface ISkillRepository
    {
        ICollection<Skill> GetSkills();
        Skill GetSkill(int id);

        Character GetCharacterBySkill(int id);
        bool SkillExists(int id);

    }
}
