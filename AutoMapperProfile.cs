using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;
using AutoMapper;

namespace asp_api
{

    //So auto mapper knows how to map.

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Turn character into getcharacterdto
            CreateMap<Character, GetCharacterDto>();

            //turn add chaarcterdto to character
            CreateMap<AddCharacterDto, Character>();

            
        }
    }
}