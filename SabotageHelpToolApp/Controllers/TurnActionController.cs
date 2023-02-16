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
    public class TurnActionController : Controller
    {
        private readonly ITurnActionRepository _turnActionRepository;
        private IMapper _mapper;

        public TurnActionController(ITurnActionRepository turnActionRepository, IMapper mapper)
        {
            _turnActionRepository = turnActionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<TurnAction>))]
        [ProducesResponseType(400)]
        public IActionResult GetITurnActions()
        {
            var turnActions = _mapper.Map<List<TurnActionDto>>(_turnActionRepository.GetTurnActions());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(turnActions);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(TurnAction))]
        [ProducesResponseType(400)]
        public IActionResult GetTeam(int id)
        {
            if (!_turnActionRepository.TurnActionExists(id))
            {
                return NotFound();
            }

            var team = _mapper.Map<TurnActionDto>(_turnActionRepository.GetTurnActionById(id));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(team);
        }
    }
}
