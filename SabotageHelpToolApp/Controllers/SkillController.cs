using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SabotageHelpToolApp.Dto;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;
using SabotageHelpToolApp.Repository;

namespace SabotageHelpToolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        private readonly ISkillRepository _skillRepository;
        private IMapper _mapper;

        public SkillController(ISkillRepository skillRepository, IMapper mapper)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Skill>))]
        [ProducesResponseType(400)]
        public IActionResult GetSkills()
        {
            var skills = _mapper.Map<List<SkillDto>>(_skillRepository.GetSkills());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(skills);
        }

        [HttpGet("{skillId}")]
        [ProducesResponseType(200, Type = typeof(Skill))]
        [ProducesResponseType(400)]
        public IActionResult GetTeam(int skillId)
        {
            if (!_skillRepository.SkillExists(skillId))
            {
                return NotFound();
            }

            var team = _mapper.Map<TeamDto>(_skillRepository.GetSkill(skillId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(team);
        }

        [HttpGet("/character/{skillId}")]
        [ProducesResponseType(200, Type = typeof(Skill))]
        [ProducesResponseType(400)]
        public IActionResult CharactersBySkillId(int skillId)
        {
            var characters = _mapper.Map<List<CharacterDto>>(_skillRepository.GetCharacterBySkill(skillId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(characters);
        }
    }
}
