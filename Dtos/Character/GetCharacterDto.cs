using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_api.Models;

namespace asp_api.Dtos.Character
{
    public class GetCharacterDto
    {
         public int Id { get; set; }

        public string Name {get; set;} = "Frodo"; //Set default value

        public int MyProperty {get; set;} = 100;

        public int Strength {get; set;} = 10;

        public int Defense {get; set;} = 10;

        public int Intelligence {get; set;} = 10;

        public RpgClass Class {get; set;} = RpgClass.Knight;
    }
}