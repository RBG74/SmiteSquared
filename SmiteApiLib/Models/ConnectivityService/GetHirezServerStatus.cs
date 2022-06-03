using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
    public class GetHirezServerStatus : ReturnMessageBase
    {
        [JsonPropertyName("entry_datetime")]
        public string? EntryDatetime { get; set; }

        [JsonPropertyName("environment")]
        public string? Environment { get; set; }

        [JsonPropertyName("limited_access")]
        public bool LimitedAccess { get; set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }
    }
}