using SmiteApiLib.Models.JsonConverters;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public class GodLeaderboard : ReturnMessageBase
    {
        [JsonPropertyName("god_id")]
        [JsonConverter(typeof(StringToLongJsonConverter))]
        public long GodId { get; set; }

        [JsonPropertyName("player_id")]
        [JsonConverter(typeof(StringToLongJsonConverter))]
        public long PlayerId { get; set; }

        [JsonPropertyName("player_name")]
        public string PlayerName { get; set; }

        [JsonPropertyName("player_ranking")]
        public string PlayerRanking { get; set; }

        [JsonPropertyName("rank")]
        [JsonConverter(typeof(StringToLongJsonConverter))]
        public long Rank { get; set; }

        [JsonPropertyName("wins")]
        [JsonConverter(typeof(StringToLongJsonConverter))]
        public long Wins { get; set; }

        [JsonPropertyName("losses")]
        [JsonConverter(typeof(StringToLongJsonConverter))]
        public long Losses { get; set; }
    }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}