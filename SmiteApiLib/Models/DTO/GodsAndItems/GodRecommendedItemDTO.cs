using SmiteApiLib.Models.DTO.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class GodRecommendedItemDTO : BaseDTO
    {

        [JsonPropertyName("god_id")]
        public long GodId { get; set; }

        [JsonPropertyName("god_name")]
        public string GodName { get; set; }

        [JsonPropertyName("Category")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CategoryEnum Category { get; set; }

        [JsonPropertyName("category_value_id")]
        public long CategoryValueId { get; set; }

        [JsonPropertyName("icon_id")]
        public long IconId { get; set; }

        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("Item")]
        public string Item { get; set; }

        [JsonPropertyName("Role")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleEnum Role { get; set; }

        [JsonPropertyName("role_value_id")]
        public long RoleValueId { get; set; }
    }

    public enum CategoryEnum { Consumable, Core, Damage, Defensive, Relic, Starter };

    public enum RoleEnum { Arena, Ngm3_Pep, Standard, Tutorial };


#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
