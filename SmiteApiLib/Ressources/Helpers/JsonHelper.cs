using SmiteApiLib.Ressources.Constants;
using System.Text.Json;
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

                var elements = JsonSerializer.Deserialize<JsonElement>(json);

                var returnMessageElement = elements.ValueKind == JsonValueKind.Array ?
                    elements[0].GetProperty(ApiStuff.ReturnMessageJsonProperty) :
                    elements.GetProperty(ApiStuff.ReturnMessageJsonProperty);

                var returnMessage = returnMessageElement.ToString();
                return returnMessage;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
