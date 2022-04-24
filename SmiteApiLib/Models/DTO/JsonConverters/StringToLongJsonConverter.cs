using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO.JsonConverters
{
    internal class StringToLongJsonConverter : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = reader.GetString();
            if (string.IsNullOrWhiteSpace(json)) return default;
            var converted = long.Parse(json);
            return converted;
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}