using System.Text.Json.Serialization;

namespace SmiteApiLib.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public class GodSkin : ReturnMessageBase
    {
        [JsonPropertyName("godIcon_URL")]
        public Uri GodIconUrl { get; set; }

        [JsonPropertyName("godSkin_URL")]
        public Uri GodSkinUrl { get; set; }

        [JsonPropertyName("god_id")]
        public long GodId { get; set; }

        [JsonPropertyName("god_name")]
        public string GodName { get; set; }

        [JsonPropertyName("obtainability")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ObtainabilityEnum Obtainability { get; set; }

        [JsonPropertyName("price_favor")]
        public long PriceFavor { get; set; }

        [JsonPropertyName("price_gems")]
        public long PriceGems { get; set; }

        [JsonPropertyName("skin_id1")]
        public long SkinId1 { get; set; }

        [JsonPropertyName("skin_id2")]
        public long SkinId2 { get; set; }

        [JsonPropertyName("skin_name")]
        public string SkinName { get; set; }
    }

    public enum ObtainabilityEnum
    { Exclusive, Limited, Normal };

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}