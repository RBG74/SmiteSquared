using Backend.Models.Enums;

namespace Backend.Models
{
    public class GodDTO
    {
        public GodDTO(SmiteApiLib.Models.DTO.GodDTO source)
        {
            Id = source.Id;
            Name = source.Name;
            Title = source.Title;
            Pantheon = source.Pantheon.ToPantheonEnum();
            PortaitUri = source.GodIconUrl;
            CardUri = source.GodCardUrl;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public PantheonEnum Pantheon { get; set; }
        public Uri PortaitUri { get; set; }
        public Uri CardUri { get; set; }
    }
}