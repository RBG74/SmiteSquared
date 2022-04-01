namespace SmiteApiLib.Models.ApiResponses
{
    public class GetHirezServerStatusApiResponse : BaseApiResponse
    {
        public string entry_datetime { get; set; }
        public string environment { get; set; }
        public bool limited_access { get; set; }
        public string platform { get; set; }
        public string status { get; set; }
        public string version { get; set; }
    }
}
