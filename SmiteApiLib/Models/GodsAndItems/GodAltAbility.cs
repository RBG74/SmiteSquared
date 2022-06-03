using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public class GodAltAbility : ReturnMessageBase
    {
        [JsonPropertyName("god_id")]
        public long GodId { get; set; }

        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("god")]
        public string God { get; set; }

        [JsonPropertyName("alt_name")]
        public string AltName { get; set; }

        [JsonPropertyName("alt_position")]
        public string AltPosition { get; set; }
    }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}