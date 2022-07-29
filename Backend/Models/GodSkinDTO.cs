using Backend.Models.Enums;

namespace Backend.Models
{
    public class GodSkinDTO
    {
        public GodSkinDTO(SmiteApiLib.Models.GodSkin source)
        {
            SkinId1 = source.SkinId1;
            SkinId2 = source.SkinId2;
            GodId = source.GodId;
            GodName = source.GodName;
            SkinName = source.SkinName;
            GodSkinUri = source.GodSkinUrl;
            GodIconUri = source.GodIconUrl;
            PriceFavor = source.PriceFavor;
            PriceGems = source.PriceGems;
            Obtainability = source.Obtainability.ToObtainabilityEnum();
        }

        public long SkinId1 { get; set; }
        public long SkinId2 { get; set; }
        public long GodId { get; set; }
        public string GodName { get; set; }
        public string SkinName { get; set; }
        public Uri GodSkinUri { get; set; }
        public Uri GodIconUri { get; set; }
        public long PriceFavor { get; set; }
        public long PriceGems { get; set; }
        public ObtainabilityEnum Obtainability { get; set; }
    }
}