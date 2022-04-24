using SmiteApiLib.Ressources.Constants;
using System.Text.Json;

namespace SmiteApiLib.Ressources.Helpers
{
    internal static class JsonHelper
    {
        public static string GetReturnMessageFromJson(string json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json) || !json.IsJson()) return string.Empty;

                var elements = JsonSerializer.Deserialize<JsonElement>(json);

                JsonElement returnMessageElement = new JsonElement();
                switch (elements.ValueKind)
                {
                    case JsonValueKind.Array:
                        returnMessageElement = elements[0].GetProperty(ApiStuff.ReturnMessageJsonProperty);
                        break;

                    case JsonValueKind.Object:
                        elements.GetProperty(ApiStuff.ReturnMessageJsonProperty);
                        break;
                }

                var returnMessage = returnMessageElement.ToString();
                return returnMessage;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool IsJson(this string source)
        {
            if (source == null)
                return false;

            try
            {
                JsonDocument.Parse(source);
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }
    }
}