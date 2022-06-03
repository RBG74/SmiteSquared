namespace Backend.Models
{
    public class GodDTO
    {
        public GodDTO(SmiteApiLib.Models.DTO.GodDTO source)
        {
            Id = source.Id;
            Name = source.Name;
            Title = source.Title;
            Pantheon = source.Pantheon;
            Lore = source.Lore;
            PortaitUri = source.GodIconUrl;
            CardUri = source.GodCardUrl;
            Passive = new AbilityDTO(source.Ability5);
            Ability1 = new AbilityDTO(source.Ability1);
            Ability2 = new AbilityDTO(source.Ability2);
            Ability3 = new AbilityDTO(source.Ability3);
            Ability4 = new AbilityDTO(source.Ability4);
            BasicAttack = source.BasicAttack.ItemDescription.Menuitems
                .Select(mi => new KeyValuePair<string, string>(mi.Description, mi.Value)).ToList();
            Statistics = new GodStatisticsDTO(source);
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Pantheon { get; set; }
        public string Lore { get; set; }
        public Uri PortaitUri { get; set; }
        public Uri CardUri { get; set; }
        public AbilityDTO Passive { get; set; }
        public AbilityDTO Ability1 { get; set; }
        public AbilityDTO Ability2 { get; set; }
        public AbilityDTO Ability3 { get; set; }
        public AbilityDTO Ability4 { get; set; }
        public List<KeyValuePair<string, string>> BasicAttack { get; set; }
        public GodStatisticsDTO Statistics { get; set; }
    }
}