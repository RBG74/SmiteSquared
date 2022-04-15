using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
    public class GetPatchInfoDTO : BaseDTO
    {
        [JsonPropertyName("version_string")]
        public string? Version { get; set; }
    }
}