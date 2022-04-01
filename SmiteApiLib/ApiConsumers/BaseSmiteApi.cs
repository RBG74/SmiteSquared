using SmiteApiLib.Constants;
using SmiteApiLib.Models.ApiResponses;
using SmiteApiLib.Ressources.Exceptions;
using SmiteApiLib.Ressources.Helpers;
using System.Text.Json;

namespace SmiteApiLib
{
    internal class BaseSmiteApi
    {
        private HttpClient _httpClient;

        public BaseSmiteApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected async Task<string> ExecuteRequest(string url)
        {
            return await ExecuteRequest(url, 0);
        }

        private async Task<string> ExecuteRequest(string url, int executionCounter = 0)
        {
            executionCounter++;
            try
            {
                var sessionId = await GetSessionId();
                url = string.Format(url, sessionId);

                var jsonResponse = await _httpClient.GetStringAsync(url);

                var returnMessage = JsonHelper.GetReturnMessageFromJson(jsonResponse);
                if (returnMessage == ApiResponses.InvalidSessionId)
                {
                    await LocalSessionHelper.WriteSessionId(string.Empty);
                    if (executionCounter > 3) throw new InvalidSessionException(url);
                    return await ExecuteRequest(url, executionCounter);
                }
                return jsonResponse;
            }
            catch (Exception ex)
            {
                //TODO
                throw;
            }
        }

        private async Task<string> GetSessionId()
        {
            try
            {
                var sessionId = await LocalSessionHelper.GetExistingSessionId();
                if (string.IsNullOrWhiteSpace(sessionId))
                {
                    var url = ApiUriHelper.GetCreateSessionUrl();
                    var jsonResponse = await _httpClient.GetStringAsync(url);
                    var response = JsonSerializer.Deserialize<CreateSessionApiResponse>(jsonResponse);
                    sessionId = response!.SessionId!;
                    await LocalSessionHelper.WriteSessionId(sessionId);
                    Console.WriteLine("---New session generated !---");//TODO
                }
                return sessionId;
            }
            catch (Exception ex)
            {
                //TODO
                throw;
            }
        }

    }
}
