using Microsoft.Extensions.Logging;
using SmiteApiLib.Models.DTO;
using SmiteApiLib.Ressources.Constants;
using SmiteApiLib.Ressources.Exceptions;
using SmiteApiLib.Ressources.Helpers;
using System.Text.Json;

public class BaseSmiteApi
{
    protected ILogger? _logger;
    private readonly HttpClient _httpClient;

    public BaseSmiteApi(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    protected void ManageException(Exception ex)
    {
        _logger?.LogError(ex.Message, ex);
        throw ex;
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
            var formatedUrl = string.Format(url, sessionId);

            var jsonResponse = await _httpClient.GetStringAsync(formatedUrl);

            var returnMessage = JsonHelper.GetReturnMessageFromJson(jsonResponse);
            if (returnMessage == ApiResponses.InvalidSessionId)
            {
                await LocalSessionHelper.WriteSessionId(string.Empty);
                if (executionCounter > 3) throw new InvalidSessionException(formatedUrl);
                return await ExecuteRequest(url, executionCounter);
            }
            return jsonResponse;
        }
        catch (Exception ex)
        {
            _logger?.LogError(ex.Message, ex);
            throw new SmiteApiLibException(ex);
        }
    }

    private async Task<string> GetSessionId()
    {
        //Gets locally stored Session if there is one, if it is expired it will be deleted by the ExecuteRequest method which will then call this method again
        var sessionId = await LocalSessionHelper.GetExistingSessionId();
        if (string.IsNullOrWhiteSpace(sessionId))
        {
            var url = ApiUriHelper.GetCreateSessionUrl();
            var jsonResponse = await _httpClient.GetStringAsync(url);
            var response = JsonSerializer.Deserialize<CreateSessionDTO>(jsonResponse);
            sessionId = response!.SessionId!;
            await LocalSessionHelper.WriteSessionId(sessionId);
        }
        return sessionId;
    }

}