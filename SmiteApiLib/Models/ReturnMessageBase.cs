using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
    public class ReturnMessageBase
    {
        [JsonPropertyName("ret_msg")]
        public string? ReturnMessage { get; set; }
    }
}