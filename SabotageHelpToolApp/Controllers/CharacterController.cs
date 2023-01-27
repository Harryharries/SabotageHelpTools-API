using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SabotageHelpToolApp.Data;
using SabotageHelpToolApp.Interfaces;
using SabotageHelpToolApp.Models;

namespace SabotageHelpToolApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly DataContext context;

        public CharacterController(ICharacterRepository characterRepository, DataContext context)
        {
            _characterRepository = characterRepository;
            this.context = context;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Character>))]
        public IActionResult GetCharacters() 
        {
            var characters = _characterRepository.GetCharacters();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(characters);
        }
    }
}
