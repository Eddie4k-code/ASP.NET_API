using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;
using asp_api.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

//Character Controller handles requests.

namespace asp_api.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {


        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAll() {
            return Ok(await _characterService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id) {
            return Ok(await _characterService.GetSingle(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<AddCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter) {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

    }
}