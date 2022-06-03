namespace Backend.Models
{
    public class AbilityDTO
    {
        public AbilityDTO(SmiteApiLib.Models.Ability source)
        {
            Id = source.Id;
            Name = source.Summary;
            IconUrl = source.Url;
            Cooldown = source.Description.ItemDescription.Cooldown;
            Cost = source.Description.ItemDescription.Cost;
            Description = source.Description.ItemDescription.Description;
            MenuItems = source.Description.ItemDescription.Menuitems
                .Select(mi => new KeyValuePair<string, string>(mi.Description, mi.Value)).ToList();
            RankItems = source.Description.ItemDescription.Rankitems
                .Select(mi => new KeyValuePair<string, string>(mi.Description, mi.Value)).ToList();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Uri IconUrl { get; set; }
        public string Cooldown { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public List<KeyValuePair<string, string>> MenuItems { get; set; }
        public List<KeyValuePair<string, string>> RankItems { get; set; }
    }
}