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
        }
    }
}
