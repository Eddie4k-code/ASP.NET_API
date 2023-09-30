using asp_api.Data;
using asp_api.Models;
using AutoMapper;


//Character serivce handles actual business logic.

namespace asp_api.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

          private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character {Name = "Sam"}
        };

        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CharacterService(IMapper mapper, DataContext context) {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {   
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            var character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;



            characters.Add(character);

            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {   
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetSingle(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse;

        }
    }
}