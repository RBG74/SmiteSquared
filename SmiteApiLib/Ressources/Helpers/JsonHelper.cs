using SmiteApiLib.Ressources.Constants;
using System.Text.Json.Nodes;

namespace SmiteApiLib.Ressources.Helpers
{
    internal static class JsonHelper
    {
        public static string GetReturnMessageFromJson(string json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json)) return string.Empty;

                var jsonNode = JsonNode.Parse(json);
                if (jsonNode == null) return string.Empty;

                var returnMessageNode = jsonNode[0][ApiStuff.ReturnMessageJsonProperty];
                if (returnMessageNode == null) return string.Empty;

                var result = returnMessageNode.ToString();
                return result;
            }
            catch (Exception ex)
            {
                //TODO
                throw;
            }
        }
    }
}
