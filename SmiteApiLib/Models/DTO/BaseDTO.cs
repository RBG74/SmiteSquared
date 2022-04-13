using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
    public class BaseDTO
    {
        [JsonPropertyName("ret_msg")]
        public string? ReturnMessage { get; set; }
    }
}