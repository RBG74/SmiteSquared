namespace Backend.Models.Enums
{
    public enum ObtainabilityEnum
    {
        Exclusive,
        Limited,
        Normal
    }

    public static class ObtainabilityEnumExtensions
    {
        public static ObtainabilityEnum ToObtainabilityEnum(this SmiteApiLib.Models.ObtainabilityEnum input)
        {
            switch (input)
            {
                case SmiteApiLib.Models.ObtainabilityEnum.Exclusive:
                    return ObtainabilityEnum.Exclusive;

                case SmiteApiLib.Models.ObtainabilityEnum.Limited:
                    return ObtainabilityEnum.Limited;

                case SmiteApiLib.Models.ObtainabilityEnum.Normal:
                    return ObtainabilityEnum.Normal;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}