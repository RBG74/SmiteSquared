public class HttpClientConnectivitySmiteApi : IConnectivitySmiteApi
{

    private HttpClient? httpClient;
    public HttpClient HttpClient
    {
        get 
        { 
            if(httpClient == null)
            {
                httpClient = new HttpClient();
            }
            return httpClient; 
        }
    }


    public async Task<string> Ping()
    {
        try
        {
            var url = ApiUriHelper.CreateApiUri(ApiMethodEnum.Ping);
            var response = await HttpClient.GetStringAsync(url);
            return response;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("\nStatusCode: ", ex.StatusCode.ToString());
            Console.WriteLine("Message :{0} ", ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    public async Task<string> CreateSession()
    {
        try
        {
            var url = ApiUriHelper.CreateApiUri(ApiMethodEnum.CreateSession);
            var response = await HttpClient.GetStringAsync(url);
            return response;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("\nStatusCode: ", ex.StatusCode.ToString());
            Console.WriteLine("Message :{0} ", ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    public Task<string> TestSession()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (HttpRequestException ex)
        {
            //TODO Handle logs
            throw;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    public Task<string> GetDataUsed()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (HttpRequestException ex)
        {
            //TODO Handle logs
            throw;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }

    public Task<string> GetHirezServerStatus()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (HttpRequestException ex)
        {
            //TODO Handle logs
            throw;
        }
        catch (Exception ex)
        {
            //TODO Handle logs
            throw;
        }
    }
}