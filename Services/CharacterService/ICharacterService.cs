using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;

namespace asp_api.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAll();
        Task<Character> GetSingle(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}