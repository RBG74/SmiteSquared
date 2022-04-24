namespace SmiteApiLib.Ressources.Exceptions
{
    internal class InvalidSessionException : Exception
    {
        public InvalidSessionException(string requestUrl)
        {
            RequestUrl = requestUrl;
        }

        public string RequestUrl { get; set; }
    }
}