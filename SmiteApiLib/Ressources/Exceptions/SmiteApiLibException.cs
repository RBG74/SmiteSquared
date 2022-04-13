public class SmiteApiLibException : Exception
{
    public SmiteApiLibException(Exception ex) : base(ex.Message, ex)
    {
    }
}