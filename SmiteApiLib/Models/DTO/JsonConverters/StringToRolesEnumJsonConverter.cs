using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmiteApiLib.Models.DTO.JsonConverters
{
    internal class StringToRolesEnumJsonConverter : JsonConverter<IEnumerable<RoleEnum>>
    {
        public override IEnumerable<RoleEnum> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = reader.GetString();
            var converted = new List<RoleEnum>();
            if(!string.IsNullOrWhiteSpace(json))
            {
                var splits = json.Split(',');

                if (splits.Contains(RoleEnum.Assassin.ToString().ToLower()))
                {
                    converted.Add(RoleEnum.Assassin);
                }

                if (splits.Contains(RoleEnum.Guardian.ToString().ToLower()))
                {
                    converted.Add(RoleEnum.Guardian);
                }

                if (splits.Contains(RoleEnum.Hunter.ToString().ToLower()))
                {
                    converted.Add(RoleEnum.Hunter);
                }

                if (splits.Contains(RoleEnum.Mage.ToString().ToLower()))
                {
                    converted.Add(RoleEnum.Mage);
                }

                if (splits.Contains(RoleEnum.Warrior.ToString().ToLower()))
                {
                    converted.Add(RoleEnum.Warrior);
                }
            }
            return converted;
        }

        public override void Write(Utf8JsonWriter writer, IEnumerable<RoleEnum> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
