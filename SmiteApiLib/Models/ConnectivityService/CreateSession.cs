using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
    internal class CreateSession : ReturnMessageBase
    {
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        [JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }
    }
}