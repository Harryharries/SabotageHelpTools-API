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
    public class TeamController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Team>))]
        [ProducesResponseType(400)]
        public IActionResult GetTeams()
        {
            var teams = _mapper.Map<List<TeamDto>>(_teamRepository.GetTeams());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(teams);
        }

        [HttpGet("{teamId}")]
        [ProducesResponseType(200, Type = typeof(Team))]
        [ProducesResponseType(400)]
        public IActionResult GetTeam(int teamId)
        {
            if (!_teamRepository.TeamExists(teamId))
            {
                return NotFound();
            }

            var team = _mapper.Map<TeamDto>(_teamRepository.GetTeam(teamId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(team);
        }

        [HttpGet("/team/{characterId}")]
        [ProducesResponseType(200, Type = typeof(Team))]
        [ProducesResponseType(400)]
        public IActionResult GetTeamOfCharacter(int characterId)
        {

            var team = _mapper.Map<TeamDto>(_teamRepository.GetTeamByCharacter(characterId));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(team);
        }

/*        [HttpGet("/characters/{teamId}")]*/
    }
}
