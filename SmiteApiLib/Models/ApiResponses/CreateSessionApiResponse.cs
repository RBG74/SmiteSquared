using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.ApiResponses
{
    internal class CreateSessionApiResponse : BaseApiResponse
    {
        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
