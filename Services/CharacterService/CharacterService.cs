using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;
using Microsoft.AspNetCore.Http.HttpResults;


//Character serivce handles actual business logic.

namespace asp_api.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

          private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character {Name = "Sam"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {   characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAll()
        {
            return characters;
        }

        public async Task<Character> GetSingle(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);

            if (character != null) {
                return character;
            }

            throw new Exception("Character Not Found");

        }
    }
}