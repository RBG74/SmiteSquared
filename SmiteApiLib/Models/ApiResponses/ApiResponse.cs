using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.ApiResponses
{
    public class BaseApiResponse
    {
        [JsonPropertyName("ret_msg")]
        public string? ReturnMessage { get; set; }
    }
}
