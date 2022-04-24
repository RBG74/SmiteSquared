using SmiteApiLib.Models.DTO.JsonConverters;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public partial class ItemDTO : BaseDTO
    {
        [JsonPropertyName("ActiveFlag")]
        [JsonConverter(typeof(YesNoToBoolJsonConverter))]
        public bool ActiveFlag { get; set; }

        [JsonPropertyName("ChildItemId")]
        public long ChildItemId { get; set; }

        [JsonPropertyName("DeviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("Glyph")]
        [JsonConverter(typeof(YesNoToBoolJsonConverter))]
        public bool Glyph { get; set; }

        [JsonPropertyName("IconId")]
        public long IconId { get; set; }

        [JsonPropertyName("ItemDescription")]
        public AbilityItemDescription ItemDescription { get; set; }

        [JsonPropertyName("ItemId")]
        public long ItemId { get; set; }

        [JsonPropertyName("ItemTier")]
        public long ItemTier { get; set; }

        [JsonPropertyName("Price")]
        public long Price { get; set; }

        [JsonPropertyName("RestrictedRoles")]
        [JsonConverter(typeof(StringToRolesEnumJsonConverter))]
        public IEnumerable<RoleEnum> RestrictedRoles { get; set; }

        [JsonPropertyName("RootItemId")]
        public long RootItemId { get; set; }

        [JsonPropertyName("ShortDesc")]
        public string ShortDesc { get; set; }

        [JsonPropertyName("StartingItem")]
        public bool StartingItem { get; set; }

        [JsonPropertyName("Type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("itemIcon_URL")]
        public Uri ItemIconUrl { get; set; }
    }

    public class ItemDescription
    {
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Menuitems")]
        public Menuitem[] Menuitems { get; set; }

        [JsonPropertyName("SecondaryDescription")]
        public string SecondaryDescription { get; set; }
    }

    public class Menuitem
    {
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public enum TypeEnum
    { Active, Consumable, Item };

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}