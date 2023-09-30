using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Dtos.Character;
using asp_api.Models;

namespace asp_api.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAll();
        Task<ServiceResponse<GetCharacterDto>> GetSingle(int id);

        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}