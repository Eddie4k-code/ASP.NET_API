

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace asp_api.Models
{   
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {   
        [EnumMember(Value = "Knight")]
        Knight = 1,

        [EnumMember(Value = "Mage")]
        Mage = 2,

        [EnumMember(Value = "Cleric")]
        Cleric = 3

    }
}