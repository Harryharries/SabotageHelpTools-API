using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Dto;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public CharacterController(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Character>))]
        [ProducesResponseType(400)]
        public IActionResult GetCharacters() 
        {
            var characters = _mapper.Map<List<CharacterDto>>(_characterRepository.GetCharacters());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(characters);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Character))]
        [ProducesResponseType(400)]
        public IActionResult GetCharacter(int id)
        {
            if (!_characterRepository.CharacterExists(id)) 
            {
                return NotFound();
            }

            var character = _mapper.Map<CharacterDto>(_characterRepository.GetCharacter(id));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(character);
        }

        [HttpGet("turnAction/{characterId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<TurnAction>))]
        [ProducesResponseType(400)]
        public IActionResult GetTurnActionsByCharacterId(int characterId)
        {
            var turnActions = _mapper.Map<List<TurnActionDto>>(_characterRepository.GetActionByCharacter(characterId));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(turnActions);
        }

        [HttpGet("skills/{characterId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Skill>))]
        [ProducesResponseType(400)]
        public IActionResult GetSkillsByCharacterId(int characterId)
        {
            var turnActions = _mapper.Map<List<SkillDto>>(_characterRepository.GetSkillsByCharacter(characterId));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(turnActions);
        }
    }
}
