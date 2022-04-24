using SmiteApiLib.Models.DTO.JsonConverters;
using System.Text.Json.Serialization;

namespace SmiteApiLib.Models.DTO
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public class GodDTO : BaseDTO
    {
        [JsonPropertyName("Ability1")]
        public string AbilityName1 { get; set; }

        [JsonPropertyName("Ability2")]
        public string AbilityName2 { get; set; }

        [JsonPropertyName("Ability3")]
        public string AbilityName3 { get; set; }

        [JsonPropertyName("Ability4")]
        public string AbilityName4 { get; set; }

        [JsonPropertyName("Ability5")]
        public string AbilityName5 { get; set; }

        [JsonPropertyName("AbilityId1")]
        public long AbilityId1 { get; set; }

        [JsonPropertyName("AbilityId2")]
        public long AbilityId2 { get; set; }

        [JsonPropertyName("AbilityId3")]
        public long AbilityId3 { get; set; }

        [JsonPropertyName("AbilityId4")]
        public long AbilityId4 { get; set; }

        [JsonPropertyName("AbilityId5")]
        public long AbilityId5 { get; set; }

        [JsonPropertyName("Ability_1")]
        public Ability Ability1 { get; set; }

        [JsonPropertyName("Ability_2")]
        public Ability Ability2 { get; set; }

        [JsonPropertyName("Ability_3")]
        public Ability Ability3 { get; set; }

        [JsonPropertyName("Ability_4")]
        public Ability Ability4 { get; set; }

        [JsonPropertyName("Ability_5")]
        public Ability Ability5 { get; set; }

        [JsonPropertyName("AttackSpeed")]
        public double AttackSpeed { get; set; }

        [JsonPropertyName("AttackSpeedPerLevel")]
        public double AttackSpeedPerLevel { get; set; }

        [JsonPropertyName("AutoBanned")]
        [JsonConverter(typeof(YesNoToBoolJsonConverter))]
        public bool AutoBanned { get; set; }

        [JsonPropertyName("Cons")]
        public string Cons { get; set; }

        [JsonPropertyName("HP5PerLevel")]
        public double Hp5PerLevel { get; set; }

        [JsonPropertyName("Health")]
        public long Health { get; set; }

        [JsonPropertyName("HealthPerFive")]
        public long HealthPerFive { get; set; }

        [JsonPropertyName("HealthPerLevel")]
        public long HealthPerLevel { get; set; }

        [JsonPropertyName("Lore")]
        public string Lore { get; set; }

        [JsonPropertyName("MP5PerLevel")]
        public double Mp5PerLevel { get; set; }

        [JsonPropertyName("MagicProtection")]
        public long MagicProtection { get; set; }

        [JsonPropertyName("MagicProtectionPerLevel")]
        public double MagicProtectionPerLevel { get; set; }

        [JsonPropertyName("MagicalPower")]
        public long MagicalPower { get; set; }

        [JsonPropertyName("MagicalPowerPerLevel")]
        public double MagicalPowerPerLevel { get; set; }

        [JsonPropertyName("Mana")]
        public long Mana { get; set; }

        [JsonPropertyName("ManaPerFive")]
        public double ManaPerFive { get; set; }

        [JsonPropertyName("ManaPerLevel")]
        public long ManaPerLevel { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("OnFreeRotation")]
        public string OnFreeRotation { get; set; }

        [JsonPropertyName("Pantheon")]
        public string Pantheon { get; set; }

        [JsonPropertyName("PhysicalPower")]
        public long PhysicalPower { get; set; }

        [JsonPropertyName("PhysicalPowerPerLevel")]
        public double PhysicalPowerPerLevel { get; set; }

        [JsonPropertyName("PhysicalProtection")]
        public long PhysicalProtection { get; set; }

        [JsonPropertyName("PhysicalProtectionPerLevel")]
        public double PhysicalProtectionPerLevel { get; set; }

        [JsonPropertyName("Pros")]
        public string Pros { get; set; }

        [JsonPropertyName("Roles")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleEnum Roles { get; set; }

        [JsonPropertyName("Speed")]
        public long Speed { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("abilityDescription1")]
        public AbilityDescription AbilityDescription1 { get; set; }

        [JsonPropertyName("abilityDescription2")]
        public AbilityDescription AbilityDescription2 { get; set; }

        [JsonPropertyName("abilityDescription3")]
        public AbilityDescription AbilityDescription3 { get; set; }

        [JsonPropertyName("abilityDescription4")]
        public AbilityDescription AbilityDescription4 { get; set; }

        [JsonPropertyName("abilityDescription5")]
        public AbilityDescription AbilityDescription5 { get; set; }

        [JsonPropertyName("basicAttack")]
        public AbilityDescription BasicAttack { get; set; }

        [JsonPropertyName("godAbility1_URL")]
        public Uri GodAbility1Url { get; set; }

        [JsonPropertyName("godAbility2_URL")]
        public Uri GodAbility2Url { get; set; }

        [JsonPropertyName("godAbility3_URL")]
        public Uri GodAbility3Url { get; set; }

        [JsonPropertyName("godAbility4_URL")]
        public Uri GodAbility4Url { get; set; }

        [JsonPropertyName("godAbility5_URL")]
        public Uri GodAbility5Url { get; set; }

        [JsonPropertyName("godCard_URL")]
        public Uri GodCardUrl { get; set; }

        [JsonPropertyName("godIcon_URL")]
        public Uri GodIconUrl { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("latestGod")]
        [JsonConverter(typeof(YesNoToBoolJsonConverter))]
        public bool LatestGod { get; set; }
    }

    public class AbilityDescription
    {
        [JsonPropertyName("itemDescription")]
        public AbilityItemDescription ItemDescription { get; set; }
    }

    public class AbilityItemDescription
    {
        [JsonPropertyName("cooldown")]
        public string Cooldown { get; set; }

        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("menuitems")]
        public Item[] Menuitems { get; set; }

        [JsonPropertyName("rankitems")]
        public Item[] Rankitems { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Ability
    {
        [JsonPropertyName("Description")]
        public AbilityDescription Description { get; set; }

        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Summary")]
        public string Summary { get; set; }

        [JsonPropertyName("URL")]
        public Uri Url { get; set; }
    }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}