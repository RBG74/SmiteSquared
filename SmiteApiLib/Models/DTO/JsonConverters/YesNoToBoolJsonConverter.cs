using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO.JsonConverters
{
    internal class YesNoToBoolJsonConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = reader.GetString();
            return json == "Y";
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value ? "Y" : "N");
        }
    }
}