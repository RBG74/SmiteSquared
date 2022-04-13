using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
    internal class CreateSessionDTO : BaseDTO
    {
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
    }
}
