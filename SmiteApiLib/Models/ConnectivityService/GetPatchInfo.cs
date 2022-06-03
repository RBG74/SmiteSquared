using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
    public class GetPatchInfo : ReturnMessageBase
    {
        [JsonPropertyName("version_string")]
        public string? Version { get; set; }
    }
}