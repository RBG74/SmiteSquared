namespace Backend.Models.Enums
{
    public enum PantheonEnum
    {
        Greek,
        Hindu,
        Maya,
        Japanese,
        Egyptian,
        Chinese,
        Celtic,
        Slavic,
        Roman,
        Voodoo,
        GreatOldOnes,
        Norse,
        Babylonian,
        Arthurian,
        Yoruba,
        Polynesian
    }

    public static class PantheonEnumExtensions
    {
        public static PantheonEnum ToPantheonEnum(this string input)
        {
            switch (input)
            {
                case "Greek":
                    return PantheonEnum.Greek;

                case "Hindu":
                    return PantheonEnum.Hindu;

                case "Maya":
                    return PantheonEnum.Maya;

                case "Japanese":
                    return PantheonEnum.Japanese;

                case "Egyptian":
                    return PantheonEnum.Egyptian;

                case "Chinese":
                    return PantheonEnum.Chinese;

                case "Celtic":
                    return PantheonEnum.Celtic;

                case "Slavic":
                    return PantheonEnum.Slavic;

                case "Roman":
                    return PantheonEnum.Roman;

                case "Voodoo":
                    return PantheonEnum.Voodoo;

                case "Great Old Ones":
                    return PantheonEnum.GreatOldOnes;

                case "Norse":
                    return PantheonEnum.Norse;

                case "Babylonian":
                    return PantheonEnum.Babylonian;

                case "Arthurian":
                    return PantheonEnum.Arthurian;

                case "Yoruba":
                    return PantheonEnum.Yoruba;

                case "Polynesian":
                    return PantheonEnum.Polynesian;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}