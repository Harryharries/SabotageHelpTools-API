using AutoMapper;
using SabotageHelpToolApp.Dto;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Character, CharacterDto>();
            CreateMap<TurnAction, TurnActionDto>();
            CreateMap<Team, TeamDto>();
            CreateMap<Skill, SkillDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<Reviewer, ReviewerDetailsDto>();
        }
    }
}
