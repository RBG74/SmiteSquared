using SmiteApiLib.Ressources.Enums;

namespace SmiteApiLib.Ressources.Constants
{
    internal static class ApiStuff
    {
        internal static readonly string BaseUrl = "https://api.smitegame.com/smiteapi.svc";
        internal static readonly LanguageCodeEnum DefaultLanguageCode = LanguageCodeEnum.English;
        internal static readonly string ReturnMessageJsonProperty = "ret_msg";
    }
}